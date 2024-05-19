namespace FM.ContadorSalario.Domain.Entidades
{
    public class EmpresaFuncionario
    {
        public Guid IdFuncionario { get; set; }
        public Guid IdEmpresa { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool EhAtualEmpresa { get; set; }

    }
}
