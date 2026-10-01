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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The push notification configuration of the message.
    /// </summary>
    public partial class PushNotificationConfiguration
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the push notification.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 150)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the push notification.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Enum value that indicates the type of the push notification for a message. <c>DEFAULT</c>:
        /// Normal mobile push notification. <c>VOIP</c>: VOIP mobile push notification.
        /// </para>
        /// </summary>
        public PushNotificationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
