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
    /// Specify how long Firehose retries sending data to the New Relic HTTP endpoint. After
    /// sending data, Firehose first waits for an acknowledgment from the HTTP endpoint. If
    /// an error occurs or the acknowledgment doesn’t arrive within the acknowledgment timeout
    /// period, Firehose starts the retry duration counter. It keeps retrying until the retry
    /// duration expires. After that, Firehose considers it a data delivery failure and backs
    /// up the data to your Amazon S3 bucket. Every time that Firehose sends data to the HTTP
    /// endpoint (either the initial attempt or a retry), it restarts the acknowledgement
    /// timeout counter and waits for an acknowledgement from the HTTP endpoint. Even if the
    /// retry duration expires, Firehose still waits for the acknowledgment until it receives
    /// it or the acknowledgement timeout period is reached. If the acknowledgment times out,
    /// Firehose determines whether there's time left in the retry counter. If there is time
    /// left, it retries again and repeats the logic until it receives an acknowledgment or
    /// determines that the retry time has expired. If you don't want Firehose to retry sending
    /// data, set this value to 0.
    /// </summary>
    public partial class SnowflakeRetryOptions
    {
        private int? _durationInSeconds;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// the time period where Firehose will retry sending data to the chosen HTTP endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=7200)]
        public int? DurationInSeconds
        {
            get { return this._durationInSeconds; }
            set { this._durationInSeconds = value; }
        }

        // Check to see if DurationInSeconds property is set
        internal bool IsSetDurationInSeconds()
        {
            return this._durationInSeconds.HasValue; 
        }

    }
}