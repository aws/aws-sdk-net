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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment lifecycle event.
    /// </summary>
    public partial class LifecycleEvent
    {
        private Diagnostics _diagnostics;
        private DateTime? _endTime;
        private string _lifecycleEventName;
        private DateTime? _startTime;
        private LifecycleEventStatus _status;

        /// <summary>
        /// Gets and sets the property Diagnostics. 
        /// <para>
        /// Diagnostic information about the deployment lifecycle event.
        /// </para>
        /// </summary>
        public Diagnostics Diagnostics
        {
            get { return this._diagnostics; }
            set { this._diagnostics = value; }
        }

        // Check to see if Diagnostics property is set
        internal bool IsSetDiagnostics()
        {
            return this._diagnostics != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the deployment lifecycle event ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleEventName. 
        /// <para>
        /// The deployment lifecycle event name, such as <c>ApplicationStop</c>, <c>BeforeInstall</c>,
        /// <c>AfterInstall</c>, <c>ApplicationStart</c>, or <c>ValidateService</c>.
        /// </para>
        /// </summary>
        public string LifecycleEventName
        {
            get { return this._lifecycleEventName; }
            set { this._lifecycleEventName = value; }
        }

        // Check to see if LifecycleEventName property is set
        internal bool IsSetLifecycleEventName()
        {
            return this._lifecycleEventName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that indicates when the deployment lifecycle event started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment lifecycle event status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The deployment lifecycle event is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InProgress: The deployment lifecycle event is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded: The deployment lifecycle event ran successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The deployment lifecycle event has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Skipped: The deployment lifecycle event has been skipped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unknown: The deployment lifecycle event is unknown.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LifecycleEventStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}