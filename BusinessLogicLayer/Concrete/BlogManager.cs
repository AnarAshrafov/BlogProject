using BusinessLogicLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        EFBlogRepository efBlogRepository;

        public BlogManager()
        {
            efBlogRepository = new EFBlogRepository();
        }
        public void BlogAdd(Blog blog)
        {
            efBlogRepository.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            efBlogRepository.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            efBlogRepository.Update(blog);
        }

        public Blog GetById(int id)
        {
            return efBlogRepository.GetById(id);
        }

        public List<Blog> GetList()
        {
            return efBlogRepository.GetAllList();
        }
    }
}
