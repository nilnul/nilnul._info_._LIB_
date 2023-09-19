using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._info._indefinite.proffer.measure_
{
	/// <summary>
	/// when you have states, the "maximum" info it can hold. This maximum is called uncertainty.
	/// </summary>
	/// <remarks>
	/// </remarks>
	static public class _BitX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_countOfOptions_positive">positive natural num</param>
		/// <returns></returns>
		static public double Uncertainty(uint _countOfOptions_positive) {
			return Math.Log(_countOfOptions_positive,2);
		}

		//static public double Uncertainty(nilnul.num_.Positive1 countOfOptions) {
		//	return nilnul.num.real_.positive._LbX.Lb(countOfOptions);
		//}

	}
}
