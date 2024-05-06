using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager:ITestimonialService
    {
        ITestimonialDal _testimanialDal;

        public TestimonialManager(ITestimonialDal testiMonialDal)
        {
            _testimanialDal = testiMonialDal;
        }

        public void Add(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetAll()
        {
            return _testimanialDal.GetAll();
        }

        public Testimonial GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
