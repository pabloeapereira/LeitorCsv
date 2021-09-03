namespace LeitorCsv
{
    public class ObjetoCsvParser
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"update Credenciadoras set Endereco = '{Endereco}', Complemento = '{Complemento}',Bairro = '{Bairro}', Cep = '{Cep}', Municipio = '{Municipio}', Estado = '{Uf}', Pais = '{Pais}', Telefone = '{Telefone}' where Cnpj = '{Cnpj}';";
        }
    }
}