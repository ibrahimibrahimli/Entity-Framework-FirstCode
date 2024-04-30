using Meyawo.DataAccess.Abstract;
using Meyawo.DataAccess.SqlDbContex;
using Meyawo.Entities.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meyawo.DataAccess.Concret
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private MeyawoManagmentDbContex _dbContex = new();
        public void Add(Testimonial entity)
        {
            _dbContex.Testimonials.Add(entity);
            _dbContex.SaveChanges();
        }

        public void Delete(Testimonial entity)
        {
            _dbContex.Testimonials.Update(entity);
            _dbContex.SaveChanges();
        }

        public List<Testimonial> GetAll()
        {
            List<Testimonial> testimonial = _dbContex.Testimonials.ToList();
            return testimonial;
        }

        public Testimonial GetById(int id)
        {
            Testimonial testimonial = _dbContex.Testimonials.Find(id);
            return testimonial;
        }

        public void Update(Testimonial entity)
        {
            _dbContex.Testimonials.Update(entity);
            _dbContex.SaveChanges();
        }
    }
}
