using System;

namespace ReaderOfFileDAL
{
    public class DALFactory
    {
        private static readonly ReadTextFileDAL readTextFileDAL = new ReadTextFileDAL();

        private static readonly DemandaDAL demandaDAL = new DemandaDAL();

        public static ReadTextFileDAL ReadTextFileDAL
        {
            get { return DALFactory.readTextFileDAL; }
        }

        public static DemandaDAL DemandaDAL
        {
            get { return DALFactory.demandaDAL; }
        } 
    }
}
