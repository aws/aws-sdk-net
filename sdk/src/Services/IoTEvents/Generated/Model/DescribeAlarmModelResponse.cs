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
    /// This is the response object from the DescribeAlarmModel operation.
    /// </summary>
    public partial class DescribeAlarmModelResponse : AmazonWebServiceResponse
    {
        private AlarmCapabilities _alarmCapabilities;
        private AlarmEventActions _alarmEventActions;
        private string _alarmModelArn;
        private string _alarmModelDescription;
        private string _alarmModelName;
        private string _alarmModelVersion;
        private AlarmNotification _alarmNotification;
        private AlarmRule _alarmRule;
        private DateTime? _creationTime;
        private string _key;
        private DateTime? _lastUpdateTime;
        private string _roleArn;
        private int? _severity;
        private AlarmModelVersionStatus _status;
        private string _statusMessage;

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
        /// Gets and sets the property AlarmModelArn. 
        /// <para>
        /// The ARN of the alarm model. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string AlarmModelArn
        {
            get { return this._alarmModelArn; }
            set { this._alarmModelArn = value; }
        }

        // Check to see if AlarmModelArn property is set
        internal bool IsSetAlarmModelArn()
        {
            return this._alarmModelArn != null;
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
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the alarm model was created, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// An input attribute used as a key to create an alarm. AWS IoT Events routes <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_Input.html">inputs</a>
        /// associated with this key to the alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time the alarm model was last updated, in the Unix epoch format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that allows the alarm to perform actions and access AWS resources.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the alarm model. The status can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The alarm model is active and it's ready to evaluate data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATING</c> - AWS IoT Events is activating your alarm model. Activating an
        /// alarm model can take up to a few minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACTIVE</c> - The alarm model is inactive, so it isn't ready to evaluate data.
        /// Check your alarm model information and update the alarm model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - You couldn't create or update the alarm model. Check your alarm model
        /// information and try again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AlarmModelVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  Contains information about the status of the alarm model. 
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}