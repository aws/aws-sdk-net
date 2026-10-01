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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
        private int? _maxEventAgeInSeconds;
        private int? _maxRetryAttempts;
        private RetryStrategy _retryStrategy;

        /// <summary>
        /// Gets and sets the property MaxEventAgeInSeconds. 
        /// <para>
        /// Maximum age of an event in seconds before it is discarded (60-86400, default: 300).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int? MaxEventAgeInSeconds
        {
            get { return this._maxEventAgeInSeconds; }
            set { this._maxEventAgeInSeconds = value; }
        }

        // Check to see if MaxEventAgeInSeconds property is set
        internal bool IsSetMaxEventAgeInSeconds()
        {
            return this._maxEventAgeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetryAttempts. 
        /// <para>
        /// Maximum number of retry attempts (0-185, default: 5).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=185)]
        public int? MaxRetryAttempts
        {
            get { return this._maxRetryAttempts; }
            set { this._maxRetryAttempts = value; }
        }

        // Check to see if MaxRetryAttempts property is set
        internal bool IsSetMaxRetryAttempts()
        {
            return this._maxRetryAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// Strategy for determining which exceptions are retried. Default: ALL.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

    }
}