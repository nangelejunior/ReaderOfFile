using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReaderOfFileDTO;
using ReaderOfFileDAL;

namespace ReaderOfFileBLL
{
    public class DemandaBLL
    {
        DemandaDAL demandaDAL = DALFactory.DemandaDAL;

        public void alterarDemanda(DemandaDTO demandaDTO)
        {
            try
            {
                demandaDAL.updateDemanda(demandaDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }

        public void inserirDemanda(DemandaDTO demandaDTO)
        {
            try
            {
                demandaDAL.insertDemanda(demandaDTO);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void salvarDemanda(string path, string atualizar)
        {
            try
            {
                ReadTextFileBLL rtfBLL = BLLFactory.ReadTextFileBLL;

                DemandaDTO dmdDTO = new DemandaDTO();

                StringBuilder mensagemErro = new StringBuilder();

                string[] registros = null;

                rtfBLL.abrirArquivo(path);

                StringBuilder regs = rtfBLL.lerArquivo();

                registros = regs.ToString().Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string registro in registros)
                {
                    string[] arrStr = registro.Split(';');

                    dmdDTO.Ss = Int32.Parse(arrStr[0]);
                    dmdDTO.St = Int32.Parse(arrStr[1]);
                    dmdDTO.DataRecebimento = arrStr[2];
                    dmdDTO.DataTermino = arrStr[3];
                    dmdDTO.HoraEsforco = Int32.Parse(arrStr[4]);
                    dmdDTO.NomeSolicitante = arrStr[5];
                    dmdDTO.TelefoneSolicitante = arrStr[6];
                    dmdDTO.Ramal = arrStr[7];
                    dmdDTO.Linguagem = arrStr[8];
                    dmdDTO.NomeModulo = arrStr[9];
                    dmdDTO.SiglaSistema = arrStr[10];
                    dmdDTO.NomePrograma = arrStr[11];
                    dmdDTO.VersaoPrograma = Int32.Parse(arrStr[12]);
                    dmdDTO.Observacao = arrStr[13];
                    dmdDTO.DataConclusao = arrStr[14];
                    dmdDTO.NumeroDuvida = Int32.Parse(arrStr[15]);

                    try
                    {
                        this.inserirDemanda(dmdDTO);
                    }
                    catch (Exception exInsert)
                    {
                        if (exInsert.Message.Equals("2627"))
                        {
                            switch (atualizar)
                            {
                                case "sim":
                                    try
                                    {
                                        this.alterarDemanda(dmdDTO);
                                    }
                                    catch (Exception exUpdate)
                                    {
                                        mensagemErro.AppendLine(exUpdate.Message);
                                    }
                                    break;
                                case "não":
                                    mensagemErro.AppendLine("A demanda SS: " + dmdDTO.Ss + " ST: " + dmdDTO.St +
                                         " existe em sua base de dados, porém não foi atualizada!");
                                    break;
                            }
                        }
                        else
                        {
                            mensagemErro.AppendLine(exInsert.Message);
                        }
                    }

                }

                rtfBLL.fecharArquivo();

                if (mensagemErro.Length > 0)
                {
                    throw new Exception(mensagemErro.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
