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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details of the <code>StartTimer</code> decision.
    /// 
    ///  
    /// <para>
    /// <b>Access Control</b>
    /// </para>
    ///  
    /// <para>
    /// You can use IAM policies to control this decision's access to Amazon SWF resources
    /// as follows:
    /// </para>
    ///  <ul> <li>Use a <code>Resource</code> element with the domain name to limit the action
    /// to only specified domains.</li> <li>Use an <code>Action</code> element to allow or
    /// deny permission to call this action.</li> <li>You cannot use an IAM policy to constrain
    /// this action's parameters.</li> </ul> 
    /// <para>
    /// If the caller does not have sufficient permissions to invoke the action, or the parameter
    /// values fall outside the specified constraints, the action fails. The associated event
    /// attribute's <b>cause</b> parameter will be set to OPERATION_NOT_PERMITTED. For details
    /// and example IAM policies, see <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html">Using
    /// IAM to Manage Access to Amazon SWF Workflows</a>.
    /// </para>
    /// </summary>
    public partial class StartTimerDecisionAttributes
    {
        private string _control;
        private string _startToFireTimeout;
        private string _timerId;

        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// <i>Optional.</i> Data attached to the event that can be used by the decider in subsequent
        /// workflow tasks.
        /// </para>
        /// </summary>
        public string Control
        {
            get { return this._control; }
            set { this._control = value; }
        }

        // Check to see if Control property is set
        internal bool IsSetControl()
        {
            return this._control != null;
        }

        /// <summary>
        /// Gets and sets the property StartToFireTimeout. 
        /// <para>
        /// <b>Required.</b> The duration to wait before firing the timer.
        /// </para>
        ///  
        /// <para>
        /// The duration is specified in seconds; an integer greater than or equal to 0.
        /// </para>
        /// </summary>
        public string StartToFireTimeout
        {
            get { return this._startToFireTimeout; }
            set { this._startToFireTimeout = value; }
        }

        // Check to see if StartToFireTimeout property is set
        internal bool IsSetStartToFireTimeout()
        {
            return this._startToFireTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property TimerId. 
        /// <para>
        /// <b>Required.</b> The unique ID of the timer.
        /// </para>
        ///  
        /// <para>
        /// The specified string must not start or end with whitespace. It must not contain a
        /// <code>:</code> (colon), <code>/</code> (slash), <code>|</code> (vertical bar), or
        /// any control characters (\u0000-\u001f | \u007f - \u009f). Also, it must not contain
        /// the literal string quotarnquot.
        /// </para>
        /// </summary>
        public string TimerId
        {
            get { return this._timerId; }
            set { this._timerId = value; }
        }

        // Check to see if TimerId property is set
        internal bool IsSetTimerId()
        {
            return this._timerId != null;
        }

    }
}