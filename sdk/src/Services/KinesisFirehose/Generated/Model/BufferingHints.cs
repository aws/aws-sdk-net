/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes hints for the buffering to perform before delivering data to the destination.
    /// These options are treated as hints, and therefore Firehose might choose to use different
    /// values when it is optimal. The <c>SizeInMBs</c> and <c>IntervalInSeconds</c> parameters
    /// are optional. However, if specify a value for one of them, you must also provide a
    /// value for the other.
    /// </summary>
    public partial class BufferingHints
    {
        private int? _intervalInSeconds;
        private int? _sizeInMBs;

        /// <summary>
        /// Gets and sets the property IntervalInSeconds. 
        /// <para>
        /// Buffer incoming data for the specified period of time, in seconds, before delivering
        /// it to the destination. The default value is 300. This parameter is optional but if
        /// you specify a value for it, you must also specify a value for <c>SizeInMBs</c>, and
        /// vice versa.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=900)]
        public int? IntervalInSeconds
        {
            get { return this._intervalInSeconds; }
            set { this._intervalInSeconds = value; }
        }

        // Check to see if IntervalInSeconds property is set
        internal bool IsSetIntervalInSeconds()
        {
            return this._intervalInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInMBs. 
        /// <para>
        /// Buffer incoming data to the specified size, in MiBs, before delivering it to the destination.
        /// The default value is 5. This parameter is optional but if you specify a value for
        /// it, you must also specify a value for <c>IntervalInSeconds</c>, and vice versa.
        /// </para>
        ///  
        /// <para>
        /// We recommend setting this parameter to a value greater than the amount of data you
        /// typically ingest into the Firehose stream in 10 seconds. For example, if you typically
        /// ingest data at 1 MiB/sec, the value should be 10 MiB or higher.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public int? SizeInMBs
        {
            get { return this._sizeInMBs; }
            set { this._sizeInMBs = value; }
        }

        // Check to see if SizeInMBs property is set
        internal bool IsSetSizeInMBs()
        {
            return this._sizeInMBs.HasValue; 
        }

    }
}