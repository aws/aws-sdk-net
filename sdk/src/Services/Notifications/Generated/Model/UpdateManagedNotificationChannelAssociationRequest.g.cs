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
    /// Container for the parameters to the UpdateManagedNotificationChannelAssociation operation.
    /// Updates the <c>isSensitiveEventsSubscribed</c> property of a particular ManagedNotification
    /// channel association.
    /// </summary>
    public partial class UpdateManagedNotificationChannelAssociationRequest : AmazonNotificationsRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelIdentifier. 
        /// <para>
        /// The identifier of the channel association to update. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Account contact identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Channel ARN.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChannelIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ChannelIdentifier property is set.
        /// </summary>
        internal bool IsSetChannelIdentifier() => this.ChannelIdentifier != null;

        /// <summary>
        /// Gets and sets the property IsSensitiveEventsSubscribed. 
        /// <para>
        /// Specifies whether the association is subscribed to sensitive events. The <c>notifications:SubscribeSensitiveEvents</c>
        /// permission controls access to sensitive events.
        /// </para>
        /// </summary>
        public bool? IsSensitiveEventsSubscribed { get; set; }

        /// <summary>
        /// Checks to see if the IsSensitiveEventsSubscribed property is set.
        /// </summary>
        internal bool IsSetIsSensitiveEventsSubscribed() => this.IsSensitiveEventsSubscribed.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedNotificationConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the <c>ManagedNotificationConfiguration</c> whose
        /// Channel association property you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ManagedNotificationConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedNotificationConfigurationArn property is set.
        /// </summary>
        internal bool IsSetManagedNotificationConfigurationArn() => this.ManagedNotificationConfigurationArn != null;
    }
}
