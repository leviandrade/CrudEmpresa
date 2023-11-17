using CrudEmpresa.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace CrudEmpresa.Infra.Data.Mapeamentos
{
    public class EmpresaMap : DommelEntityMap<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("TB_EMPRESA");
            Map(x => x.Id).ToColumn("ID_EMPRESA").IsKey();
            Map(x => x.NmEmpresa).ToColumn("NM_EMPRESA");
            Map(x => x.IdTipoEmpresa).ToColumn("ID_TIPO_EMPRESA");
        }
    }
}
