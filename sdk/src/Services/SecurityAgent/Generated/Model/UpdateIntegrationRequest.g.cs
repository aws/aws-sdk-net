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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIntegration operation. Creates an integration's
    /// webhook, or rotates the HMAC signing secret of an existing one. The secret is returned
    /// only once, in this response, and cannot be retrieved again.
    /// </summary>
    public partial class UpdateIntegrationRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property IntegrationId. 
        /// <para>
        /// The ID of the integration whose webhook you want to create or rotate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationId { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationId property is set.
        /// </summary>
        internal bool IsSetIntegrationId() => this.IntegrationId != null;

        /// <summary>
        /// Gets and sets the property WebhookAction. 
        /// <para>
        /// The action to perform on the integration's webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookAction WebhookAction { get; set; }

        /// <summary>
        /// Checks to see if the WebhookAction property is set.
        /// </summary>
        internal bool IsSetWebhookAction() => this.WebhookAction != null;
    }
}
