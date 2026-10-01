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
    /// This is the response object from the GetWhatsAppFlow operation.
    /// </summary>
    public partial class GetWhatsAppFlowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The Meta application information associated with this Flow.
        /// </para>
        /// </summary>
        public MetaFlowApplicationInfo Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories that classify the business purpose of the Flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataApiVersion. 
        /// <para>
        /// The data API version for data exchange endpoint Flows.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string DataApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the DataApiVersion property is set.
        /// </summary>
        internal bool IsSetDataApiVersion() => this.DataApiVersion != null;

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
        /// Gets and sets the property FlowId. 
        /// <para>
        /// The unique identifier of the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string FlowId { get; set; }

        /// <summary>
        /// Checks to see if the FlowId property is set.
        /// </summary>
        internal bool IsSetFlowId() => this.FlowId != null;

        /// <summary>
        /// Gets and sets the property FlowName. 
        /// <para>
        /// The name of the Flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string FlowName { get; set; }

        /// <summary>
        /// Checks to see if the FlowName property is set.
        /// </summary>
        internal bool IsSetFlowName() => this.FlowName != null;

        /// <summary>
        /// Gets and sets the property FlowStatus. 
        /// <para>
        /// The lifecycle status of the Flow. Valid values are DRAFT, PUBLISHED, DEPRECATED, BLOCKED,
        /// and THROTTLED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string FlowStatus { get; set; }

        /// <summary>
        /// Checks to see if the FlowStatus property is set.
        /// </summary>
        internal bool IsSetFlowStatus() => this.FlowStatus != null;

        /// <summary>
        /// Gets and sets the property HealthStatus. 
        /// <para>
        /// The health status information for this Flow from Meta.
        /// </para>
        /// </summary>
        public MetaFlowHealthStatus HealthStatus { get; set; }

        /// <summary>
        /// Checks to see if the HealthStatus property is set.
        /// </summary>
        internal bool IsSetHealthStatus() => this.HealthStatus != null;

        /// <summary>
        /// Gets and sets the property JsonVersion. 
        /// <para>
        /// The version of the Flow JSON schema used by this Flow (for example, 7.3).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string JsonVersion { get; set; }

        /// <summary>
        /// Checks to see if the JsonVersion property is set.
        /// </summary>
        internal bool IsSetJsonVersion() => this.JsonVersion != null;

        /// <summary>
        /// Gets and sets the property Preview. 
        /// <para>
        /// The preview URL and its expiration timestamp for testing the Flow.
        /// </para>
        /// </summary>
        public MetaFlowPreviewInfo Preview { get; set; }

        /// <summary>
        /// Checks to see if the Preview property is set.
        /// </summary>
        internal bool IsSetPreview() => this.Preview != null;

        /// <summary>
        /// Gets and sets the property ValidationErrors. 
        /// <para>
        /// A list of validation errors from Meta, if any.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ValidationErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ValidationErrors property is set.
        /// </summary>
        internal bool IsSetValidationErrors() => this.ValidationErrors != null && (this.ValidationErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WhatsAppBusinessAccount. 
        /// <para>
        /// The WhatsApp Business Account information from Meta associated with this Flow.
        /// </para>
        /// </summary>
        public MetaFlowWhatsAppBusinessAccountInfo WhatsAppBusinessAccount { get; set; }

        /// <summary>
        /// Checks to see if the WhatsAppBusinessAccount property is set.
        /// </summary>
        internal bool IsSetWhatsAppBusinessAccount() => this.WhatsAppBusinessAccount != null;
    }
}
