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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// The core SLO time window exclusion object that includes Window, StartTime, RecurrenceRule,
    /// and Reason.
    /// </summary>
    public partial class ExclusionWindow
    {
        private string _reason;
        private RecurrenceRule _recurrenceRule;
        private DateTime? _startTime;
        private Window _window;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A description explaining why this time period should be excluded from SLO calculations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property RecurrenceRule. 
        /// <para>
        /// The recurrence rule for the SLO time window exclusion. Supports both cron and rate
        /// expressions.
        /// </para>
        /// </summary>
        public RecurrenceRule RecurrenceRule
        {
            get { return this._recurrenceRule; }
            set { this._recurrenceRule = value; }
        }

        // Check to see if RecurrenceRule property is set
        internal bool IsSetRecurrenceRule()
        {
            return this._recurrenceRule != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the SLO time window exclusion. Defaults to current time if not specified.
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
        /// Gets and sets the property Window. 
        /// <para>
        /// The SLO time window exclusion .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Window Window
        {
            get { return this._window; }
            set { this._window = value; }
        }

        // Check to see if Window property is set
        internal bool IsSetWindow()
        {
            return this._window != null;
        }

    }
}