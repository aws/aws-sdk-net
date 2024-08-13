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
    /// Describes the retry behavior in case Firehose is unable to deliver data to the specified
    /// HTTP endpoint destination, or if it doesn't receive a valid acknowledgment of receipt
    /// from the specified HTTP endpoint destination.
    /// </summary>
    public partial class HttpEndpointRetryOptions
    {
        private int? _durationInSeconds;

        /// <summary>
        /// Gets and sets the property DurationInSeconds. 
        /// <para>
        /// The total amount of time that Firehose spends on retries. This duration starts after
        /// the initial attempt to send data to the custom destination via HTTPS endpoint fails.
        /// It doesn't include the periods during which Firehose waits for acknowledgment from
        /// the specified destination after each attempt. 
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