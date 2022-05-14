
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HoldemCardAnimation.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Card : Grid
	{
		public static readonly BindableProperty NumberProperty = BindableProperty.Create(nameof(Number), typeof(string), typeof(Card), null, BindingMode.TwoWay,  null);

		public string Number
		{
			get => (string)GetValue(NumberProperty);
			set => SetValue(NumberProperty, value);
		}
		public static readonly BindableProperty SuitProperty = BindableProperty.Create(nameof(Suit), typeof(string), typeof(Card), null, BindingMode.TwoWay, propertyChanged: SuitChanged);

		private static void SuitChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var card = bindable as Card;

			if ((string)newValue == "DIAMOND" ||
			   (string)newValue == "HEART")
			{
				card.suit.Text = "◆";
				card.number.TextColor = Color.Red;
				card.suit.TextColor = Color.Red;
			}
			else
			{
				card.number.TextColor = Color.Black;
				card.suit.TextColor = Color.Black;
			}
		}

		public string Suit
		{
			get => (string)GetValue(SuitProperty);
			set => SetValue(SuitProperty, value);
		}
		public Card()
		{
			InitializeComponent();
		}
		private int i = 0;
		public void Drift()
		{
			if(i==0)
			{
				DriftUp();
				i = 1;
			}
			else
			{
				DriftDown();
				i = 0;
			}
		}
		private void DriftUp()
		{
			front.RotateXTo(0, 250, Easing.Linear);
		}
		private void DriftDown()
		{
			front.RotateXTo(90, 250, Easing.Linear);
		}
	}
}