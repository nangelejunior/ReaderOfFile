using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReaderOfFileDTO
{
    public class DemandaDTO
    {
        private int ss;

        public int Ss
        {
            get { return ss; }
            set { ss = value; }
        }

        private int st;

        public int St
        {
            get { return st; }
            set { st = value; }
        }

        private String dataRecebimento;

        public String DataRecebimento
        {
            get { return dataRecebimento; }
            set { dataRecebimento = value; }
        }

        private String dataTermino;

        public String DataTermino
        {
            get { return dataTermino; }
            set { dataTermino = value; }
        }

        private int horaEsforco;

        public int HoraEsforco
        {
            get { return horaEsforco; }
            set { horaEsforco = value; }
        }

        private String complexidade;

        public String Complexidade
        {
            get { return complexidade; }
            set { complexidade = value; }
        }

        private String nomeSolicitante;

        public String NomeSolicitante
        {
            get { return nomeSolicitante; }
            set { nomeSolicitante = value; }
        }

        private String telefoneSolicitante;

        public String TelefoneSolicitante
        {
            get { return telefoneSolicitante; }
            set { telefoneSolicitante = value; }
        }

        private String ramal;

        public String Ramal
        {
            get { return ramal; }
            set { ramal = value; }
        }

        private String linguagem;

        public String Linguagem
        {
            get { return linguagem; }
            set { linguagem = value; }
        }

        private String nomeModulo;

        public String NomeModulo
        {
            get { return nomeModulo; }
            set { nomeModulo = value; }
        }

        private String siglaSistema;

        public String SiglaSistema
        {
            get { return siglaSistema; }
            set { siglaSistema = value; }
        }

        private String nomePrograma;

        public String NomePrograma
        {
            get { return nomePrograma; }
            set { nomePrograma = value; }
        }

        private int versaoPrograma;

        public int VersaoPrograma
        {
            get { return versaoPrograma; }
            set { versaoPrograma = value; }
        }

        private String observacao;

        public String Observacao
        {
            get { return observacao; }
            set { observacao = value; }
        }

        private String dataConclusao;

        public String DataConclusao
        {
            get { return dataConclusao; }
            set { dataConclusao = value; }
        }

        private int numeroDuvida;

        public int NumeroDuvida
        {
            get { return numeroDuvida; }
            set { numeroDuvida = value; }
        }
    }
}
