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
}
