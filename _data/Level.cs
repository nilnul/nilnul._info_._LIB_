using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.info._data
{
	/// <summary>
	/// data's def at different levels
	/// </summary>
	enum Level
	{
		/// <summary>
		/// physical property (which can be scaled at finite discrete [for example binary] measurable/observable mark ) for info
		/// so the signal light at the traffic crossroad is data, but the light at the ceiling is not as the ceiling light is for illuminating, not for info
		/// </summary>
		/// <remarks>
		/// the marks can be unary. but the entropy there is nil. and the info squeezed out is nil. So it's trivia/useless.
		/// </remarks>
		Physical
			,
		/// <summary>
		/// we abstract from different physical properties such as optical, magnetical, electrical into signals.
		/// signals are often not discrete. for example, sound is not, photo is not. These signals are refered as "analog".
		/// </summary>
		Signal
			,
		/// <summary>
		/// we convert all signals into digital signals. This means we discretize the analog signal by sampling  finite times at a period.
		/// We hence convert signals into finite numbers. And it can then be fed into binary/digital computer
		/// </summary>
		Digital
			,
		/// <summary>
		/// For signals to be stored, we need to care for the physical clumsiness and take measures for efficiency. To read/write the whole amount of signal for a disk is very time consuming. So:
		///		1) we need to partition the whole into managable units, such as sector which can be 512bytes.
		///		2) we need to reserve the integral relation between the partitions to avoid the partition destroys the original wholeness. In this regard, we need to :
		///			2.1) when remove a data, a hole is left. fragmentation entails
		///			2.2) when stores a data, multiple non-contiguous holes are occupied. We need to mark them as a whole by linked list.
		///	the above work is disk management, and is done by OS.
		///	Os established Fs, which we can gross over the clumsiness of disk management and treat data as file management.
		///	At this level, data = file
		/// </summary>
		/// <remarks>
		/// including blob, which can be communicated online without residing as a file.
		/// </remarks>
		File
			,
		/// <summary>
		/// Fs cannot guarantee data transaction (a sequence of operation is taken as a whole)
		/// Also we need to:
		///		1) finetune the auth management into different parts of a file
		///		2) query data fast. From the original sequencial searching, which is O(n), we can do the following:
		///			2.1) by binary search to promote the speed to O(lb(n))
		///			2.2) by hash table to promote the speed to O(1)
		/// </summary>
		/// <remarks>
		/// Db is still file. but more than file. It's indirectly file, via DBMS.
		/// </remarks>
		Db

	}
	/**
	  we are on the way from Physical to Db:
		in each knowledge, we first study the physical properties, then we model the mechanism, using math.. Then convert the signals by sampling/discretizing into digits, using computing. Then we treat it as blob/file. Then we delve into the file, analysing it as data cells.
	 */
}
