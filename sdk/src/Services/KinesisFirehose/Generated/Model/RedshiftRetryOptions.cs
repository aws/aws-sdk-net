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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Configures retry behavior in case Kinesis Data Firehose is unable to deliver documents
    /// to Amazon Redshift.
    /// </summary>
    public partial class RedshiftRetryOptions
    {
        private int? _durationInSeconds;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The length of time during which Kinesis Data Firehose retries delivery after a failure,
        /// starting from the initial request and including the first attempt. The default value
        /// is 3600 seconds (60 minutes). Kinesis Data Firehose does not retry if the value of
        /// <code>DurationInSeconds</code> is 0 (zero) or if the first delivery attempt takes
        /// longer than the current value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=7200)]
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