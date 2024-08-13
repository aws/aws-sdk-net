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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
        private NotificationChannel _channel;
        private string _configuredBy;
        private bool? _enabled;
        private NotificationEvent _event;
        private int? _threshold;

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
        public NotificationChannel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ConfiguredBy. 
        /// <para>
        /// The principal that configured the notification setting. For default settings configured
        /// by IAM Roles Anywhere, the value is <c>rolesanywhere.amazonaws.com</c>, and for customized
        /// notifications settings, it is the respective account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ConfiguredBy
        {
            get { return this._configuredBy; }
            set { this._configuredBy = value; }
        }

        // Check to see if ConfiguredBy property is set
        internal bool IsSetConfiguredBy()
        {
            return this._configuredBy != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the notification setting is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event to which this notification setting is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationEvent Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The number of days before a notification event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=360)]
        public int? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

    }
}