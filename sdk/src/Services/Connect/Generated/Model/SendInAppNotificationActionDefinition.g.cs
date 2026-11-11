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
    /// Information about the send in-app notification action.
    /// </summary>
    public partial class SendInAppNotificationActionDefinition
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Notification content. Supports variable injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Connect Customer Administrators Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> Content { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Exclusion. 
        /// <para>
        /// Recipients to exclude from notification.
        /// </para>
        /// </summary>
        public NotificationRecipientType Exclusion { get; set; }

        /// <summary>
        /// Checks to see if the Exclusion property is set.
        /// </summary>
        internal bool IsSetExclusion() => this.Exclusion != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Notification priority.
        /// </para>
        /// </summary>
        public ConfigurableNotificationPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// Notification recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationRecipientType Recipient { get; set; }

        /// <summary>
        /// Checks to see if the Recipient property is set.
        /// </summary>
        internal bool IsSetRecipient() => this.Recipient != null;
    }
}
