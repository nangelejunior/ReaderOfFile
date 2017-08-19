using System;
using System.Data.SqlClient;
using ReaderOfFileDTO;

namespace ReaderOfFileDAL
{
    public class DemandaDAL
    {
        private static readonly String INSERT_DEMANDA_SQL =
            "INSERT INTO tb_atvdade"
            + "(ss"
            + ",st"
            + ",dt_receb"
            + ",dt_term"
            + ",hr_esforco"
            + ",nm_solic"
            + ",tel_solic"
            + ",ramal"
            + ",linguagem"
            + ",nm_modulo"
            + ",sig_sist"
            + ",nm_pgm"
            + ",vers_pgm"
            + ",obs"
            + ",dt_concl"
            + ",nr_duvid"
            + ")"
            + " VALUES"
            + "(@ss"
            + ",@st"
            + ",@dt_receb"
            + ",@dt_term"
            + ",@hr_esforco"
            + ",@nm_solic"
            + ",@tel_solic"
            + ",@ramal"
            + ",@linguagem"
            + ",@nm_modulo"
            + ",@sig_sist"
            + ",@nm_pgm"
            + ",@vers_pgm"
            + ",@obs"
            + ",@dt_concl"
            + ",@nr_duvid"
            + ")";

        private static readonly String UPDATE_DEMANDA_SQL =
            "UPDATE tb_atvdade SET"
            + " dt_receb = @dt_receb"
            + ",dt_term = @dt_term"
            + ",hr_esforco = @hr_esforco"
            + ",nm_solic = @nm_solic"
            + ",tel_solic = @tel_solic"
            + ",ramal = @ramal"
            + ",linguagem = @linguagem"
            + ",nm_modulo = @nm_modulo"
            + ",sig_sist = @sig_sist"
            + ",nm_pgm = @nm_pgm"
            + ",vers_pgm = @vers_pgm"
            + ",obs = @obs"
            + ",dt_concl = @dt_concl"
            + ",nr_duvid = @nr_duvid"
            + " WHERE ss = @ss"
            + " AND st = @st";

        public void insertDemanda(DemandaDTO demandaDTO)
        {
            ConexaoDAL conexaoDAL = new ConexaoDAL();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                conexaoDAL.openConnection();

                sqlCommand.Connection = conexaoDAL.SqlConnection;
                
                sqlCommand.CommandText = INSERT_DEMANDA_SQL;

                sqlCommand.Parameters.AddWithValue("@ss", demandaDTO.Ss);
                sqlCommand.Parameters.AddWithValue("@st", demandaDTO.St);
                sqlCommand.Parameters.AddWithValue("@dt_receb", demandaDTO.DataRecebimento);
                sqlCommand.Parameters.AddWithValue("@dt_term", demandaDTO.DataTermino);
                sqlCommand.Parameters.AddWithValue("@hr_esforco", demandaDTO.HoraEsforco);
                sqlCommand.Parameters.AddWithValue("@nm_solic", demandaDTO.NomeSolicitante);
                sqlCommand.Parameters.AddWithValue("@tel_solic", demandaDTO.TelefoneSolicitante);
                sqlCommand.Parameters.AddWithValue("@ramal", demandaDTO.Ramal);
                sqlCommand.Parameters.AddWithValue("@linguagem", demandaDTO.Linguagem);
                sqlCommand.Parameters.AddWithValue("@nm_modulo", demandaDTO.NomeModulo);
                sqlCommand.Parameters.AddWithValue("@sig_sist", demandaDTO.SiglaSistema);
                sqlCommand.Parameters.AddWithValue("@nm_pgm", demandaDTO.NomePrograma);
                sqlCommand.Parameters.AddWithValue("@vers_pgm", demandaDTO.VersaoPrograma);
                sqlCommand.Parameters.AddWithValue("@obs", demandaDTO.Observacao);
                sqlCommand.Parameters.AddWithValue("@dt_concl", demandaDTO.DataConclusao);
                sqlCommand.Parameters.AddWithValue("@nr_duvid", demandaDTO.NumeroDuvida);

                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                if (sqlException.Number == 2627)
                {
                    throw new Exception(sqlException.Number.ToString());
                }
                else
                {
                    throw new Exception("Erro no INSERT da tabela TB_ATVDADE: " + sqlException.Message);
                }
            }
            finally
            {
                sqlCommand.Dispose();
                conexaoDAL.closeConnection();
            }
        }

        public void updateDemanda(DemandaDTO demandaDTO)
        {
            ConexaoDAL conexaoDAL = new ConexaoDAL();
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                conexaoDAL.openConnection();

                sqlCommand.Connection = conexaoDAL.SqlConnection;
                
                sqlCommand.CommandText = UPDATE_DEMANDA_SQL;

                sqlCommand.Parameters.AddWithValue("@ss", demandaDTO.Ss);
                sqlCommand.Parameters.AddWithValue("@st", demandaDTO.St);
                sqlCommand.Parameters.AddWithValue("@dt_receb", demandaDTO.DataRecebimento);
                sqlCommand.Parameters.AddWithValue("@dt_term", demandaDTO.DataTermino);
                sqlCommand.Parameters.AddWithValue("@hr_esforco", demandaDTO.HoraEsforco);
                sqlCommand.Parameters.AddWithValue("@nm_solic", demandaDTO.NomeSolicitante);
                sqlCommand.Parameters.AddWithValue("@tel_solic", demandaDTO.TelefoneSolicitante);
                sqlCommand.Parameters.AddWithValue("@ramal", demandaDTO.Ramal);
                sqlCommand.Parameters.AddWithValue("@linguagem", demandaDTO.Linguagem);
                sqlCommand.Parameters.AddWithValue("@nm_modulo", demandaDTO.NomeModulo);
                sqlCommand.Parameters.AddWithValue("@sig_sist", demandaDTO.SiglaSistema);
                sqlCommand.Parameters.AddWithValue("@nm_pgm", demandaDTO.NomePrograma);
                sqlCommand.Parameters.AddWithValue("@vers_pgm", demandaDTO.VersaoPrograma);
                sqlCommand.Parameters.AddWithValue("@obs", demandaDTO.Observacao);
                sqlCommand.Parameters.AddWithValue("@dt_concl", demandaDTO.DataConclusao);
                sqlCommand.Parameters.AddWithValue("@nr_duvid", demandaDTO.NumeroDuvida);

                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlException)
            {
                throw new Exception("Erro no UPDATE da tabela TB_ATVDADE: " + sqlException.Message);
            }
            finally
            {
                sqlCommand.Dispose();
                conexaoDAL.closeConnection();
            }
        }
    }

}
