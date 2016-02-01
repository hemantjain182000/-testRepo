using DataAccess;
using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SampleWebAPI.Controllers
{
    public class PartController : ApiController
    {
        private EntityContext db = new EntityContext();
        // GET api/part
        public IEnumerable<PartModel> Get()
        {
            return db.Parts.AsEnumerable();
        }

        // GET api/part/5
        public PartModel Get(int id)
        {
            PartModel partmodel = db.Parts.Find(id);


            return partmodel;
        }

        // POST api/part
        public PartModel PostAddPart([FromBody]PartModel PartDetail)
        {
            db.Parts.Add(PartDetail);
            db.SaveChanges();
            return PartDetail;
        }


        // PUT api/part/5
        public PartModel Put(int id, [FromBody]PartModel UpdatedPartDetail)
        {
            PartModel part = new PartModel();
            part = db.Parts.Find(id);
            part.PartDescription = UpdatedPartDetail.PartDescription;
            part.Location = UpdatedPartDetail.Location;
            part.UOM = UpdatedPartDetail.UOM;
            db.SaveChanges();
            return part;
           
        }

        // DELETE api/part/5
        public bool Delete(int id)
        {
             PartModel part = new PartModel();
             part = db.Parts.Find(id);
             if (part != null)
             {
                 db.Parts.Remove(part);
                 db.SaveChanges();
             }
             return true;

        }
    }
}
