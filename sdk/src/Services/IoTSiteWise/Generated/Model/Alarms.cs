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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the configuration information of an alarm created in an IoT SiteWise Monitor
    /// portal. You can use the alarm to monitor an asset property and get notified when the
    /// asset property value is outside a specified range. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/monitor-alarms.html">Monitoring
    /// with alarms</a> in the <i>IoT SiteWise Application Guide</i>.
    /// </summary>
    public partial class Alarms
    {
        private string _alarmRoleArn;
        private string _notificationLambdaArn;

        /// <summary>
        /// Gets and sets the property AlarmRoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IAM role that allows the alarm to perform actions and access Amazon Web Services
        /// resources and services, such as IoT Events.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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

        /// <summary>
        /// Gets and sets the property NotificationLambdaArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the Lambda function that manages alarm notifications. For more information, see
        /// <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/lambda-support.html">Managing
        /// alarm notifications</a> in the <i>IoT Events Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string NotificationLambdaArn
        {
            get { return this._notificationLambdaArn; }
            set { this._notificationLambdaArn = value; }
        }

        // Check to see if NotificationLambdaArn property is set
        internal bool IsSetNotificationLambdaArn()
        {
            return this._notificationLambdaArn != null;
        }

    }
}