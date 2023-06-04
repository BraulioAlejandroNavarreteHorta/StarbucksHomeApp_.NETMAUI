using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TDMPW_412_2P_EX_NHBA
{
	internal class Cafes
	{
		public String image;
		public String title;
		public String data;
        public double price;

        public Cafes(String image, String title, String data, double price)
		{
			this.image = image;
			this.title = title;
			this.data = data;
			this.price = price;
		}
	}
}

