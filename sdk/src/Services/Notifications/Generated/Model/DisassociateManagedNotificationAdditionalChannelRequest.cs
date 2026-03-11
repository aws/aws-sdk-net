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
    /// Container for the parameters to the DisassociateManagedNotificationAdditionalChannel operation.
    /// Disassociates an additional Channel from a particular <c>ManagedNotificationConfiguration</c>.
    /// 
    ///  
    /// <para>
    /// Supported Channels include Amazon Q Developer in chat applications, the Console Mobile
    /// Application, and emails (notifications-contacts).
    /// </para>
    /// </summary>
    public partial class DisassociateManagedNotificationAdditionalChannelRequest : AmazonNotificationsRequest
    {
        private string _channelArn;
        private string _managedNotificationConfigurationArn;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Channel to associate with the <c>ManagedNotificationConfiguration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Managed Notification Configuration to associate
        /// with the additional Channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedNotificationConfigurationArn
        {
            get { return this._managedNotificationConfigurationArn; }
            set { this._managedNotificationConfigurationArn = value; }
        }

        // Check to see if ManagedNotificationConfigurationArn property is set
        internal bool IsSetManagedNotificationConfigurationArn()
        {
            return this._managedNotificationConfigurationArn != null;
        }

    }
}