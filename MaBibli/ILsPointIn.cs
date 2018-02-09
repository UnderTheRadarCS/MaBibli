using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraphicsComponents
{
	interface IlsPointIn
	{
		bool IsPointIn(MyPoint point);
	}

	public interface IPointy
	{
		int Points();
	}
}
