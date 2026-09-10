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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Details about a CloudWatch alarm state change observed during a test run.
    /// </summary>
    public partial class AlarmStateChangeDetail
    {
        private AlarmState _previousState;
        private string _reason;
        private AlarmState _state;

        /// <summary>
        /// Gets and sets the property PreviousState. 
        /// <para>
        /// The state the alarm transitioned from. Absent on the initial event, which records
        /// the alarm's state when collection began.
        /// </para>
        /// </summary>
        public AlarmState PreviousState
        {
            get { return this._previousState; }
            set { this._previousState = value; }
        }

        // Check to see if PreviousState property is set
        internal bool IsSetPreviousState()
        {
            return this._previousState != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A human-readable explanation of the state change, as reported by CloudWatch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1023)]
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
        /// The state the alarm transitioned to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlarmState State
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