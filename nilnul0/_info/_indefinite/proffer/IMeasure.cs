using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._info._indefinite.proffer
{
	/// <summary>
	/// define a finite (not infinite) nontrivia (not all zeros) measure.
	/// </summary>
	/// <remarks>
	/// <see cref="proffer.op_.binary_.FineTune"/> of m, n.
	///	u(mn) = u(m)+u(n), where u is the measure. m,n each is a proffer, mn is a proffer computed by 	 <see cref="proffer.op_.binary_.FineTune"/> of m, n.
	///	let m=1,n=1. we then have u(1)=u(1)+u(1), so u(1)=u(1)-u(1)=0;
	///	u is increasing as m goes large.
	///
	/// So u must be lg.
	///
	/// we need the measure is nonneg. so the base of the lg is gt 1.
	/// 
	/// </remarks>
	internal class IMeasure
	{
	}

	static public class _MeasureX
	{
		static public double _Measure_0leeway(int options) {
			return Math.Log(options, 2);
		}
	}
}
