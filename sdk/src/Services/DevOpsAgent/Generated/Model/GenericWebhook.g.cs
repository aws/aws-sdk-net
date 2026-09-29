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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Generic webhook configuration for services that support webhook notifications.
    /// </summary>
    public partial class GenericWebhook
    {
        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// API Key for API Key webhook authentication
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Checks to see if the ApiKey property is set.
        /// </summary>
        internal bool IsSetApiKey() => this.ApiKey != null;

        /// <summary>
        /// Gets and sets the property WebhookId. 
        /// <para>
        /// The unique webhook identifier
        /// </para>
        /// </summary>
        public string WebhookId { get; set; }

        /// <summary>
        /// Checks to see if the WebhookId property is set.
        /// </summary>
        internal bool IsSetWebhookId() => this.WebhookId != null;

        /// <summary>
        /// Gets and sets the property WebhookSecret. 
        /// <para>
        /// The webhook secret for authentication
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string WebhookSecret { get; set; }

        /// <summary>
        /// Checks to see if the WebhookSecret property is set.
        /// </summary>
        internal bool IsSetWebhookSecret() => this.WebhookSecret != null;

        /// <summary>
        /// Gets and sets the property WebhookType. 
        /// <para>
        /// The webhook authentication type
        /// </para>
        /// </summary>
        public WebhookType WebhookType { get; set; }

        /// <summary>
        /// Checks to see if the WebhookType property is set.
        /// </summary>
        internal bool IsSetWebhookType() => this.WebhookType != null;

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// The webhook URL endpoint
        /// </para>
        /// </summary>
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebhookUrl property is set.
        /// </summary>
        internal bool IsSetWebhookUrl() => this.WebhookUrl != null;
    }
}
