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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetCalendarState operation.
    /// Gets the state of a Amazon Web Services Systems Manager change calendar at the current
    /// time or a specified time. If you specify a time, <c>GetCalendarState</c> returns the
    /// state of the calendar at that specific time, and returns the next time that the change
    /// calendar state will transition. If you don't specify a time, <c>GetCalendarState</c>
    /// uses the current time. Change Calendar entries have two possible states: <c>OPEN</c>
    /// or <c>CLOSED</c>.
    /// 
    ///  
    /// <para>
    /// If you specify more than one calendar in a request, the command returns the status
    /// of <c>OPEN</c> only if all calendars in the request are open. If one or more calendars
    /// in the request are closed, the status returned is <c>CLOSED</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information about Change Calendar, a tool in Amazon Web Services Systems
    /// Manager, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/systems-manager-change-calendar.html">Amazon
    /// Web Services Systems Manager Change Calendar</a> in the <i>Amazon Web Services Systems
    /// Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetCalendarStateRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _atTime;
        private List<string> _calendarNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AtTime. 
        /// <para>
        /// (Optional) The specific time for which you want to get calendar state information,
        /// in <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</a> format. If you don't
        /// specify a value or <c>AtTime</c>, the current time is used.
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
        /// The names of Amazon Resource Names (ARNs) of the Systems Manager documents (SSM documents)
        /// that represent the calendar entries for which you want to get the state.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._calendarNames != null && (this._calendarNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}