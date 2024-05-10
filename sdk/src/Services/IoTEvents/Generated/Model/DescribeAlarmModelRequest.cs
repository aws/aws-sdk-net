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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAlarmModel operation.
    /// Retrieves information about an alarm model. If you don't specify a value for the <c>alarmModelVersion</c>
    /// parameter, the latest version is returned.
    /// </summary>
    public partial class DescribeAlarmModelRequest : AmazonIoTEventsRequest
    {
        private string _alarmModelName;
        private string _alarmModelVersion;

        /// <summary>
        /// Gets and sets the property AlarmModelName. 
        /// <para>
        /// The name of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AlarmModelName
        {
            get { return this._alarmModelName; }
            set { this._alarmModelName = value; }
        }

        // Check to see if AlarmModelName property is set
        internal bool IsSetAlarmModelName()
        {
            return this._alarmModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmModelVersion. 
        /// <para>
        /// The version of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AlarmModelVersion
        {
            get { return this._alarmModelVersion; }
            set { this._alarmModelVersion = value; }
        }

        // Check to see if AlarmModelVersion property is set
        internal bool IsSetAlarmModelVersion()
        {
            return this._alarmModelVersion != null;
        }

    }
}