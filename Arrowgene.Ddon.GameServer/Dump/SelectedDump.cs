using Arrowgene.Ddon.Server.Network;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.GameServer.Dump
{
    public class SelectedDump
    {
        // only the finest dump of the dumpster
        
        public static byte[] data_Dump_93047 = new byte[] /* 13.0.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x8F, 0x0, 0x0, 0x0, 0x0,
            0xA, 0x0, 0xC1, 0xA5, 0xB6, 0x67, 0x3, 0x1, 0xB, 0x8, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0,
            0x2, 0x4, 0x3, 0x0, 0x0, 0xC, 0x56, 0x0, 0x0, 0x0, 0x0, 0x0, 0x64, 0x0, 0x64, 0x0,
            0x0, 0x0, 0x1, 0x0, 0x4, 0x0, 0x0, 0x2, 0x1, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0
        };
        public static Packet Dump_93047 = new Packet(new PacketId(13, 0, 2, "S2C_INSTANCE_GET_ENEMY_SET_LIST_RES"), data_Dump_93047);
        public static byte[] data_Dump_Test = new byte[] /* 13.0.2 - stream 85 */
        {
            0x0, 0x0, //Error
            0x0, 0x0, 0x0, 0x0, //Result?
            0x0, 0x0, 0x0, 0x0, //???
            0x0, 0x1, 0x0, 0x0, //StageId
            0x0, //LayerNo
            0x0, 0xF, 0x0, 0x0, //GroupId
            0x80, //Subgorupid
            0xB6, 0x67, 0x3, 0x1, //Random Seed
            0x0, 0x0, 0x0, 0x0, //Quest Id
            0x0, 0x1, 0x0, 0x0, //Array details (?, length, ?, ?)
            //Enemy 1
            0x0, 0x0, 0x0, 0x1, //Enemy ID
            0x0, 0x0, 0x0, 0x0, //Named Enemy Params
            0x0, 0x0, 0x0, 0x0, //RaidBoss Id
            0x64, 0x0, //Scale
            0x1, 0x0,  //Level
            0x0, //StartThinkTbl (Start Think Table?)
            0x0, //RepopNum
            0x0, //RepopCount
            0x0, //EnemyTargetTypes
            0x4, //MontageFix (?)
            0x0, //SetType
            0x0, //InfectionType
            0x0, //BossBauge
            0x0, //BossVGM
            0x0, //IsManualSet (?)
            0x0, //Is Area Boss
            0x0, //Is blood enemy
            0x0, //??
            0x0, //??
            0x0, //??
            0x0, //??
            
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 //Packet end
        };

        /*
            class CPacket_S2C_GET_ENEMY_SET_LIST_RES: public CPacketDataBase
            {
                private:
                    u16 m_usError;
                    s32 m_nResult;
                    CStageLayoutID m_LayoutId;
                    u8 m_ucSubGroupId;
                    u32 m_unRandomSeed;
                    u32 m_unQuestId;
                    MtTypedArray<CDataLayoutEnemyData> m_EnemyList;
                    MtTypedArray<CDataDropItemSetInfo> m_DropItemSetList;
                    MtTypedArray<CDataNamedEnemyParamClient> m_NamedparamList;
                    bool m_bIsReceived;
        */

        
        public static byte[] data_Dump_Test2 = new byte[] /* 13.0.2 - stream 85 */
        {
            0x0, 0x0, //Error
            0x0, 0x0, 0x0, 0x0, //Result?
            0x0, 0x0, 0x0, 0x0, //Stage Id
            0x0, //LayerNo
            0x1, 0x0, 0x0, 0x0, //GroupId
            0x1, //Subgorupid
            0x3D, 0x0, 0x0, 0x80, //Random Seed
            0xB6, 0x67, 0x3, 0x1, //Quest Id
            0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, //Array details (?, length, ?, ?)
            0x2, 0x4, 0x3, 0x0, 0x0, 0xC, 0x56, 0x0, 0x0, 0x0, 0x0, 0x0, 0x64, 0x0, 0x64, 0x0, //Enemy 1
            0x0, 0x0, 0x1, 0x0, 0x4, 0x0, 0x0, 0x2, 0x1, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, //More ENemy 1 details
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 //Packet end
        };


        public static Packet Dump_Test = new Packet(new PacketId(13, 0, 2, "S2C_INSTANCE_GET_ENEMY_SET_LIST_RES"), data_Dump_Test);

        public static byte[] data_Dump_93283 = new byte[] /* 13.5.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x8F, 0x0, 0x0, 0x0, 0x0,
            0xFA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0xB1, 0xD3, 0x80, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0xA1, 0x0, 0x1, 0x1
        };

        public static Packet Dump_93283 = new Packet(new PacketId(13, 5, 2, "S2C_INSTANCE_GET_ITEM_SET_LIST_RES"), data_Dump_93283);


        public static byte[] data_Dump_1715 = new byte[] /* 35.7.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9F, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x7, 0xD0, 0x40, 0x1
        };

        public static Packet Dump_1715 = new Packet(new PacketId(35, 7, 2, "S2C_CONTEXT_GET_SET_CONTEXT_RES"), data_Dump_1715);


        public static byte[] data_Dump_PawnTest = new byte[] /* 8.3.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xDA, 0x5D, 0x4E, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x7, 0x53, 0x65, 0x72, 0x65, 0x6C, 0x69, 0x61, 0x2, 0x7, 0xA4, 0x10, 0x3, 0x1, 0x1,
            0x5B, 0x12, 0x0, 0x0, 0x2, 0x3, 0x5, 0x8, 0x0, 0x45, 0x0, 0x45, 0x37, 0x37, 0xC, 0x74,
            0x9A, 0x74, 0x7C, 0x76, 0xD4, 0x73, 0x85, 0x73, 0xB7, 0x74, 0x13, 0x71, 0xCF, 0x75, 0xDC, 0x74,
            0x82, 0x77, 0x1C, 0x75, 0x32, 0x74, 0xD1, 0x7C, 0x38, 0x72, 0xD8, 0x75, 0x30, 0x75, 0x30, 0x75,
            0xC3, 0x74, 0xF2, 0x74, 0x4F, 0x75, 0x2, 0x74, 0xE0, 0x74, 0x9A, 0x72, 0x10, 0x72, 0xDC, 0x74,
            0x4, 0x73, 0x20, 0x77, 0xD0, 0x71, 0x48, 0x73, 0x50, 0x77, 0xB5, 0x75, 0xA2, 0x75, 0x30, 0x75,
            0x30, 0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0xBB, 0xB2, 0x9B, 0x35, 0x71, 0xFC, 0x8A, 0x98, 0x96,
            0x96, 0x99, 0xF2, 0xA9, 0xB3, 0x96, 0xC8, 0x77, 0x88, 0x72, 0x95, 0x70, 0x1C, 0x51, 0xA4, 0x75,
            0x30, 0x61, 0x44, 0x0, 0x0, 0x0, 0x2, 0xF8, 0x0, 0x0, 0x1, 0xC2, 0x6, 0x0, 0x0, 0x0,
            0x5, 0x1, 0x0, 0x3A, 0x49, 0xE0, 0x0, 0x3, 0x8A, 0x40, 0x0, 0x0, 0x0, 0x33, 0x0, 0xB4,
            0x0, 0xB4, 0x0, 0x78, 0x0, 0x7B, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x15,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0xB, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x1E, 0x0,
            0x53, 0x0, 0x1E, 0x0, 0x53, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x12, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3,
            0x0, 0x0, 0x1A, 0x71, 0x0, 0x0, 0x5, 0x78, 0x0, 0x0, 0x0, 0x6, 0x0, 0x2D, 0x0, 0x57,
            0x0, 0x1E, 0x0, 0x57, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x7,
            0x6E, 0x9, 0x4B, 0x0, 0x5, 0xF6, 0x90, 0x0, 0x0, 0x0, 0x63, 0x0, 0xD8, 0x0, 0x57, 0x1,
            0x44, 0x0, 0xC6, 0x0, 0x1E, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x5, 0xD7,
            0x6D, 0x38, 0x0, 0x7, 0x86, 0x90, 0x0, 0x0, 0x0, 0x5D, 0x1, 0x32, 0x0, 0x9F, 0x1, 0x32,
            0x0, 0x9F, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x12, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1,
            0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x61, 0xAD, 0x0, 0x1, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x60, 0x7A, 0x0, 0x1,
            0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x21, 0xB9, 0x0, 0x2, 0x0, 0x5,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x22, 0x36, 0x0, 0x2, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
            0x0, 0x2, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x87, 0x0, 0x0, 0x0, 0x4, 0x0,
            0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x1, 0x0, 0x0, 0x0, 0x0,
            0x2, 0x0, 0x0, 0x0, 0x3, 0x3, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x5,
            0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0,
            0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x9, 0x1, 0x0, 0x0, 0x0, 0x2, 0x2, 0x0, 0x0, 0x0, 0x6, 0x3, 0x0, 0x0, 0x0, 0x1,
            0x4, 0x0, 0x0, 0x0, 0x6, 0x5, 0x0, 0x0, 0x0, 0x1, 0x6, 0x0, 0x0, 0x0, 0xA, 0x7,
            0x0, 0x0, 0x0, 0x6, 0x8, 0x0, 0x0, 0x0, 0x6, 0x9, 0x0, 0x0, 0x0, 0x6, 0x1, 0x0,
            0x5, 0xA, 0x5, 0xA, 0x0, 0x0, 0x0, 0x3, 0x1, 0x2, 0x3, 0x0, 0x0, 0x0, 0x4, 0x1,
            0x0, 0x0, 0x0, 0x3, 0xA, 0x2, 0x0, 0x0, 0x0, 0x5, 0xA, 0x3, 0x0, 0x0, 0x0, 0x4,
            0xA, 0x4, 0x0, 0x0, 0x0, 0x6E, 0x1, 0x0, 0x0, 0x0, 0x2, 0x1, 0x0, 0x0, 0x0, 0x83,
            0x6, 0x2, 0x0, 0x0, 0x0, 0x88, 0x6, 0x0, 0x0, 0x0, 0xF, 0x2, 0x9E, 0x0, 0x0, 0x0,
            0x10, 0x0, 0x10, 0x0, 0xF, 0x0, 0x10, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x75, 0x30, 0x0,
            0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x3, 0x0,
            0x0, 0x0, 0x3, 0x3, 0x1, 0x8, 0x2, 0x9, 0x1, 0xD7, 0xE3, 0xDC, 0xCC, 0xA4, 0xEA, 0xEE,
            0xE7, 0x78, 0xFE, 0x45, 0x96, 0x93, 0xD1, 0x90

        };

        public static Packet PawnTest = new Packet(new PacketId(8, 3, 2, "S2C_PAWN_GET_MYPAWN_DATA_RES"), data_Dump_PawnTest);


        public static byte[] data_Dump_Pawn8_37_16 = new byte[] /* 8.37.16 */
        {
            0x0, 0x20, 0x4F, 0xD8, 0x0, 0x7, 0x53, 0x65, 0x72, 0x65, 0x6C, 0x69, 0x61, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x6, 0x63, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1,
            0x0, 0xDA, 0x5D, 0x4E, 0x0, 0x1, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0xA0, 0x8C, 0x90, 0x2F, 0x0, 0x0, 0x0
        };

        public static Packet Pawn8_37_16 = new Packet(new PacketId(8, 37, 16, "S2C_PAWN_8_37_16_NTC"), data_Dump_Pawn8_37_16);


        public static byte[] data_Dump_Pawn35_3_16 = new byte[] /* 35.3.16 */
        {
            0x0, 0xDA, 0x5D, 0x4E, 0x0, 0x0, 0x0, 0x3, 0x0, 0xDA, 0x5D, 0x4E, 0x0, 0x0, 0x0, 0xC8,
            0x0, 0x0, 0x0, 0x22, 0x40, 0x7C, 0x1A, 0x6F, 0x40, 0x0, 0x0, 0x0, 0x46, 0x40, 0x39, 0xA5,
            0x40, 0x86, 0x1F, 0xFB, 0x0, 0x0, 0x0, 0x0, 0xBF, 0xB0, 0xA3, 0x6E, 0x2, 0x0, 0x0, 0x7,
            0x53, 0x65, 0x72, 0x65, 0x6C, 0x69, 0x61, 0x0, 0x0, 0x0, 0x0, 0x0, 0xF, 0x61, 0xAD, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x60, 0x7A, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0xF, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x21, 0xB9,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x22, 0x36, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x1, 0x1, 0x0, 0x20, 0x4F, 0xD8, 0x0,
            0x0, 0x0, 0x0, 0x3, 0x1, 0x2, 0x3, 0x0, 0x0, 0x0, 0x4, 0x1, 0x0, 0x0, 0x0, 0x3,
            0xA, 0x2, 0x0, 0x0, 0x0, 0x5, 0xA, 0x3, 0x0, 0x0, 0x0, 0x4, 0xA, 0x4, 0x0, 0x0,
            0x0, 0x6E, 0x1, 0x0, 0x0, 0x0, 0x2, 0x1, 0x0, 0x0, 0x0, 0x83, 0x6, 0x2, 0x0, 0x0,
            0x0, 0x88, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6,
            0x44, 0x3E, 0x0, 0x0, 0x44, 0x3E, 0x0, 0x0, 0x44, 0x3E, 0x0, 0x0, 0x43, 0xE1, 0x0, 0x0,
            0x43, 0xE1, 0x0, 0x0, 0x47, 0x43, 0x50, 0x0, 0x0, 0x63, 0x0, 0x0, 0x0, 0x0, 0x7, 0x6E,
            0x9, 0x4B, 0x0, 0x0, 0x0, 0xD8, 0x0, 0x0, 0x0, 0x57, 0x0, 0x0, 0x1, 0x44, 0x0, 0x0,
            0x0, 0xC6, 0x0, 0x0, 0x0, 0x1E, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5,
            0xF6, 0x90, 0x0, 0x0, 0x2, 0x9E, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x10, 0x0, 0x0,
            0x0, 0x10, 0x0, 0x0, 0x0, 0xF, 0x0, 0x0, 0x0, 0x10, 0xFF, 0xFF, 0xFF, 0xFF, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x5, 0x1, 0x0, 0x33, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3A, 0x49, 0xE0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x3, 0x8A, 0x40, 0xB, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x6, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x1A, 0x71, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x78, 0x6, 0x0, 0x63,
            0x0, 0x0, 0x0, 0x0, 0x7, 0x6E, 0x9, 0x4B, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0xF6, 0x90,
            0xA, 0x0, 0x5D, 0x0, 0x0, 0x0, 0x0, 0x5, 0xD7, 0x6D, 0x38, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x7, 0x86, 0x90, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3F, 0x80, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0xC2, 0xC8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xC2, 0xC8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9, 0x1, 0x0, 0x0, 0x0, 0x2,
            0x2, 0x0, 0x0, 0x0, 0x6, 0x3, 0x0, 0x0, 0x0, 0x1, 0x4, 0x0, 0x0, 0x0, 0x6, 0x5,
            0x0, 0x0, 0x0, 0x1, 0x6, 0x0, 0x0, 0x0, 0xA, 0x7, 0x0, 0x0, 0x0, 0x6, 0x8, 0x0,
            0x0, 0x0, 0x6, 0x9, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x3, 0x1, 0x8, 0x2,
            0x9, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x2, 0x7, 0xA4, 0x10, 0x3, 0x1, 0x1, 0x5B, 0x12, 0x0, 0x0, 0x2, 0x3, 0x5, 0x8, 0x0,
            0x45, 0x0, 0x45, 0x37, 0x37, 0xC, 0x74, 0x9A, 0x74, 0x7C, 0x76, 0xD4, 0x73, 0x85, 0x73, 0xB7,
            0x74, 0x13, 0x71, 0xCF, 0x75, 0xDC, 0x74, 0x82, 0x77, 0x1C, 0x75, 0x32, 0x74, 0xD1, 0x7C, 0x38,
            0x72, 0xD8, 0x75, 0x30, 0x75, 0x30, 0x75, 0xC3, 0x74, 0xF2, 0x74, 0x4F, 0x75, 0x2, 0x74, 0xE0,
            0x74, 0x9A, 0x72, 0x10, 0x72, 0xDC, 0x74, 0x4, 0x73, 0x20, 0x77, 0xD0, 0x71, 0x48, 0x73, 0x50,
            0x77, 0xB5, 0x75, 0xA2, 0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0xBB, 0xB2,
            0x9B, 0x35, 0x71, 0xFC, 0x8A, 0x98, 0x96, 0x96, 0x99, 0xF2, 0xA9, 0xB3, 0x96, 0xC8, 0x77, 0x88,
            0x72, 0x95, 0x70, 0x1C, 0x51, 0xA4, 0x75, 0x30, 0x61, 0x44, 0x0, 0x2, 0xC5, 0x0, 0x0, 0x3,
            0x2E, 0x0, 0x0, 0x2, 0xC9, 0x0, 0x0, 0x2
        };

        public static Packet Pawn35_3_16 = new Packet(new PacketId(35, 3, 16, "S2C_CONTEXT_35_3_16_NTC"), data_Dump_Pawn35_3_16);


        public static byte[] data_Dump_Pawn_Res = new byte[] /* 8.12.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0
        };

        public static Packet Pawn_Res = new Packet(new PacketId(8, 12, 2, "S2C_PAWN_JOIN_PARTY_MYPAWN_RES"), data_Dump_Pawn_Res);

        public static byte[] data_Dump_AntiDC_Test1 = new byte[] /* 13.20.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x2F, 0x80, 0x0, 0x0, 0x0,
            0x0, 0x80, 0x22, 0xF3, 0x0, 0x0, 0x0, 0x4, 0xC5, 0x36, 0xB9, 0x1, 0xCE, 0x88, 0xD7, 0x11,
            0x7C, 0x5A, 0xBA, 0x16, 0xA3, 0xBF, 0x55
        };

        public static Packet AntiDC_Test1 = new Packet(new PacketId(13, 20, 2, "S2C_INSTANCE_SET_OM_INSTANT_KEY_VALUE_RES"), data_Dump_AntiDC_Test1);

        public static byte[] data_Dump_AntiDC_Test2 = new byte[] /* 13.23.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x74, 0x80, 0x0, 0x0, 0x0,
            0x8, 0x50, 0x17, 0x47, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x80, 0x0, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x61, 0x0, 0x1, 0x1
        };

        public static Packet AntiDC_Test2 = new Packet(new PacketId(13, 23, 2, "S2C_INSTANCE_EXCHANGE_OM_INSTANT_KEY_VALUE_RES"), data_Dump_AntiDC_Test2);

        public static byte[] data_Dump_AntiDC_NoOpe = new byte[] /* 2.38.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x80, 0x0, 0x0, 0x0,
            0x10, 0xC, 0x34, 0xDA, 0x40, 0x1, 0x0
        };

        public static Packet AntiDC_NoOpe = new Packet(new PacketId(2, 38, 2, "S2C_CHARACTER_SET_ONLINE_STATUS_RES"), data_Dump_AntiDC_NoOpe);

        public static byte[] data_Dump_LobbyPlayerContext = new byte[] /* 35.0.16 */
        {
            0x00, 0x08, 0xD4, 0xF3, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xC8,
            0x00, 0x00, 0x00, 0x3D, 0x40, 0x72, 0x00, 0x9A,  0x80, 0x00, 0x00, 0x00, 0x46, 0x36, 0xD0, 0x00,
            0xC0, 0xB3, 0x29, 0x90, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x04,
            0x48, 0x69, 0x64, 0x65, 0x00, 0x05, 0x52, 0x61,  0x6E, 0x63, 0x65, 0x00, 0x00, 0x00, 0x0F, 0x61,
            0xB0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x04, 0x01, 0x00, 0x00, 0x23, 0xED, 0x00,
            0x00, 0x02, 0x00, 0x00, 0x24, 0x2C, 0x00, 0x00,  0x03, 0x00, 0x00, 0x24, 0x1C, 0x00, 0x00, 0x04,
            0x00, 0x00, 0x24, 0x36, 0x00, 0x00, 0x00, 0x00,  0x00, 0x01, 0x01, 0x01, 0x00, 0x09, 0x00, 0x01,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x64, 0x13,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x02, 0x01, 0x00, 0x00, 0x37, 0x6B, 0x00, 0x00,
            0x02, 0x00, 0x00, 0x24, 0x46, 0x00, 0x00, 0x00,  0x00, 0x00, 0x01, 0x01, 0x01, 0x02, 0x7F, 0x00,
            0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x53, 0x78, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x01, 0x00,  0x00, 0x4B, 0xB3, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x46, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x02, 0x01, 0x00, 0x00, 0x34,
            0x49, 0x00, 0x00, 0x02, 0x00, 0x00, 0x41, 0x43,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x53, 0x4A, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x52, 0xAF, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00,  0x00, 0x08, 0xD4, 0xF3, 0x00, 0x00, 0x00, 0x00,
            0x03, 0x01, 0x02, 0x03, 0x00, 0x00, 0x00, 0x06,  0x01, 0x00, 0x00, 0x00, 0x02, 0x0A, 0x02, 0x00,
            0x00, 0x00, 0x04, 0x0A, 0x03, 0x00, 0x00, 0x00,  0x08, 0x09, 0x04, 0x00, 0x00, 0x00, 0x06, 0x0A,
            0x11, 0x00, 0x00, 0x00, 0x03, 0x0A, 0x12, 0x00,  0x00, 0x00, 0x05, 0x0A, 0x00, 0x00, 0x00, 0x0A,
            0x01, 0x00, 0x00, 0x01, 0x96, 0x06, 0x02, 0x00,  0x00, 0x01, 0xAC, 0x06, 0x03, 0x00, 0x00, 0x01,
            0xAD, 0x06, 0x04, 0x00, 0x00, 0x01, 0xAE, 0x06,  0x05, 0x00, 0x00, 0x01, 0xAF, 0x05, 0x06, 0x00,
            0x00, 0x01, 0xB0, 0x06, 0x07, 0x00, 0x00, 0x01,  0xB2, 0x06, 0x08, 0x00, 0x00, 0x01, 0xB3, 0x06,
            0x09, 0x00, 0x00, 0x01, 0xB4, 0x06, 0x0A, 0x00,  0x00, 0x01, 0xB5, 0x06, 0x00, 0x00, 0x00, 0x29,
            0x00, 0x00, 0x00, 0x3F, 0x00, 0x00, 0x00, 0x11,  0x02, 0x00, 0x01, 0x03, 0x00, 0x01, 0x04, 0x00,
            0x01, 0x05, 0x00, 0x01, 0x06, 0x00, 0x28, 0x07,  0x00, 0x1E, 0x08, 0x00, 0x05, 0x09, 0x00, 0x05,
            0x0A, 0x00, 0x02, 0x0B, 0x00, 0x02, 0x0C, 0x00,  0x02, 0x0D, 0x00, 0x02, 0x0E, 0x00, 0x00, 0x0F,
            0x00, 0x00, 0x10, 0x00, 0x00, 0x11, 0x00, 0x00,  0x12, 0x00, 0x00, 0x0A, 0x45, 0xD0, 0x90, 0x00,
            0x44, 0x3E, 0x00, 0x00, 0x45, 0xD0, 0x90, 0x00,  0x45, 0x33, 0xA0, 0x00, 0x43, 0xE1, 0x00, 0x00,
            0x47, 0x43, 0x50, 0x00, 0x00, 0x75, 0x00, 0x00,  0x00, 0x00, 0x0C, 0xB7, 0xD4, 0xD4, 0x00, 0x00,
            0x01, 0x7A, 0x00, 0x00, 0x00, 0xB7, 0x00, 0x00,  0x01, 0x7A, 0x00, 0x00, 0x00, 0xB7, 0x00, 0x00,
            0x00, 0x19, 0x00, 0x00, 0x00, 0x32, 0x00, 0x00,  0x00, 0x32, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x12, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x10, 0x68, 0x00, 0x00,
            0x07, 0xD5, 0x00, 0x00, 0x04, 0x1A, 0x00, 0x00,  0x00, 0x42, 0x00, 0x00, 0x00, 0x34, 0x00, 0x00,
            0x00, 0x45, 0x00, 0x00, 0x00, 0x35, 0x00, 0x00,  0x00, 0x02, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01,  0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x03,
            0x00, 0x00, 0x00, 0x05, 0x00, 0x00, 0x00, 0x06,  0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x00, 0x09,
            0x00, 0x00, 0x00, 0x0A, 0x00, 0x00, 0x00, 0x0B,  0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00, 0x29,
            0x00, 0x00, 0x00, 0x2C, 0x00, 0x00, 0x00, 0x32,  0x00, 0x00, 0x00, 0x34, 0x00, 0x00, 0x00, 0x80,
            0x00, 0x00, 0x00, 0xD5, 0x00, 0x00, 0x00, 0xD7,  0x00, 0x00, 0x00, 0xDA, 0x00, 0x00, 0x00, 0xFD,
            0x00, 0x00, 0x00, 0x45, 0x00, 0x00, 0x00, 0x02,  0x11, 0x10, 0x62, 0x10, 0x40, 0x9B, 0x0A, 0x09,
            0x20, 0x00, 0x00, 0x00, 0x45, 0x85, 0x58, 0x27,  0xC0, 0xB0, 0x0B, 0xA4, 0x00, 0x00, 0x00, 0x00,
            0x3F, 0x4E, 0x7A, 0x4C, 0x3E, 0x3A, 0x4F, 0xCC,  0xBF, 0x0F, 0xFD, 0xBA, 0x40, 0x9B, 0x8A, 0xFA,
            0x80, 0x00, 0x00, 0x00, 0x45, 0x7D, 0x69, 0xFE,  0xC0, 0xB0, 0x22, 0x1E, 0xE0, 0x00, 0x00, 0x00,
            0x40, 0x9B, 0x8A, 0xFA, 0x80, 0x00, 0x00, 0x00,  0x45, 0x7D, 0x69, 0xFE, 0xC0, 0xB0, 0x22, 0x1E,
            0xE0, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00,  0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,  0x01, 0x03, 0x75, 0x30, 0x01, 0x01, 0x00, 0x1B,
            0x00, 0x0C, 0x00, 0x11, 0x08, 0x02, 0x06, 0x11,  0x3F, 0x3F, 0x3F, 0x38, 0x38, 0x2A, 0x73, 0x32,
            0x75, 0xC6, 0x74, 0x88, 0x74, 0x3B, 0x74, 0x2C,  0x75, 0x41, 0x74, 0x2A, 0x75, 0x2D, 0x75, 0x0C,
            0x74, 0xA9, 0x74, 0xF8, 0x75, 0x7B, 0x85, 0x98,  0x73, 0x9E, 0x75, 0xA3, 0x75, 0x30, 0x75, 0x5A,
            0x73, 0x7C, 0x74, 0x86, 0x74, 0x57, 0x74, 0x15,  0x71, 0x48, 0x72, 0x10, 0x73, 0xFC, 0x74, 0x68,
            0x76, 0x68, 0x76, 0x87, 0x73, 0x8A, 0x74, 0xEA,  0x74, 0x62, 0x73, 0xA4, 0x75, 0x30, 0x75, 0x30,
            0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0xBB, 0x1C,  0x9C, 0xE8, 0x75, 0x44, 0x8E, 0xC6, 0x9B, 0xDC,
            0x98, 0xBF, 0x9C, 0x40, 0x99, 0x34, 0x76, 0x2A,  0x68, 0xE2, 0x73, 0x9F, 0x4E, 0x20, 0x79, 0x18,
            0x62, 0xD4, 0xF8, 0xCD, 0x69, 0xD5, 0xE8
        };

        public static Packet Dump_LobbyPlayerContext = new Packet(new PacketId(35, 0, 16, "S2C_CONTEXT_GET_LOBBY_PLAYER_CONTEXT_NTC"), data_Dump_LobbyPlayerContext);

        public static byte[] data_Dump_32_A = new byte[] /* 8.2.2 */
        {
            0x0, 0x0, 0x0, 0x0, 
            0x0, 0x0, 0x0, 0x0, 
            
            // Pawn List
            0x0, 0x0, 0x0, 0x3, // 3 elements
            // Pawn 1:
            0x0, 0xDA, 0x5D, 0x4E,
            0x0, 0x0, 0x0, 0x1, 
            0x0, 0x7,  0x53, 0x65, 0x72, 0x65, 0x6C, 0x69, 0x61, // Name
            0x2, 
            0x0, 
            0x1,

            0x8, 
            0x0, 0x0, 0x0, 0x64, 
            0x0, 0x0, 0x0, 0xE, 

                0x0, 0x0, 0x0, 0xA, 
                    0x1,    0x0, 0x0, 0x0, 0x0, 
                    0x2,    0x0, 0x0, 0x0, 0x1, 
                    0x3,    0x0, 0x0, 0x0, 0x7, 
                    0x4,    0x0, 0x0, 0x0, 0x0, 
                    0x5,    0x0, 0x0, 0x0, 0x5, 
                    0x6,    0x0, 0x0, 0x0, 0x0, 
                    0x7,    0x0, 0x0, 0x0, 0x0,
                    0x8,    0x0, 0x0, 0x0, 0x0, 
                    0x9,    0x0, 0x0, 0x0, 0x0, 
                    0xA,    0x0, 0x0, 0x0, 0x0, 

            0x0, 0x0, 0x0, 0x0, 
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 
            
            0x0, 0x0, 0x0, 0x1, 
            0x0, 0x0, 0x75, 0x30, 
            0x0, 0x0, 0x0, 0x3, 
            
            0x0, 0xDA, 0x66, 0x8D, 0x0, 0x0, 0x0, 0x2, 0x0,
            0x5, 0x41, 0x7A, 0x75, 0x6C, 0x61, 0x2, 0x0, 0x1, 0x6, 0x0, 0x0, 0x0, 0x78, 0x0, 0x0,
            0x0, 0x38, 0x0, 0x0, 0x0, 0xA, 0x1, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x37,
            0x3, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x6,
            0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0,
            0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
            0x5C, 0xE5, 0x6D, 0x7B, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x75, 0x30, 0x0, 0x0, 0x0, 0x3,
            0x0, 0xDA, 0xB2, 0xF3, 0x0, 0x0, 0x0, 0x3, 0x0, 0x6, 0x53, 0x65, 0x65, 0x6C, 0x69, 0x78,
            0x2, 0x0, 0x1, 0x6, 0x0, 0x0, 0x0, 0x78, 0x0, 0x0, 0x0, 0x46, 0x0, 0x0, 0x0, 0xA,
            0x1, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x45, 0x4,
            0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0,
            0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0,
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5D, 0x52, 0xD1, 0x79, 0x0, 0x0,
            0x0, 0x6, 0x0, 0x0, 0x5, 0x8E, 0x0, 0x0, 0x0, 0x0, 0x0, 0xDA, 0xB2, 0xF3, 0x0, 0x0,
            0x0, 0x6, 0x7, 0x0, 0x46, 0xE3, 0x1
        };

        public static Packet Dump_32_A = new Packet(new PacketId(8, 2, 2, "Dump_32_A"), data_Dump_32_A);

        public static byte[] data_Dump_AntiDc9_1_2 = new byte[] /* 9.1.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
            0x28, 0x1, 0x0, 0x1, 0x0, 0x2, 0x0
        };

        public static Packet AntiDc9_1_2 = new Packet(new PacketId(9, 1, 2, "S2C_BINARY_SAVE_SET_CHARACTER_BIN_SAVEDATA_RES"), data_Dump_AntiDc9_1_2);

        public static byte[] data_Dump_AntiDcSortdataBin = new byte[] /* 50.1.2 */
        {
            0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
            0x28, 0x1, 0x0, 0x1, 0x0, 0x2, 0x0
        };

        public static Packet AntiDcSortdataBin = new Packet(new PacketId(50, 1, 2, "S2C_ITEM_SORT_SET_ITEM_SORTDATA_BIN_RES"), data_Dump_AntiDcSortdataBin);

        public static byte[] data_Dump_lantern2_27_16 = new byte[] /* 2.27.16 */
        {
            0x0, 0x0, 0x5, 0xDC, 0x0, 0x0, 0x0
        };

        public static Packet lantern2_27_16 = new Packet(new PacketId(2, 27, 16, "S2C_CHARACTER_2_27_16_NTC"), data_Dump_lantern2_27_16);

        public static byte[] data_Dump_46_A = new byte[] /* 28.2.2 */
        {
            0x0, 0x0, 0x0, 0x0, 
            0x0, 0x0, 0x0, 0x0,  
            
            0x0, 0x0, 0x0, 0x4, 

            0x0, 0x0, 0x0, 0xF,
            0x1, 
            0x0, 0x0, 0x0, 0x0, 
            0xFF, 0xE2, 0x83, 0xEF, 

            0x0, 0x0, 0x0, 0x40, 
            0x1, 
            0x0, 0x0, 0x0, 0x0, 
            0xFF, 0xB, 0x62, 0x6F, 

            0x0, 0x0, 0x0, 0x25, 
            0x1, 
            0x0, 0x0, 0x0, 0x0, 
            0xFF, 0x34, 0x40, 0xEF,

            0x0, 0x0, 0x0, 0x4,
            0x1, 
            0x0, 0x0, 0x0, 0x0,
            0xFF, 0x5A, 0x7C, 0x6F,

            0x39, 0x20, 0xFA, 0x7B, 0xC4, 0x74, 0x53
        };

        public static Packet Dump_46_A = new Packet(new PacketId(28, 2, 2, "Dump_46_A"), data_Dump_46_A);

    }
}
