using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.info._data._type.space
{
	/// <summary>
	/// constraint can change the probability distribution of the instances from uniform distribution to skewed distribution.
	///		with appended tail constrainted, the main body would embody a non-uniform distribution.
	///			eg:
	///				if we only allow the tail like:
	///					"0"
	///					,
	///					"01"
	///				then:
	///					000
	///					001
	///					010
	///					011 disallowed
	///					100
	///					101
	///					110
	///					111 disallowed
	///				 the first two bits is:
	///					00
	///					00
	///					01
	///					10
	///					10
	///					11
	///				we can say that the four combination:
	///					00
	///					01
	///					10
	///					11
	///				all appears
	///				but at different probability.
	/// </summary>
	class Constaint
	{
	}
}
