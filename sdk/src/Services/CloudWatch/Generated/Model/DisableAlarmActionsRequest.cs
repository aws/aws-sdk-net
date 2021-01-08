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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAlarmActions operation.
    /// Disables the actions for the specified alarms. When an alarm's actions are disabled,
    /// the alarm actions do not execute when the alarm state changes.
    /// </summary>
    public partial class DisableAlarmActionsRequest : AmazonCloudWatchRequest
    {
        private List<string> _alarmNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AlarmNames. 
        /// <para>
        /// The names of the alarms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public List<string> AlarmNames
        {
            get { return this._alarmNames; }
            set { this._alarmNames = value; }
        }

        // Check to see if AlarmNames property is set
        internal bool IsSetAlarmNames()
        {
            return this._alarmNames != null && this._alarmNames.Count > 0; 
        }

    }
}