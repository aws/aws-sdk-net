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
    /// Container for the parameters to the UpdateAlarmModel operation.
    /// Updates an alarm model. Any alarms that were created based on the previous version
    /// are deleted and then created again as new data arrives.
    /// </summary>
    public partial class UpdateAlarmModelRequest : AmazonIoTEventsRequest
    {
        private AlarmCapabilities _alarmCapabilities;
        private AlarmEventActions _alarmEventActions;
        private string _alarmModelDescription;
        private string _alarmModelName;
        private AlarmNotification _alarmNotification;
        private AlarmRule _alarmRule;
        private string _roleArn;
        private int? _severity;

        /// <summary>
        /// Gets and sets the property AlarmCapabilities. 
        /// <para>
        /// Contains the configuration information of alarm state changes.
        /// </para>
        /// </summary>
        public AlarmCapabilities AlarmCapabilities
        {
            get { return this._alarmCapabilities; }
            set { this._alarmCapabilities = value; }
        }

        // Check to see if AlarmCapabilities property is set
        internal bool IsSetAlarmCapabilities()
        {
            return this._alarmCapabilities != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmEventActions. 
        /// <para>
        /// Contains information about one or more alarm actions.
        /// </para>
        /// </summary>
        public AlarmEventActions AlarmEventActions
        {
            get { return this._alarmEventActions; }
            set { this._alarmEventActions = value; }
        }

        // Check to see if AlarmEventActions property is set
        internal bool IsSetAlarmEventActions()
        {
            return this._alarmEventActions != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmModelDescription. 
        /// <para>
        /// The description of the alarm model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string AlarmModelDescription
        {
            get { return this._alarmModelDescription; }
            set { this._alarmModelDescription = value; }
        }

        // Check to see if AlarmModelDescription property is set
        internal bool IsSetAlarmModelDescription()
        {
            return this._alarmModelDescription != null;
        }

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
        /// Gets and sets the property AlarmNotification. 
        /// <para>
        /// Contains information about one or more notification actions.
        /// </para>
        /// </summary>
        public AlarmNotification AlarmNotification
        {
            get { return this._alarmNotification; }
            set { this._alarmNotification = value; }
        }

        // Check to see if AlarmNotification property is set
        internal bool IsSetAlarmNotification()
        {
            return this._alarmNotification != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmRule. 
        /// <para>
        /// Defines when your alarm is invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlarmRule AlarmRule
        {
            get { return this._alarmRule; }
            set { this._alarmRule = value; }
        }

        // Check to see if AlarmRule property is set
        internal bool IsSetAlarmRule()
        {
            return this._alarmRule != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that allows the alarm to perform actions and access AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A non-negative integer that reflects the severity level of the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity.HasValue; 
        }

    }
}