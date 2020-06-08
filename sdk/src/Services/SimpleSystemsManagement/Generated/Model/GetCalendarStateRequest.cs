/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetCalendarState operation.
    /// Gets the state of the AWS Systems Manager Change Calendar at an optional, specified
    /// time. If you specify a time, <code>GetCalendarState</code> returns the state of the
    /// calendar at a specific time, and returns the next time that the Change Calendar state
    /// will transition. If you do not specify a time, <code>GetCalendarState</code> assumes
    /// the current time. Change Calendar entries have two possible states: <code>OPEN</code>
    /// or <code>CLOSED</code>. For more information about Systems Manager Change Calendar,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">AWS
    /// Systems Manager Change Calendar</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </summary>
    public partial class GetCalendarStateRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _atTime;
        private List<string> _calendarNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AtTime. 
        /// <para>
        /// (Optional) The specific time for which you want to get calendar state information,
        /// in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. If you do
        /// not add <code>AtTime</code>, the current time is assumed.
        /// </para>
        /// </summary>
        public string AtTime
        {
            get { return this._atTime; }
            set { this._atTime = value; }
        }

        // Check to see if AtTime property is set
        internal bool IsSetAtTime()
        {
            return this._atTime != null;
        }

        /// <summary>
        /// Gets and sets the property CalendarNames. 
        /// <para>
        /// The names or Amazon Resource Names (ARNs) of the Systems Manager documents that represent
        /// the calendar entries for which you want to get the state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CalendarNames
        {
            get { return this._calendarNames; }
            set { this._calendarNames = value; }
        }

        // Check to see if CalendarNames property is set
        internal bool IsSetCalendarNames()
        {
            return this._calendarNames != null && this._calendarNames.Count > 0; 
        }

    }
}