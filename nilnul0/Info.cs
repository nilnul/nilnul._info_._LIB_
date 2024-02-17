
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	public interface IInfo:_info.INonphysical
		,_info._indefinite.proffer.co_.shortlist.IUncertaintyReduced
	{ }

	/// <summary>
	/// prior to the info, the uncertainty is Lb(n). After the info, the uncertainty is Lb(np), where p is postive portion/proportion/percentage/probability, and n*p is the constricted scope(number of samples).
	/// the amount of info shall be the same as and can be measured by the reduction of uncertainty. So it is: lb(n) - lb(np) = lb(1/p) = -lb(p)
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// observing the event has happened, by :
	///		seeing it self, eg: see the result of a coin toss by oneself's eyes
	///		told by others, eg:
	///			others watched the result of a coint toss, and forward that result as a message to you.
	///			weather report
	///
	/// </remarks>
	/// alias:
	///		surprisal
	///		
	///		
	static public class _InfoX
	{
		/// <summary>
		/// when observing by oneself or told by others one evt has happend, the info one get is:
		/// </summary>
		/// <param name="_prob_assumePositive"></param>
		/// <returns></returns>
		/// alias:
		///		information content,
		///		self-information,
		///		surprisal,
		///		or Shannon information 
		static public double _Info_evtProbAssumePositve(double _prob_assumePositive) {
			return nilnul.num.real_.positive._LbX.Lb(1 / _prob_assumePositive);
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
		/// Lb(60/20)=lb(60) -lb(20)
		/// </returns>
		static public double _Info_0leeway_1leewayShrunk(int profferPrior, int profferPosterior) {
			return nilnul.num.real_.positive._LbX.Lb(
				( (double)profferPrior )
				/
				profferPosterior
			);
		}
	}
}