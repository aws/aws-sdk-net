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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
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
namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// An object containing data about a handled exception in the tested state.
    /// </summary>
    public partial class InspectionErrorDetails
    {
        private int? _catchIndex;
        private int? _retryBackoffIntervalSeconds;
        private int? _retryIndex;

        /// <summary>
        /// Gets and sets the property CatchIndex. 
        /// <para>
        /// The array index of the Catch which handled the exception.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? CatchIndex
        {
            get { return this._catchIndex; }
            set { this._catchIndex = value; }
        }

        // Check to see if CatchIndex property is set
        internal bool IsSetCatchIndex()
        {
            return this._catchIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryBackoffIntervalSeconds. 
        /// <para>
        /// The duration in seconds of the backoff for a retry on a failed state invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? RetryBackoffIntervalSeconds
        {
            get { return this._retryBackoffIntervalSeconds; }
            set { this._retryBackoffIntervalSeconds = value; }
        }

        // Check to see if RetryBackoffIntervalSeconds property is set
        internal bool IsSetRetryBackoffIntervalSeconds()
        {
            return this._retryBackoffIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryIndex. 
        /// <para>
        /// The array index of the Retry which handled the exception.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? RetryIndex
        {
            get { return this._retryIndex; }
            set { this._retryIndex = value; }
        }

        // Check to see if RetryIndex property is set
        internal bool IsSetRetryIndex()
        {
            return this._retryIndex.HasValue; 
        }

    }
}