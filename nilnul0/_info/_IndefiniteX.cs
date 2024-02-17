using System;

namespace nilnul._info
{
	static public class _IndefiniteX
	{
		static public double _Indefinite(double x) {
			return Math.Log(x, 2);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="profferPrior">
		///eg:
		///		60
		/// </param>
		/// <param name="profferPosterior">
		/// eg:20
		/// </param>
		/// <returns>
		/// Lb(60/20)=lb(20)-lb(60)
		/// </returns>
		static public double _Indefinite_0leeway_1leewayShrunk(int profferPrior, int profferPosterior)
		{
			return _Indefinite(
				((double)profferPosterior)
				/
				profferPrior
			);
		}
	}
}
