using System;

namespace ReaderOfFileBLL
{
    public class BLLFactory
    {
        private static readonly ReadTextFileBLL readTextFileBLL = new ReadTextFileBLL();

        private static readonly DemandaBLL demandaBLL = new DemandaBLL();

        public static ReadTextFileBLL ReadTextFileBLL
        {
            get { return BLLFactory.readTextFileBLL; }
        }

        public static DemandaBLL DemandaBLL
        {
            get { return BLLFactory.demandaBLL; }
        } 
    }
}
