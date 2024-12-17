using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult TestimonialList()
        {
            var value=context.Testimonials.ToList();
            return View(value);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var values = context.Testimonials.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
