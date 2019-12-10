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
    public class MaterialesController : ApiController
    {
        private DB_A50A07_TestAPPEntities1 db = new DB_A50A07_TestAPPEntities1();

        // GET: api/Materiales
        public IQueryable<Materiales> GetMateriales()
        {
            return db.Materiales;
        }

        // GET: api/Materiales/5
        [ResponseType(typeof(Materiales))]
        public IHttpActionResult GetMateriales(int id)
        {
            Materiales materiales = db.Materiales.Find(id);
            if (materiales == null)
            {
                return NotFound();
            }

            return Ok(materiales);
        }

        // PUT: api/Materiales/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMateriales(int id, Materiales materiales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != materiales.ID_Material)
            {
                return BadRequest();
            }

            db.Entry(materiales).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialesExists(id))
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

        // POST: api/Materiales
        [ResponseType(typeof(Materiales))]
        public IHttpActionResult PostMateriales(Materiales materiales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Materiales.Add(materiales);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = materiales.ID_Material }, materiales);
        }

        // DELETE: api/Materiales/5
        [ResponseType(typeof(Materiales))]
        public IHttpActionResult DeleteMateriales(int id)
        {
            Materiales materiales = db.Materiales.Find(id);
            if (materiales == null)
            {
                return NotFound();
            }

            db.Materiales.Remove(materiales);
            db.SaveChanges();

            return Ok(materiales);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MaterialesExists(int id)
        {
            return db.Materiales.Count(e => e.ID_Material == id) > 0;
        }
    }
}