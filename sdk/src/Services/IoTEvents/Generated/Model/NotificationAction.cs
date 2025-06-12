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
    /// Contains the notification settings of an alarm model. The settings apply to all alarms
    /// that were created based on this alarm model.
    /// </summary>
    public partial class NotificationAction
    {
        private NotificationTargetActions _action;
        private List<EmailConfiguration> _emailConfigurations = AWSConfigs.InitializeCollections ? new List<EmailConfiguration>() : null;
        private List<SMSConfiguration> _smsConfigurations = AWSConfigs.InitializeCollections ? new List<SMSConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies an AWS Lambda function to manage alarm notifications. You can create one
        /// or use the <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/lambda-support.html">AWS
        /// Lambda function provided by AWS IoT Events</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationTargetActions Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property EmailConfigurations. 
        /// <para>
        /// Contains the configuration information of email notifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<EmailConfiguration> EmailConfigurations
        {
            get { return this._emailConfigurations; }
            set { this._emailConfigurations = value; }
        }

        // Check to see if EmailConfigurations property is set
        internal bool IsSetEmailConfigurations()
        {
            return this._emailConfigurations != null && (this._emailConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SmsConfigurations. 
        /// <para>
        /// Contains the configuration information of SMS notifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<SMSConfiguration> SmsConfigurations
        {
            get { return this._smsConfigurations; }
            set { this._smsConfigurations = value; }
        }

        // Check to see if SmsConfigurations property is set
        internal bool IsSetSmsConfigurations()
        {
            return this._smsConfigurations != null && (this._smsConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}