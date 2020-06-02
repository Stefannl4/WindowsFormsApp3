using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Examples
{
    public class DatabaseVoorbeeld
    {
        public void addCoach()
        {
            using (var context = new MyContext())
            {
                var std = new Coach()
                {
                    Naam = "Steef"
                };
                context.Coach.Add(std);

                context.SaveChanges();
            }
        }
        public void save(Blog blog)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Blog.Add(blog);

                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
        public void delete(Blog blog)
        {
            using (var context = new MyContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Blog.Remove(blog);

                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
        public IList getAllBlogs()
        {
            using (var context = new MyContext())
            {
                return context.Blog
                    .OrderBy(b => b.BlogId)
                    .ToList();
            }
        }
        public IList getCodes(string partialtext)
        {
            using (var context = new MyContext())
            {
                return context.Blog
                    .OrderBy(b => b.BlogId)
                    .ToList();
            }
        }
        public Blog getBlogCode(long id)
        {
            using (var context = new MyContext())
            {
                return context.Blog
                    .OrderBy(b => b.BlogId)
                    .Where(b => b.BlogId == (id))
                    .First();
            }
        }
        public IList getAllPaging(int offset, int showrecords)
        {
            using (var context = new MyContext())
            {
                return context.Blog
                    .OrderBy(b => b.BlogId)
                    .Skip(offset).Take(showrecords)
                    .ToList();
            }
        }
        public int getMaxAllPaging()
        {
            using (var context = new MyContext())
            {
                return context.Blog
                    .OrderBy(b => b.BlogId)
                    .Count();
            }
        }

        /**
         * Serie records maken, gebruik ik om paging te testen. 
         * Paging: gewoon bijvoorbeeld 10 records ophalen uit een tabel ipv alles te lezen.
         * Is sneller en efficienter
         * 
         */
        public void createRecords(int numberOfRecords)
        {
            for (int i = 1; i < numberOfRecords; i++)
            {
                string tekst = "";
                using (var context = new MyContext())
                {
                    Blog blog = new Blog();
                    if (i < 10)
                    {
                        tekst = "000" + i;
                    }
                    else if (i < 100)
                    {
                        tekst = "00" + i;
                    }
                    else if (i < 1000)
                    {
                        tekst = "0" + i;
                    }

                    context.Add(blog);
                    context.SaveChanges();
                }
            }
        }
    }
}
}
