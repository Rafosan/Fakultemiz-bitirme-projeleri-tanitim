﻿using EntityLayer.Concrete;
using X.PagedList;

namespace Fakultemiz_bitirme_projeleri_tanitim.Models.Home
{
    public class HomeViewModel
    {
        public IPagedList<Project> Projeler { get; set; }
        public List<Category> Kategoriler { get; set; }
    }
}