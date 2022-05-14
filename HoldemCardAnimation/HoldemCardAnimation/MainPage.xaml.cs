using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HoldemCardAnimation
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
		{
			//card1.RotateYTo(10, 250, Easing.CubicIn);
		}

		private void SwipeGestureRecognizer_Swiped_1(object sender, SwipedEventArgs e)
		{

		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			//card1.RotateXTo(20, 250, Easing.CubicIn);
			//card1.RotateYTo(20, 250, Easing.CubicIn);
			
		}

		private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
		{
			Card1.Drift();
		}

		private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
		{
			Card2.Drift();
		}
	}
}
