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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Retry policy for a subscriber.
    /// </summary>
    public partial class RetryPolicy
    {
        /// <summary>
        /// Gets and sets the property MaxEventAgeInSeconds. Maximum age of an event in seconds
        /// before it is discarded (60-86400, default: 300).
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? MaxEventAgeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxEventAgeInSeconds property is set.
        /// </summary>
        internal bool IsSetMaxEventAgeInSeconds() => this.MaxEventAgeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetryAttempts. Maximum number of retry attempts (0-185,
        /// default: 5).
        /// </summary>
        [AWSProperty(Min = 0, Max = 185)]
        public int? MaxRetryAttempts { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetryAttempts property is set.
        /// </summary>
        internal bool IsSetMaxRetryAttempts() => this.MaxRetryAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property RetryStrategy. Strategy for determining which exceptions
        /// are retried. Default: ALL.
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;
    }
}
