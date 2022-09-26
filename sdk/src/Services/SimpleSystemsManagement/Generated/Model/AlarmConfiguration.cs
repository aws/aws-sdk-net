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
    /// The details for the CloudWatch alarm you want to apply to an automation or command.
    /// </summary>
    public partial class AlarmConfiguration
    {
        private List<Alarm> _alarms = new List<Alarm>();
        private bool? _ignorePollAlarmFailure;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The name of the CloudWatch alarm specified in the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && this._alarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IgnorePollAlarmFailure. 
        /// <para>
        /// If you specify <code>true</code> for this value, your automation or command continue
        /// to run even if we can't gather information about the state of your CloudWatch alarm.
        /// The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool IgnorePollAlarmFailure
        {
            get { return this._ignorePollAlarmFailure.GetValueOrDefault(); }
            set { this._ignorePollAlarmFailure = value; }
        }

        // Check to see if IgnorePollAlarmFailure property is set
        internal bool IsSetIgnorePollAlarmFailure()
        {
            return this._ignorePollAlarmFailure.HasValue; 
        }

    }
}