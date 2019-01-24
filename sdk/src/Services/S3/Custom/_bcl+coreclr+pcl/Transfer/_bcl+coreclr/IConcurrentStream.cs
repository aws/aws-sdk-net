using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides an interface for Streams to implement when a concurrent access is possible with <see cref="TransferUtility"/>..
    /// 	</para>
    /// </summary>
    public interface IConcurrentStream
    {
    }
}
