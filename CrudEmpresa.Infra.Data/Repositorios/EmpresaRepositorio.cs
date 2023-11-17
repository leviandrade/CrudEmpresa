using CrudEmpresa.Dominio.Entidades;
using Dapper;
using Dommel;

namespace CrudEmpresa.Infra.Data.Repositorios
{
    public class EmpresaRepositorio : RepositorioBase<Empresa>
    {
        public EmpresaRepositorio()
        {

        }

        public async Task<List<Empresa>> ListarComInclude()
        {
            using (var connection = DbConnect.Connection)
            {

                var sqlQuery = @"SELECT Empresa.ID_EMPRESA Id,Empresa.NM_EMPRESA NmEmpresa,
	   Empresa.ID_TIPO_EMPRESA IdTipoEmpresa,
	   TipoEmpresa.ID_TIPO_EMPRESA Id, TipoEmpresa.DS_TIPO_EMPRESA DsTipo   
                FROM TB_EMPRESA Empresa 
                INNER JOIN TB_TIPO_EMPRESA TipoEmpresa ON Empresa.ID_TIPO_EMPRESA = TipoEmpresa.ID_TIPO_EMPRESA";

                var registros = await connection.QueryAsync<Empresa, TipoEmpresa, Empresa>(sqlQuery, (empresa, tipoEmpresa) =>
                {
                    empresa.TipoEmpresa = tipoEmpresa;
                    return empresa;
                }, splitOn: "IdTipoEmpresa");

                return registros.ToList();
            }
        }
    }
}
