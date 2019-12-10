using CDMYPE_DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CDMYPE_API.Controllers
{
    public class EmpresasController : ApiController
    {
        public IEnumerable<Empresa> Get()
        {
            using (DB_A50A07_TestAPPEntities Entities = new DB_A50A07_TestAPPEntities())
            {
                return Entities.Empresas.ToList();
            }

        }

        public Empresa PostAgregarEmpresa(Empresa EParametro)
        {
            using (DB_A50A07_TestAPPEntities Entities = new DB_A50A07_TestAPPEntities())
            {
                return Entities.Empresas.Add(EParametro);
            }

        }

        
    }
}
