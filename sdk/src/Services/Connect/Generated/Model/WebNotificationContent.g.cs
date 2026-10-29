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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The content of an outbound web notification, including the notification type, the
    /// view to render, and any optional attributes used to populate the view.
    /// </summary>
    public partial class WebNotificationContent
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Optional attributes used to populate the notification content, such as recommender
        /// configuration for personalized content.
        /// </para>
        /// </summary>
        public ContentAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of web notification to send.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the view to render for the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ViewArn { get; set; }

        /// <summary>
        /// Checks to see if the ViewArn property is set.
        /// </summary>
        internal bool IsSetViewArn() => this.ViewArn != null;
    }
}
