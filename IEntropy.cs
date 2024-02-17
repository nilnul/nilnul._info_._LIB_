using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.info
{
	/// <summary>
	/// eg:
	///		when  a student's chaperone come to find one from your class, you need to find which one and you need more information. Thence you aks the chaperone:
	///		"what's the gender?"
	///		"what's the name?"
	///		"is the student on the left, the right on the middle column of seats?"
	///	When you ask for the gender, the chaperone would respond:
	///		"male", and you get some information.
	///		or "female", and you get another information. Note the two information is not of the same amount.
	///	So how much information does knowing the gender give to you ? It depends. And on avergae, we can get the weighted average of the two informations. This qunatity is called entropy.
	///	So entropy is how much information on average you need for knowing something.
	///	The something to know, or the knowledge(know-ledge: know- receivableBooked) is called entropy.
	///		
	/// </summary>
	/// <remarks>
	///Shannon entropy, a measure of the unpredictability or information content of a message source
	/// </remarks>
	/// alias:
	///		need
	///		entropy
	///		information entropy;
	///		Shannon entropy, a measure of the unpredictability or information content of a message source
	///
	public interface IEntropy { }

	static public class _EntropyX
	{

		/// <summary>
		/// the expected information an event would provide.
		/// </summary>
		/// <remarks>
		/// the event might happen at probability <paramref name="prob"/>, otherwise it will not happen at all, in a probability of (1- <paramref name="prob"/>);
		/// </remarks>
		/// <param name="prob"></param>
		/// <returns></returns>
		static public double _ExpectedIndefinite_0prob(this double prob) {
			if (prob==0)
			{
				return 0;
			}
			return prob * nilnul._InfoX._Info_evtProbAssumePositve(prob);
		}
		static public double Entropy(
			IEnumerable<double> probs
		) {
			return probs.Sum(
				p=> p._ExpectedIndefinite_0prob()
			);
		}

		/*
		 Σp_i*ln(p_i)，令p_i=p(x)dx，
Σp_i*ln(p_i)
=∫p(x)dx*ln(p(x)dx)
=∫p(x)dx*ln(p(x))+∫p(x)dx*ln(dx)		//here ∫ ... dxdx as a infinitesimal of higher order is discarded.
=∫p(x)dx*ln(p(x))+ln(dx)

抛掉的ln(dx)会导致计算结果的发散。
		 */
	}
}
