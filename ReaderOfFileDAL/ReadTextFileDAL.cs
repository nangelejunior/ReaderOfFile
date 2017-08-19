using System;
using System.IO;

namespace ReaderOfFileDAL
{
    public class ReadTextFileDAL
    {
        private StreamReader objReader;

        public StreamReader ObjReader
        {
            get { return objReader; }
            set { objReader = value; }
        }

        public void openFile(String path) 
        {
            try
            {
                ObjReader = new StreamReader(path);
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("Erro na abertura do arquivo! " + ex.Message);
            }
        }

        public string readFile() 
        {
            try
            {
                return ObjReader.ReadLine();
            }
            catch (FileLoadException ex)
            {
                throw new Exception("Erro na leitura do arquivo! " + ex.Message);
            }
        }

        public void closeFile()
        {
            try
            {
                ObjReader.Close();
            }
            catch (FileLoadException ex)
            {
                throw new Exception("Erro no fechamento do arquivo! " + ex.Message);
            }
        }
    }
}
