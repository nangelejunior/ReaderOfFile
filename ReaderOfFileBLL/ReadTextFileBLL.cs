using System;
using ReaderOfFileDAL;
using System.Text;

namespace ReaderOfFileBLL
{
    public class ReadTextFileBLL
    {
        private ReadTextFileDAL rtfDAL = DALFactory.ReadTextFileDAL;

        public void abrirArquivo(string path)
        {
            try
            {
                rtfDAL.openFile(path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public StringBuilder lerArquivo()
        {
            try
            {
                StringBuilder registros = new StringBuilder();
                StringBuilder mensagemErro = new StringBuilder();

                string registro = null;

                do
                {
                    try
                    {
                        registro = rtfDAL.readFile();

                        registros.AppendLine(registro);
                    }
                    catch (Exception ex)
                    {
                        mensagemErro.AppendLine(ex.Message);
                    }

                } while (registro != null);

                if (registros.Length == 0)
                {
                    throw new Exception("Arquivo vazio!");
                }

                if (mensagemErro.Length > 0)
                {
                    throw new Exception(mensagemErro.ToString());
                }

                return registros;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void fecharArquivo()
        {
            try
            {
                rtfDAL.closeFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
