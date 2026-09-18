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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains details about an endpoint for a model from Amazon Bedrock Marketplace.
    /// </summary>
    public partial class MarketplaceModelEndpoint
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the endpoint was registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string EndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the EndpointArn property is set.
        /// </summary>
        internal bool IsSetEndpointArn() => this.EndpointArn != null;

        /// <summary>
        /// Gets and sets the property EndpointConfig. 
        /// <para>
        /// The configuration of the endpoint, including the number and type of instances used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointConfig EndpointConfig { get; set; }

        /// <summary>
        /// Checks to see if the EndpointConfig property is set.
        /// </summary>
        internal bool IsSetEndpointConfig() => this.EndpointConfig != null;

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The current status of the endpoint (e.g., Creating, InService, Updating, Failed).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatus property is set.
        /// </summary>
        internal bool IsSetEndpointStatus() => this.EndpointStatus != null;

        /// <summary>
        /// Gets and sets the property EndpointStatusMessage. 
        /// <para>
        /// Additional information about the endpoint status, if available.
        /// </para>
        /// </summary>
        public string EndpointStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the EndpointStatusMessage property is set.
        /// </summary>
        internal bool IsSetEndpointStatusMessage() => this.EndpointStatusMessage != null;

        /// <summary>
        /// Gets and sets the property ModelSourceIdentifier. 
        /// <para>
        /// The ARN of the model from Amazon Bedrock Marketplace that is deployed on this endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ModelSourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ModelSourceIdentifier property is set.
        /// </summary>
        internal bool IsSetModelSourceIdentifier() => this.ModelSourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The overall status of the endpoint in Amazon Bedrock Marketplace (e.g., ACTIVE, INACTIVE).
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the overall status, if available.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the endpoint was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
