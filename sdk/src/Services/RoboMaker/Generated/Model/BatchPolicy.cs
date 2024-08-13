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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about the batch policy.
    /// </summary>
    public partial class BatchPolicy
    {
        private int? _maxConcurrency;
        private long? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The number of active simulation jobs create as part of the batch that can be in an
        /// active state at the same time. 
        /// </para>
        ///  
        /// <para>
        /// Active states include: <c>Pending</c>,<c>Preparing</c>, <c>Running</c>, <c>Restarting</c>,
        /// <c>RunningFailed</c> and <c>Terminating</c>. All other states are terminal states.
        /// 
        /// </para>
        /// </summary>
        public int? MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The amount of time, in seconds, to wait for the batch to complete. 
        /// </para>
        ///  
        /// <para>
        /// If a batch times out, and there are pending requests that were failing due to an internal
        /// failure (like <c>InternalServiceError</c>), they will be moved to the failed list
        /// and the batch status will be <c>Failed</c>. If the pending requests were failing for
        /// any other reason, the failed pending requests will be moved to the failed list and
        /// the batch status will be <c>TimedOut</c>. 
        /// </para>
        /// </summary>
        public long? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}