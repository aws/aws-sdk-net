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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a complete Webhook with all its properties, and unique identifier.
    /// </summary>
    public partial class Webhook
    {
        private string _webhookId;
        private WebhookType _webhookType;
        private string _webhookUrl;

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        /// The unique identifier of the Webhook
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WebhookId
        {
            get { return this._webhookId; }
            set { this._webhookId = value; }
        }

        // Check to see if WebhookId property is set
        internal bool IsSetWebhookId()
        {
            return this._webhookId != null;
        }

        /// <summary>
        /// Gets and sets the property WebhookType. 
        /// <para>
        /// Webhook authentication type.
        /// </para>
        /// </summary>
        public WebhookType WebhookType
        {
            get { return this._webhookType; }
            set { this._webhookType = value; }
        }

        // Check to see if WebhookType property is set
        internal bool IsSetWebhookType()
        {
            return this._webhookType != null;
        }

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// Webhook endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WebhookUrl
        {
            get { return this._webhookUrl; }
            set { this._webhookUrl = value; }
        }

        // Check to see if WebhookUrl property is set
        internal bool IsSetWebhookUrl()
        {
            return this._webhookUrl != null;
        }

    }
}