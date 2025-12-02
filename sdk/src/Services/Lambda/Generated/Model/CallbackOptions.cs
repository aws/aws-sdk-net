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
    /// Configuration options for callback operations in durable executions, including timeout
    /// settings and retry behavior.
    /// </summary>
    public partial class CallbackOptions
    {
        private int? _heartbeatTimeoutSeconds;
        private int? _timeoutSeconds;

        /// <summary>
        /// Gets and sets the property HeartbeatTimeoutSeconds. 
        /// <para>
        /// The heartbeat timeout for the callback operation, in seconds. If not specified or
        /// set to 0, heartbeat timeout is disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int HeartbeatTimeoutSeconds
        {
            get { return this._heartbeatTimeoutSeconds.GetValueOrDefault(); }
            set { this._heartbeatTimeoutSeconds = value; }
        }

        // Check to see if HeartbeatTimeoutSeconds property is set
        internal bool IsSetHeartbeatTimeoutSeconds()
        {
            return this._heartbeatTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The timeout for the callback operation in seconds. If not specified or set to 0, the
        /// callback has no timeout.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TimeoutSeconds
        {
            get { return this._timeoutSeconds.GetValueOrDefault(); }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

    }
}