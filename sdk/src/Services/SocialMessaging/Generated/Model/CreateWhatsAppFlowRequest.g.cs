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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWhatsAppFlow operation. Creates a new WhatsApp
    /// Flow. Flows enable businesses to create rich, interactive forms and experiences that
    /// users can complete without leaving WhatsApp. The Flow is created in DRAFT status.
    /// If <c>publish</c> is set to <c>true</c> and a valid <c>flowJson</c> is provided, the
    /// Flow is published immediately.
    /// </summary>
    public partial class CreateWhatsAppFlowRequest : AmazonSocialMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories that classify the business purpose of the Flow. At least one category
        /// is required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 9)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CloneFlowId. 
        /// <para>
        /// The ID of an existing Flow within the same WhatsApp Business Account to clone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string CloneFlowId { get; set; }

        /// <summary>
        /// Checks to see if the CloneFlowId property is set.
        /// </summary>
        internal bool IsSetCloneFlowId() => this.CloneFlowId != null;

        /// <summary>
        /// Gets and sets the property EndpointUri. 
        /// <para>
        /// The HTTPS endpoint that Meta calls for a data exchange Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EndpointUri { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUri property is set.
        /// </summary>
        internal bool IsSetEndpointUri() => this.EndpointUri != null;

        /// <summary>
        /// Gets and sets the property FlowJson. 
        /// <para>
        /// The Flow JSON definition that describes the screens, components, and logic of the
        /// Flow. Maximum size is 10 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10485760)]
        public MemoryStream FlowJson { get; set; }

        /// <summary>
        /// Checks to see if the FlowJson property is set.
        /// </summary>
        internal bool IsSetFlowJson() => this.FlowJson != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The name of the Flow. Must be unique within the WhatsApp Business Account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the WhatsApp Business Account to associate with this Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Publish. 
        /// <para>
        /// Set to <c>true</c> to publish the Flow immediately after creation. Requires a valid
        /// <c>flowJson</c> that passes Meta's validation.
        /// </para>
        /// </summary>
        public bool? Publish { get; set; }

        /// <summary>
        /// Checks to see if the Publish property is set.
        /// </summary>
        internal bool IsSetPublish() => this.Publish.HasValue;
    }
}
