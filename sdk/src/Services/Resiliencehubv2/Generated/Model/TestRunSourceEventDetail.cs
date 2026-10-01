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
    /// The payload of a test run source event. Exactly one member is set.
    /// </summary>
    public partial class TestRunSourceEventDetail
    {
        private AlarmStateChangeDetail _alarmStateChange;
        private TestRunSourceEventError _error;

        /// <summary>
        /// Gets and sets the property AlarmStateChange. 
        /// <para>
        /// A CloudWatch alarm state change.
        /// </para>
        /// </summary>
        public AlarmStateChangeDetail AlarmStateChange
        {
            get { return this._alarmStateChange; }
            set { this._alarmStateChange = value; }
        }

        // Check to see if AlarmStateChange property is set
        internal bool IsSetAlarmStateChange()
        {
            return this._alarmStateChange != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that prevented event collection from the source.
        /// </para>
        /// </summary>
        public TestRunSourceEventError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

    }
}