using System.Text;
using TinyCsvParser;
using TinyCsvParser.Mapping;

namespace LeitorCsv
{
    public static class CsvParser
    {
        public static StringBuilder GetRecordsToStringBuilder(Stream stream)
        {
            var sBuilder = new StringBuilder();

            foreach (var csvResult in GetRecordsFromStream(stream))
                if (csvResult.IsValid)
                    sBuilder.AppendLine(csvResult.Result.ToString());

            return sBuilder;
        }
        private static IList<CsvMappingResult<ObjetoCsvParser>> GetRecordsFromStream(Stream stream)
        {
            var csvParser = new CsvParser<ObjetoCsvParser>(new CsvParserOptions(false, ';'),
                new ObjetoCsvParserMapping());
            var records = csvParser.ReadFromStream(stream, Encoding.UTF8);
            return records.ToList();
        }

        private class ObjetoCsvParserMapping : CsvMapping<ObjetoCsvParser>
        {
            public ObjetoCsvParserMapping()
            {
                MapProperty(0, x => x.Cnpj);
                MapProperty(1, x => x.Nome);
                MapProperty(2, x => x.Endereco);
                MapProperty(3, x => x.Complemento);
                MapProperty(4, x => x.Bairro);
                MapProperty(5, x => x.Cep);
                MapProperty(6, x => x.Municipio);
                MapProperty(7, x => x.Uf);
                MapProperty(8, x => x.Pais);
                MapProperty(9, x => x.Telefone);
            }
        }
    }
}   