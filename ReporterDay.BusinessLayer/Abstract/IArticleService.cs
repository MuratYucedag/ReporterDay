﻿using ReporterDay.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReporterDay.BusinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TGetArticlesByCategoryId1();
        public List<Article> TGetArticlesWithAppUser();
        public List<Article> TGetArticlesWithCategories();
        public List<Article> TGetArticlesWithCategoriesAndAppUsers();
    }
}
