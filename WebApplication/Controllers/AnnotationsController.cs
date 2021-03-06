﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using MySqlDatabase;

namespace WebApplication.Controllers
{
    public class AnnotationsController : ApiController
    {
        private IRepository _repository = new MySqlRepository();

        public IHttpActionResult Get()
        {
            var annotationData = _repository.GetAnnotions();
            return Ok(annotationData);
        }

        public IHttpActionResult Get(int id)
        {
            var data = _repository.FindAnnotationById(id);
            if (data == null) return NotFound();
            return Ok(data);
        }
    }
}
