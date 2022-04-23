using App2.Models;
using App2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App2.ViewModels
{
    public class CategViewModel : BaseViewModel
    {
        private Kategoriler _SelectedCategory;
        public Kategoriler SelectedCategory
        {
            set { _SelectedCategory = value; OnPropertyChanged(); }
            get { return _SelectedCategory; }


        }

        private int _TotalFoodItem;
        public int TotalFoodItem
        {
            set { _TotalFoodItem = value; OnPropertyChanged(); }
            get { return _TotalFoodItem; }


        }

        public ObservableCollection<Product> ProductsByCtaegory { get; set; }

        public CategViewModel(Kategoriler kategori)
        {
            SelectedCategory = kategori;
            ProductsByCtaegory = new ObservableCollection<Product>();
            GetProductItems(kategori.CategoryId);
        }

        private async void GetProductItems(int categoryId)
        {
            var data = await new GetProductsService().GetProductsByCategoryAsync(categoryId);
            ProductsByCtaegory.Clear();
            foreach (var item in data)
            {
                ProductsByCtaegory.Add(item);
            }
            TotalFoodItem = ProductsByCtaegory.Count;
        }
    }
}
