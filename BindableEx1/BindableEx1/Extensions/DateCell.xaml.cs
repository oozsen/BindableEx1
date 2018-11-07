using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindableEx1.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{
		public DateCell ()
		{
			InitializeComponent ();
		}
	}
}