﻿using System.IO;
using System.Linq;
using System.Text;
using WowPacketParser.Misc;

namespace WowPacketParser.Parsing.Parsers
{
    public class BattlenetModuleHandler
    {
        private Packet packet { get; set; }

        public BattlenetModuleHandler(BattlenetPacket packet)
        {
            this.packet = packet.Stream;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="module">Battle.net module id as string</param>
        /// <param name="data"></param>
        /// <returns>null if module is unhandled, false if it needs more data from client</returns>
        public bool? HandleData(string module, byte[] data, params int[] values)
        {
            var reader = new BinaryReader(new MemoryStream(data));
            switch (module)
            {
                case "8F52906A2C85B416A595702251570F96D3522F39237603115F2F1AB24962043C":    // Win
                case "63BC118937E6EA2FAA7B7192676DAEB1B7CA87A9C24ED9F5ACD60E630B4DD7A4":    // Mac
                case "0A3AFEE2CADE3A0E8B458C4B4660104CAC7FC50E2CA9BEF0D708942E77F15C1D":    // Wn64
                case "97EEB2E28E9E56ED6A22D09F44E2FF43C93315E006BBAD43BAFC0DEFAA6F50AE":    // Mc64
                    WriteLine("Name", "Password", values);
                    return HandlePassword(reader, values);
                case "FBE675A99FB5F4B7FB3EB5E5A22ADD91A4CABF83E3C5930C6659AD13C457BA18":    // Win
                case "393CA8D75AFF6F04F79532CF95A88B91E5743BC59121520AC31FC4508019FE60":    // Mac
                case "A330F388B6687F8A42FE8FBB592A3DF724B20B65FB0989342BB8261F2F452318":    // Wn64
                case "A1EDAB845D9E13E9C84531369BE2F61B930A37C8E7A9C66D11EF8963380E178A":    // Mc64
                    WriteLine("Name", "Token", values);
                    return HandleToken(reader, values);
                case "36B27CD911B33C61730A8B82C8B2495FD16E8024FC3B2DDE08861C77A852941C":    // Win
                case "548B5EF9E0DD5C2F89F59C3E0979249B27505C51F0C77D2B27133726EAEE0AD0":    // Mac
                case "C3A1AC0694979E709C3B5486927E558AF1E2BE02CA96E5615C5A65AACC829226":    // Wn64
                case "B37136B39ADD83CFDBAFA81857DE3DD8F15B34E0135EC6CD9C3131D3A578D8C2":    // Mc64
                    WriteLine("Name", "Thumbprint", values);
                    return HandleThumbprint(reader, values);
                case "ABC6BB719A73EC1055296001910E26AFA561F701AD9995B1ECD7F55F9D3CA37C":    // Win
                case "207640724F4531D3B2A21532224D1486E8C4D2D805170381CBC3093264157960":    // Mac
                case "894D25D3219D97D085EA5A8B98E66DF5BD9F460EC6F104455246A12B8921409D":    // Wn64
                case "52E2978DB6468DFADE7C61DA89513F443C9225692B5085FBE956749870993703":    // Mc64
                    WriteLine("Name", "SelectGameAccount", values);
                    return HandleSelectGameAccount(reader, values);
                case "5E298E530698AF905E1247E51EF0B109B352AC310CE7802A1F63613DB980ED17":    // Win
                case "C0F38D05AA1B83065E839C9BD96C831E9F7E42477085138752657A6A9BB9C520":    // Mac
                case "8C43BDA10BE33A32ABBC09FB2279126C7F5953336391276CFF588565332FCD40":    // Wn64
                case "1AF5418A448F8AD05451E3F7DBB2D9AF9CB13458EEA2368EBFC539476B954F1C":    // Mc64
                    WriteLine("Name", "RiskFingerprint", values);
                    return HandleRiskFingerprint(reader, values);
                case "BFE4CEB47700AA872E815E007E27DF955D4CD4BC1FE731039EE6498CE209F368":    // Win
                case "00FFD88A437AFBB88D7D4B74BE2E3B43601605EE229151AA9F4BEBB29EF66280":    // Mac
                case "898166926805F897804BDBBF40662C9D768590A51A0B26C40DBCDF332BA11974":    // Wn64
                case "304627D437C38500C0B5CA0C6220EEADE91390E52A2B005FF3F7754AFA1F93CD":    // Mc64
                    WriteLine("Name", "Resume", values);
                    return HandleResume(reader, values);
            }

            return null;
        }

        private void WriteLine(string name, object value, params int[] values)
        {
            packet.WriteLine("{0}{1}: {2}", Packet.GetIndexString(values), name, value);
        }

        public bool HandlePassword(BinaryReader reader, params int[] values)
        {
            var state = reader.ReadByte();
            WriteLine("State", state, values);
            switch (state)
            {
                case 0:
                    WriteLine("I", Utilities.ByteArrayToHexString(reader.ReadBytes(32)), values);
                    WriteLine("s", Utilities.ByteArrayToHexString(reader.ReadBytes(32)), values);
                    WriteLine("B", Utilities.ByteArrayToHexString(reader.ReadBytes(128)), values);
                    WriteLine("unk", Utilities.ByteArrayToHexString(reader.ReadBytes(128)), values);
                    return false;
                case 2:
                    WriteLine("a", Utilities.ByteArrayToHexString(reader.ReadBytes(128)), values);
                    WriteLine("M1", Utilities.ByteArrayToHexString(reader.ReadBytes(32)), values);
                    WriteLine("A", Utilities.ByteArrayToHexString(reader.ReadBytes(128)), values);
                    return true;
                case 3:
                    WriteLine("M2", Utilities.ByteArrayToHexString(reader.ReadBytes(32)), values);
                    WriteLine("unk", Utilities.ByteArrayToHexString(reader.ReadBytes(128)), values);
                    return true;
            }
            return false;
        }

        private bool HandleToken(BinaryReader reader, params int[] values)
        {
            var state = reader.ReadByte();
            WriteLine("State", state, values);
            switch (state)
            {
                case 0:
                    WriteLine("Unk", reader.ReadByte(), values);
                    WriteLine("Token id", Utilities.ByteArrayToHexString(reader.ReadBytes(8).Reverse().ToArray()), values);
                    WriteLine("Unk counter", reader.ReadByte(), values);
                    WriteLine("Crypt entropy", Utilities.ByteArrayToHexString(reader.ReadBytes(16)), values);
                    return false;
                case 1:
                    WriteLine("Token key", Utilities.ByteArrayToHexString(reader.ReadBytes(8)), values);
                    WriteLine("Token", reader.ReadUInt32(), values);
                    return true;
                case 2:
                    WriteLine("data", Utilities.ByteArrayToHexString(reader.ReadBytes(36)), values);
                    return true;
                case 3:
                    WriteLine("Token id", Utilities.ByteArrayToHexString(reader.ReadBytes(8).Reverse().ToArray()), values);
                    WriteLine("Crypt entropy", Utilities.ByteArrayToHexString(reader.ReadBytes(16)), values);
                    WriteLine("Token key", Utilities.ByteArrayToHexString(reader.ReadBytes(8)), values);
                    WriteLine("Token data", Utilities.ByteArrayToHexString(reader.ReadBytes(16)), values);
                    return true;
            }

            return true;
        }

        private bool HandleThumbprint(BinaryReader reader, params int[] values)
        {
            WriteLine("Data", Utilities.ByteArrayToHexString(reader.ReadBytes(512)), values);
            return true;
        }

        private bool HandleSelectGameAccount(BinaryReader reader, params int[] values)
        {
            var state = reader.ReadByte();
            WriteLine("State", state, values);
            switch (state)
            {
                case 0:
                    var accounts = reader.ReadByte();
                    for (var i = 0; i < accounts; ++i)
                    {
                        WriteLine("Unk", reader.ReadByte(), values.Concat(new int[1] { i }).ToArray());
                        WriteLine("Account name", Encoding.ASCII.GetString(reader.ReadBytes(reader.ReadByte())), values.Concat(new int[1] { i }).ToArray());
                    }
                    return false;
                case 1:
                    WriteLine("Unk", reader.ReadByte(), values);
                    WriteLine("Account name", Encoding.ASCII.GetString(reader.ReadBytes(reader.ReadByte())), values);
                    return true;
            }
            return true;
        }

        private bool HandleRiskFingerprint(BinaryReader reader, params int[] values)
        {
            if (reader.BaseStream.Length == 0)
                return false;

            var unk1 = reader.ReadUInt32();
            WriteLine("Unk1", unk1, values);
            if (unk1 == 10000)
                return true;

            var count = reader.ReadUInt32();
            for (var i = 0; i < count; ++i)
            {
                WriteLine("Data", Encoding.ASCII.GetString(reader.ReadBytes(4).Reverse().ToArray()).Trim(new char[1] { '\0' }), values.Concat(new int[1] { i }).ToArray());
                WriteLine("Value", reader.ReadUInt32(), values.Concat(new int[1] { i }).ToArray());
            }

            return true;
        }

        private bool HandleResume(BinaryReader reader, params int[] values)
        {
            var state = reader.ReadByte();
            WriteLine("State", state, values);
            switch (state)
            {
                case 0:
                    WriteLine("Server challenge", Utilities.ByteArrayToHexString(reader.ReadBytes(16).Reverse().ToArray()), values);
                    return false;
                case 1:
                    WriteLine("Client challenge", Utilities.ByteArrayToHexString(reader.ReadBytes(16).Reverse().ToArray()), values);
                    WriteLine("Client proof", Utilities.ByteArrayToHexString(reader.ReadBytes(32).Reverse().ToArray()), values);
                    break;
                case 2:
                    WriteLine("Server proof", Utilities.ByteArrayToHexString(reader.ReadBytes(32).Reverse().ToArray()), values);
                    break;
            }

            return true;
        }
    }
}
