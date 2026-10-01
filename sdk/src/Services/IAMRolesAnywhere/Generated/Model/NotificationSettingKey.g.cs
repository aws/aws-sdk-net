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
    /// A notification setting key to reset. A notification setting key includes the event
    /// and the channel.
    /// </summary>
    public partial class NotificationSettingKey
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The specified channel of notification.
        /// </para>
        /// </summary>
        public NotificationChannel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The notification setting event to reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;
    }
}
