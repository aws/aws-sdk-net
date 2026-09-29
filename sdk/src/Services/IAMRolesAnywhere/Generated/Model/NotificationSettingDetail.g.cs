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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The state of a notification setting.
    /// 
    ///  
    /// <para>
    /// A notification setting includes information such as event name, threshold, status
    /// of the notification setting, and the channel to notify.
    /// </para>
    /// </summary>
    public partial class NotificationSettingDetail
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The specified channel of notification. IAM Roles Anywhere uses CloudWatch metrics,
        /// EventBridge, and Health Dashboard to notify for an event.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the absence of a specific channel, IAM Roles Anywhere applies this setting to 'ALL'
        /// channels.
        /// </para>
        ///  </note>
        /// </summary>
        public NotificationChannel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ConfiguredBy. 
        /// <para>
        /// The principal that configured the notification setting. For default settings configured
        /// by IAM Roles Anywhere, the value is <c>rolesanywhere.amazonaws.com</c>, and for customized
        /// notifications settings, it is the respective account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ConfiguredBy { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredBy property is set.
        /// </summary>
        internal bool IsSetConfiguredBy() => this.ConfiguredBy != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the notification setting is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event to which this notification setting is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The number of days before a notification event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 360)]
        public int? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;
    }
}
