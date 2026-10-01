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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private Dictionary<string, string> _content = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NotificationRecipientType _exclusion;
        private ConfigurableNotificationPriority _priority;
        private NotificationRecipientType _recipient;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Notification content. Supports variable injection. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/contact-lens-variable-injection.html">JSONPath
        /// reference</a> in the <i>Connect Customer Administrators Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Exclusion. 
        /// <para>
        /// Recipients to exclude from notification.
        /// </para>
        /// </summary>
        public NotificationRecipientType Exclusion
        {
            get { return this._exclusion; }
            set { this._exclusion = value; }
        }

        // Check to see if Exclusion property is set
        internal bool IsSetExclusion()
        {
            return this._exclusion != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Notification priority.
        /// </para>
        /// </summary>
        public ConfigurableNotificationPriority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property Recipient. 
        /// <para>
        /// Notification recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationRecipientType Recipient
        {
            get { return this._recipient; }
            set { this._recipient = value; }
        }

        // Check to see if Recipient property is set
        internal bool IsSetRecipient()
        {
            return this._recipient != null;
        }

    }
}