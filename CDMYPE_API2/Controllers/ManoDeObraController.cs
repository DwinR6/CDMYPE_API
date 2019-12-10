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
    public class ManoDeObraController : ApiController
    {
        private DB_A50A07_TestAPPEntities1 db = new DB_A50A07_TestAPPEntities1();

        // GET: api/ManoDeObra
        public IQueryable<ManoDeObra> GetManoDeObra()
        {
            return db.ManoDeObra;
        }

        // GET: api/ManoDeObra/5
        [ResponseType(typeof(ManoDeObra))]
        public IHttpActionResult GetManoDeObra(int id)
        {
            ManoDeObra manoDeObra = db.ManoDeObra.Find(id);
            if (manoDeObra == null)
            {
                return NotFound();
            }

            return Ok(manoDeObra);
        }

        // PUT: api/ManoDeObra/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutManoDeObra(int id, ManoDeObra manoDeObra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != manoDeObra.ID_ManoDeObra)
            {
                return BadRequest();
            }

            db.Entry(manoDeObra).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManoDeObraExists(id))
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

        // POST: api/ManoDeObra
        [ResponseType(typeof(ManoDeObra))]
        public IHttpActionResult PostManoDeObra(ManoDeObra manoDeObra)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ManoDeObra.Add(manoDeObra);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ManoDeObraExists(manoDeObra.ID_ManoDeObra))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = manoDeObra.ID_ManoDeObra }, manoDeObra);
        }

        // DELETE: api/ManoDeObra/5
        [ResponseType(typeof(ManoDeObra))]
        public IHttpActionResult DeleteManoDeObra(int id)
        {
            ManoDeObra manoDeObra = db.ManoDeObra.Find(id);
            if (manoDeObra == null)
            {
                return NotFound();
            }

            db.ManoDeObra.Remove(manoDeObra);
            db.SaveChanges();

            return Ok(manoDeObra);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ManoDeObraExists(int id)
        {
            return db.ManoDeObra.Count(e => e.ID_ManoDeObra == id) > 0;
        }
    }
}