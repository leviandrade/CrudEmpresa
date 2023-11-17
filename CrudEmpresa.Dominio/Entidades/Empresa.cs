using System.ComponentModel.DataAnnotations.Schema;

namespace CrudEmpresa.Dominio.Entidades
{
    public class Empresa : EntidadeBase
    {
        public string NmEmpresa { get; set; }
    }
}
