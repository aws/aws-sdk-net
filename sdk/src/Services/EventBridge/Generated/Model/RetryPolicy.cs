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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// A <c>RetryPolicy</c> object that includes information about the retry policy settings.
    /// </summary>
    public partial class RetryPolicy
    {
        private int? _maximumEventAgeInSeconds;
        private int? _maximumRetryAttempts;

        /// <summary>
        /// Gets and sets the property MaximumEventAgeInSeconds. 
        /// <para>
        /// The maximum amount of time, in seconds, to continue to make retry attempts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int? MaximumEventAgeInSeconds
        {
            get { return this._maximumEventAgeInSeconds; }
            set { this._maximumEventAgeInSeconds = value; }
        }

        // Check to see if MaximumEventAgeInSeconds property is set
        internal bool IsSetMaximumEventAgeInSeconds()
        {
            return this._maximumEventAgeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumRetryAttempts. 
        /// <para>
        /// The maximum number of retry attempts to make before the request fails. Retry attempts
        /// continue until either the maximum number of attempts is made or until the duration
        /// of the <c>MaximumEventAgeInSeconds</c> is met.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=185)]
        public int? MaximumRetryAttempts
        {
            get { return this._maximumRetryAttempts; }
            set { this._maximumRetryAttempts = value; }
        }

        // Check to see if MaximumRetryAttempts property is set
        internal bool IsSetMaximumRetryAttempts()
        {
            return this._maximumRetryAttempts.HasValue; 
        }

    }
}