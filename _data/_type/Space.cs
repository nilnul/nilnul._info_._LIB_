using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.info._data._type
{
	/// <summary>
	/// say we have 2 bit storage space. Then we can save:
	///		00
	///		01
	///		10
	///		11
	///	The uncertainty we face is:
	///		lb(4)
	///	When we save the value into the space(we instantiated the type), we reduced the uncertainty. The reduced uncertainty is the info given by the data
	/// </summary>
	/// <remarks>
	/// alias:
	///		container
	///		space
	///		type
	///	to encode int, we have 32bit space.
	///		to sample sound, we use 4bytes for example
	///		to sample pixel, we use 4bytes for example.
	/// </remarks>
	class Container
	{
	}
}
