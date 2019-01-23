using OdataTest.BUsinesslogic;
using OdataTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.OData;

namespace OdataTest.Controllers
{
    namespace ODataMovies.Controllers
    {
        public class MoviesController : ODataController
        {
            [EnableQuery]
            public IList<Movie> Get()
            {
                return m_service.Movies;
            }

            private readonly DataService m_service = new BUsinesslogic.DataService();
        }
    }
}