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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
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
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Amazon CloudWatch alarms to monitor during the deployment process.
    /// </summary>
    public partial class Monitor
    {
        private string _alarmArn;
        private string _alarmRoleArn;

        /// <summary>
        /// Gets and sets the property AlarmArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon CloudWatch alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AlarmArn
        {
            get { return this._alarmArn; }
            set { this._alarmArn = value; }
        }

        // Check to see if AlarmArn property is set
        internal bool IsSetAlarmArn()
        {
            return this._alarmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmRoleArn. 
        /// <para>
        /// ARN of an Identity and Access Management (IAM) role for AppConfig to monitor <c>AlarmArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AlarmRoleArn
        {
            get { return this._alarmRoleArn; }
            set { this._alarmRoleArn = value; }
        }

        // Check to see if AlarmRoleArn property is set
        internal bool IsSetAlarmRoleArn()
        {
            return this._alarmRoleArn != null;
        }

    }
}