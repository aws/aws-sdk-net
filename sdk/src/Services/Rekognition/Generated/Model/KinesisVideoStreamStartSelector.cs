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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Specifies the starting point in a Kinesis stream to start processing. You can use
    /// the producer timestamp or the fragment number. One of either producer timestamp or
    /// fragment number is required. If you use the producer timestamp, you must put the time
    /// in milliseconds. For more information about fragment numbers, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_reader_Fragment.html">Fragment</a>.
    /// </summary>
    public partial class KinesisVideoStreamStartSelector
    {
        private string _fragmentNumber;
        private long? _producerTimestamp;

        /// <summary>
        /// Gets and sets the property FragmentNumber. 
        /// <para>
        ///  The unique identifier of the fragment. This value monotonically increases based on
        /// the ingestion order. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FragmentNumber
        {
            get { return this._fragmentNumber; }
            set { this._fragmentNumber = value; }
        }

        // Check to see if FragmentNumber property is set
        internal bool IsSetFragmentNumber()
        {
            return this._fragmentNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ProducerTimestamp. 
        /// <para>
        ///  The timestamp from the producer corresponding to the fragment, in milliseconds, expressed
        /// in unix time format. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ProducerTimestamp
        {
            get { return this._producerTimestamp; }
            set { this._producerTimestamp = value; }
        }

        // Check to see if ProducerTimestamp property is set
        internal bool IsSetProducerTimestamp()
        {
            return this._producerTimestamp.HasValue; 
        }

    }
}