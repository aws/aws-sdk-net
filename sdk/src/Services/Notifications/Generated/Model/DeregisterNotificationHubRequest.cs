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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterNotificationHub operation.
    /// Deregisters a <c>NotificationConfiguration</c> in the specified Region.
    /// 
    ///  <note> 
    /// <para>
    /// You can't deregister the last <c>NotificationHub</c> in the account. <c>NotificationEvents</c>
    /// stored in the deregistered <c>NotificationConfiguration</c> are no longer be visible.
    /// Recreating a new <c>NotificationConfiguration</c> in the same Region restores access
    /// to those <c>NotificationEvents</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeregisterNotificationHubRequest : AmazonNotificationsRequest
    {
        private string _notificationHubRegion;

        /// <summary>
        /// Gets and sets the property NotificationHubRegion. 
        /// <para>
        /// The <c>NotificationConfiguration</c> Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=25)]
        public string NotificationHubRegion
        {
            get { return this._notificationHubRegion; }
            set { this._notificationHubRegion = value; }
        }

        // Check to see if NotificationHubRegion property is set
        internal bool IsSetNotificationHubRegion()
        {
            return this._notificationHubRegion != null;
        }

    }
}