﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Controls.GalleryPages.CollectionViewGalleries.ScrollModeGalleries
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScrollModeTestGallery : ContentPage
	{
		readonly DemoFilteredItemSource _demoFilteredItemSource = new DemoFilteredItemSource(200);

		public ScrollModeTestGallery()
		{
			InitializeComponent();

			CollectionView.ItemTemplate = ExampleTemplates.PhotoTemplate();
			CollectionView.ItemsSource = _demoFilteredItemSource.Items;
		}

		private void ScrollToMiddle_Clicked(object sender, EventArgs e)
		{
			
		}

		private void AddItemAbove_Clicked(object sender, EventArgs e)
		{

		}

		private void AddItemBelow_Clicked(object sender, EventArgs e)
		{

		}

		private void AddItemToEnd_Clicked(object sender, EventArgs e)
		{

		}
	}
}