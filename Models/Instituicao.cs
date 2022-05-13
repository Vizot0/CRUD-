using System;

namespace Cap01.Models
{
    public class Instituicao
    {
        public long? InstituicaoID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        internal object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        internal void Add(Instituicao instituicao)
        {
            throw new NotImplementedException();
        }
    }
}
