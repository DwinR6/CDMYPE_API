using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CDMYPE_API2.Models;

namespace CDMYPE_API2.Controllers
{
    public class GastosFijosVariablesController : ApiController
    {
        private DB_A50A07_TestAPPEntities1 db = new DB_A50A07_TestAPPEntities1();

        // GET: api/GastosFijosVariables
        public IQueryable<GastosFijosVariables> GetGastosFijosVariables()
        {
            return db.GastosFijosVariables;
        }

        // GET: api/GastosFijosVariables/5
        [ResponseType(typeof(GastosFijosVariables))]
        public IHttpActionResult GetGastosFijosVariables(int id)
        {
            GastosFijosVariables gastosFijosVariables = db.GastosFijosVariables.Find(id);
            if (gastosFijosVariables == null)
            {
                return NotFound();
            }

            return Ok(gastosFijosVariables);
        }

        // PUT: api/GastosFijosVariables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGastosFijosVariables(int id, GastosFijosVariables gastosFijosVariables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gastosFijosVariables.ID_Gasto)
            {
                return BadRequest();
            }

            db.Entry(gastosFijosVariables).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GastosFijosVariablesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GastosFijosVariables
        [ResponseType(typeof(GastosFijosVariables))]
        public IHttpActionResult PostGastosFijosVariables(GastosFijosVariables gastosFijosVariables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GastosFijosVariables.Add(gastosFijosVariables);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GastosFijosVariablesExists(gastosFijosVariables.ID_Gasto))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = gastosFijosVariables.ID_Gasto }, gastosFijosVariables);
        }

        // DELETE: api/GastosFijosVariables/5
        [ResponseType(typeof(GastosFijosVariables))]
        public IHttpActionResult DeleteGastosFijosVariables(int id)
        {
            GastosFijosVariables gastosFijosVariables = db.GastosFijosVariables.Find(id);
            if (gastosFijosVariables == null)
            {
                return NotFound();
            }

            db.GastosFijosVariables.Remove(gastosFijosVariables);
            db.SaveChanges();

            return Ok(gastosFijosVariables);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GastosFijosVariablesExists(int id)
        {
            return db.GastosFijosVariables.Count(e => e.ID_Gasto == id) > 0;
        }
    }
}