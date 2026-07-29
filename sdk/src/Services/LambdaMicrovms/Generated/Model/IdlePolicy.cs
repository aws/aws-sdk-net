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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Configuration that controls MicroVM auto-suspend and auto-resume behavior. Idle time
    /// is measured by inbound traffic through the MicroVM proxy endpoint — if no requests
    /// arrive within the configured duration, the MicroVM is suspended.
    /// </summary>
    public partial class IdlePolicy
    {
        private bool? _autoResumeEnabled;
        private int? _maxIdleDurationSeconds;
        private int? _suspendedDurationSeconds;

        /// <summary>
        /// Gets and sets the property AutoResumeEnabled. 
        /// <para>
        /// Indicates whether the MicroVM automatically resumes when it receives a request while
        /// suspended.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AutoResumeEnabled
        {
            get { return this._autoResumeEnabled; }
            set { this._autoResumeEnabled = value; }
        }

        // Check to see if AutoResumeEnabled property is set
        internal bool IsSetAutoResumeEnabled()
        {
            return this._autoResumeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxIdleDurationSeconds. 
        /// <para>
        /// The maximum time in seconds that a MicroVM can remain idle before it is automatically
        /// suspended.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60)]
        public int? MaxIdleDurationSeconds
        {
            get { return this._maxIdleDurationSeconds; }
            set { this._maxIdleDurationSeconds = value; }
        }

        // Check to see if MaxIdleDurationSeconds property is set
        internal bool IsSetMaxIdleDurationSeconds()
        {
            return this._maxIdleDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuspendedDurationSeconds. 
        /// <para>
        /// The maximum time in seconds that a MicroVM can remain suspended before it is automatically
        /// terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? SuspendedDurationSeconds
        {
            get { return this._suspendedDurationSeconds; }
            set { this._suspendedDurationSeconds = value; }
        }

        // Check to see if SuspendedDurationSeconds property is set
        internal bool IsSetSuspendedDurationSeconds()
        {
            return this._suspendedDurationSeconds.HasValue; 
        }

    }
}