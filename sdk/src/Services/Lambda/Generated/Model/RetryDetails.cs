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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Information about retry attempts for an operation.
    /// </summary>
    public partial class RetryDetails
    {
        private int? _currentAttempt;
        private int? _nextAttemptDelaySeconds;

        /// <summary>
        /// Gets and sets the property CurrentAttempt. 
        /// <para>
        /// The current attempt number for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentAttempt
        {
            get { return this._currentAttempt; }
            set { this._currentAttempt = value; }
        }

        // Check to see if CurrentAttempt property is set
        internal bool IsSetCurrentAttempt()
        {
            return this._currentAttempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextAttemptDelaySeconds. 
        /// <para>
        /// The delay before the next retry attempt, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NextAttemptDelaySeconds
        {
            get { return this._nextAttemptDelaySeconds; }
            set { this._nextAttemptDelaySeconds = value; }
        }

        // Check to see if NextAttemptDelaySeconds property is set
        internal bool IsSetNextAttemptDelaySeconds()
        {
            return this._nextAttemptDelaySeconds.HasValue; 
        }

    }
}