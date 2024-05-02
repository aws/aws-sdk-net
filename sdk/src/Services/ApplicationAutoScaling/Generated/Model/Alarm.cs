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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
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
namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a CloudWatch alarm associated with a scaling policy.
    /// </summary>
    public partial class Alarm
    {
        private string _alarmARN;
        private string _alarmName;

        /// <summary>
        /// Gets and sets the property AlarmARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlarmARN
        {
            get { return this._alarmARN; }
            set { this._alarmARN = value; }
        }

        // Check to see if AlarmARN property is set
        internal bool IsSetAlarmARN()
        {
            return this._alarmARN != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

    }
}