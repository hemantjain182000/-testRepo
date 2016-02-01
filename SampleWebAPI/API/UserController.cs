using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using DataAccess;

namespace SampleWebAPI.API
{
    public class UserController : ApiController
    {
        private EntityContext db = new EntityContext();

        // GET api/user
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        public string Get(int id)
        {
            UserDetail userdetail = db.UserDetails.Find(id);
            return userdetail.LoginName;
        }

        public bool PostRegisterUser([FromBody]UserDetail UserDetail)
        {
            db.UserDetails.Add(UserDetail);
            db.SaveChanges();
            return true;
        }



        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
        }
    }
}
