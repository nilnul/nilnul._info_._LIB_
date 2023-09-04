using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._info.uncertainty
{
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
	internal class IMeasure
	{
	}
}
