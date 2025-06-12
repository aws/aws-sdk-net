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
    /// Contains information about one or more notification actions.
    /// </summary>
    public partial class AlarmNotification
    {
        private List<NotificationAction> _notificationActions = AWSConfigs.InitializeCollections ? new List<NotificationAction>() : null;

        /// <summary>
        /// Gets and sets the property NotificationActions. 
        /// <para>
        /// Contains the notification settings of an alarm model. The settings apply to all alarms
        /// that were created based on this alarm model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<NotificationAction> NotificationActions
        {
            get { return this._notificationActions; }
            set { this._notificationActions = value; }
        }

        // Check to see if NotificationActions property is set
        internal bool IsSetNotificationActions()
        {
            return this._notificationActions != null && (this._notificationActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}