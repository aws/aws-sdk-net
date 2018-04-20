/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Configures retry behavior in case Kinesis Data Firehose is unable to deliver documents
    /// to Splunk, or if it doesn't receive an acknowledgment from Splunk.
    /// </summary>
    public partial class SplunkRetryOptions
    {
        private int? _durationInSeconds;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The total amount of time that Kinesis Data Firehose spends on retries. This duration
        /// starts after the initial attempt to send data to Splunk fails. It doesn't include
        /// the periods during which Kinesis Data Firehose waits for acknowledgment from Splunk
        /// after each attempt.
        /// </para>
        /// </summary>
        public int DurationInSeconds
        {
            get { return this._durationInSeconds.GetValueOrDefault(); }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

    }
}