using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aprendices.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalleAprendiz : ContentPage
	{
		public DetalleAprendiz (AprendizPage aprendizSeleccionado)
		{
			InitializeComponent ();
            this.Bindingcontext = aprendizSeleccionado;
		}
	}
}