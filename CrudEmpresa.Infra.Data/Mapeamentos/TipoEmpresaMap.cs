using CrudEmpresa.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace CrudEmpresa.Infra.Data.Mapeamentos
{
    public class TipoEmpresaMap : DommelEntityMap<TipoEmpresa>
    {
        public TipoEmpresaMap()
        {
            ToTable("TB_TIPO_EMPRESA");
            Map(x => x.Id).ToColumn("ID_TIPO_EMPRESA").IsKey();
            Map(x => x.DsTipo).ToColumn("DS_TIPO_EMPRESA");
        }
    }
}
