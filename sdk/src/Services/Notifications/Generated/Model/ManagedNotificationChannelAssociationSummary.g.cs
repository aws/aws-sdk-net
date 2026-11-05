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

namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Provides a summary of channel associations for a managed notification configuration.
    /// </summary>
    public partial class ManagedNotificationChannelAssociationSummary
    {
        /// <summary>
        /// Gets and sets the property ChannelIdentifier. 
        /// <para>
        /// The unique identifier for the notification channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ChannelIdentifier property is set.
        /// </summary>
        internal bool IsSetChannelIdentifier() => this.ChannelIdentifier != null;

        /// <summary>
        /// Gets and sets the property ChannelType. 
        /// <para>
        /// The type of notification channel used for message delivery.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCOUNT_CONTACT</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delivers notifications to Account Managed contacts through the User Notification Service.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>MOBILE</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delivers notifications through the Amazon Web Services Console Mobile Application
        /// to mobile devices.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CHATBOT</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delivers notifications through Amazon Q Developer in chat applications to collaboration
        /// platforms (Slack, Chime).
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>EMAIL</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Delivers notifications to email addresses.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChannelType ChannelType { get; set; }

        /// <summary>
        /// Checks to see if the ChannelType property is set.
        /// </summary>
        internal bool IsSetChannelType() => this.ChannelType != null;

        /// <summary>
        /// Gets and sets the property IsSensitiveEventsSubscribed. 
        /// <para>
        /// Specifies whether this channel association is subscribed to sensitive events. Defaults
        /// to false for associations created without the flag.
        /// </para>
        /// </summary>
        public bool? IsSensitiveEventsSubscribed { get; set; }

        /// <summary>
        /// Checks to see if the IsSensitiveEventsSubscribed property is set.
        /// </summary>
        internal bool IsSetIsSensitiveEventsSubscribed() => this.IsSensitiveEventsSubscribed.HasValue;

        /// <summary>
        /// Gets and sets the property OverrideOption. 
        /// <para>
        /// Controls whether users can modify channel associations for a notification configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Users can associate or disassociate channels with the notification configuration.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Users cannot associate or disassociate channels with the notification configuration.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        public ChannelAssociationOverrideOption OverrideOption { get; set; }

        /// <summary>
        /// Checks to see if the OverrideOption property is set.
        /// </summary>
        internal bool IsSetOverrideOption() => this.OverrideOption != null;
    }
}
