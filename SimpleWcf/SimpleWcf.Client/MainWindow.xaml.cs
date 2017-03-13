using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SimpleWcf.Contracts;
using SimpleWcf.Proxies;

namespace SimpleWcf.Client
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			//tbCurrencyFrom.Text = "0";
			BindComboBoxes();
		}

		private void BindComboBoxes()
		{
			using (CurrencyConvertClient client = new CurrencyConvertClient())
			{
				List<CurrencyData> currencies = client.GetCurrenciesList();
				cbCurrencyFrom.ItemsSource = cbCurrencyTo.ItemsSource = currencies;
				cbCurrencyFrom.SelectedIndex = cbCurrencyTo.SelectedIndex = 0;
			}
		}

		private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			decimal value;
			if (decimal.TryParse(tbCurrencyFrom.Text, out value))
			{
				if (cbCurrencyFrom.SelectedItem != null && cbCurrencyTo.SelectedItem != null)
					DoConvert(value);
			}
			else
			{
				MessageBox.Show("Непредвиденная ошибка!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}


		private void OnTextChanged(object sender, TextChangedEventArgs e)
		{
			decimal value;
			if (decimal.TryParse(tbCurrencyFrom.Text, out value))
			{
				if (cbCurrencyFrom != null && cbCurrencyTo != null)
					DoConvert(value);
			}
			else
			{
				MessageBox.Show("непредвиденная ошибка!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void DoConvert(decimal value)
		{
			using (CurrencyConvertClient client = new CurrencyConvertClient())
			{
				string currencyCodeFrom = ((CurrencyData)cbCurrencyFrom.SelectedItem).CurrencyCode;
				string currencyCodeTo = ((CurrencyData)cbCurrencyTo.SelectedItem).CurrencyCode;

				ConverterValueData res = client.ConvertValue(currencyCodeFrom, currencyCodeTo, value);
				tbCurrencyTo.Text = res.ConvertResult.ToString();
				tbCourse.Text = res.ConvertCource.ToString();
			}
		}

		private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !IsTextAllowed(e.Text);
		}

		private static bool IsTextAllowed(string text)
		{
			Regex regex = new Regex("[^0-9.-]+");
			return !regex.IsMatch(text);
		}

		private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
		{
			if (e.DataObject.GetDataPresent(typeof(string)))
			{
				string text = (string)e.DataObject.GetData(typeof(string));
				if (!IsTextAllowed(text))
				{
					e.CancelCommand();
				}
			}
			else
			{
				e.CancelCommand();
			}
		}

		private void btnChangeCurrency_Click(object sender, RoutedEventArgs e)
		{
			int index = cbCurrencyFrom.SelectedIndex;
			cbCurrencyFrom.SelectedIndex = cbCurrencyTo.SelectedIndex;
			cbCurrencyTo.SelectedIndex = index;
		}
	}
}
