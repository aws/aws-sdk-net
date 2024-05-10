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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies an action that Batch will take after the job has remained at the head of
    /// the queue in the specified state for longer than the specified time.
    /// </summary>
    public partial class JobStateTimeLimitAction
    {
        private JobStateTimeLimitActionsAction _action;
        private int? _maxTimeSeconds;
        private string _reason;
        private JobStateTimeLimitActionsState _state;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take when a job is at the head of the job queue in the specified state
        /// for the specified period of time. The only supported value is <c>CANCEL</c>, which
        /// will cancel the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStateTimeLimitActionsAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTimeSeconds. 
        /// <para>
        /// The approximate amount of time, in seconds, that must pass with the job in the specified
        /// state before the action is taken. The minimum value is 600 (10 minutes) and the maximum
        /// value is 86,400 (24 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxTimeSeconds
        {
            get { return this._maxTimeSeconds; }
            set { this._maxTimeSeconds = value; }
        }

        // Check to see if MaxTimeSeconds property is set
        internal bool IsSetMaxTimeSeconds()
        {
            return this._maxTimeSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason to log for the action being taken.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job needed to trigger the action. The only supported value is <c>RUNNABLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStateTimeLimitActionsState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}