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
    /// to the Serverless offering for Amazon OpenSearch Service.
    /// </summary>
    public partial class AmazonOpenSearchServerlessRetryOptions
    {
        private int? _durationInSeconds;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// After an initial failure to deliver to the Serverless offering for Amazon OpenSearch
        /// Service, the total amount of time during which Kinesis Data Firehose retries delivery
        /// (including the first attempt). After this time has elapsed, the failed documents are
        /// written to Amazon S3. Default value is 300 seconds (5 minutes). A value of 0 (zero)
        /// results in no retries.
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