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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the GetCalendarState operation.
    /// </summary>
    public partial class GetCalendarStateResponse : AmazonWebServiceResponse
    {
        private string _atTime;
        private string _nextTransitionTime;
        private CalendarState _state;

        /// <summary>
        /// Gets and sets the property AtTime. 
        /// <para>
        /// The time, as an <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</a> string,
        /// that you specified in your command. If you did not specify a time, <code>GetCalendarState</code>
        /// uses the current time.
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
        /// Gets and sets the property NextTransitionTime. 
        /// <para>
        /// The time, as an <a href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</a> string,
        /// that the calendar state will change. If the current calendar state is <code>OPEN</code>,
        /// <code>NextTransitionTime</code> indicates when the calendar state changes to <code>CLOSED</code>,
        /// and vice-versa.
        /// </para>
        /// </summary>
        public string NextTransitionTime
        {
            get { return this._nextTransitionTime; }
            set { this._nextTransitionTime = value; }
        }

        // Check to see if NextTransitionTime property is set
        internal bool IsSetNextTransitionTime()
        {
            return this._nextTransitionTime != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the calendar. An <code>OPEN</code> calendar indicates that actions are
        /// allowed to proceed, and a <code>CLOSED</code> calendar indicates that actions are
        /// not allowed to proceed.
        /// </para>
        /// </summary>
        public CalendarState State
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