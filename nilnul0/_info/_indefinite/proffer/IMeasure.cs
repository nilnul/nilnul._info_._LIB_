using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._info._indefinite.proffer
{
	/// define a finite (not infinite) nontrivia (not all zeros) measure.
	/// <summary>
	/// given n states,
	/// the measure has to be nonneg.
	///		U(n) being nonneg
	///	has to be sigma additative:
	///		U(n*m) =U(n) + U(m), as choosing from n*m can be divided into two steps: choose group out of n, then choose member out m.
	///	we further need U to be monotonically increasing: U(n+epsilon) gt U(n), where epsilon is positive.
	///
	/// As a result, only lg(n) can be used, where the basis of the log must be gt1.
	/// we generally choose 2 as the log basis.
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
    /// alias:
    ///		不确定度
    ///			, like 长度 for which we can use metric, Chinese traditional, or British
    ///			, not only quanlitative, but also quantitative;
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
