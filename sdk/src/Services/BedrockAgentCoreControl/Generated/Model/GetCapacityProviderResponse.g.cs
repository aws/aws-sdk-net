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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityProvider operation.
    /// </summary>
    public partial class GetCapacityProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderArn property is set.
        /// </summary>
        internal bool IsSetCapacityProviderArn() => this.CapacityProviderArn != null;

        /// <summary>
        /// Gets and sets the property CapacityProviderId. 
        /// <para>
        /// The unique identifier of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string CapacityProviderId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderId property is set.
        /// </summary>
        internal bool IsSetCapacityProviderId() => this.CapacityProviderId != null;

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the capacity provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the capacity provider, if one was provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the capacity provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PermissionsConfiguration. 
        /// <para>
        /// The permissions configuration for the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PermissionsConfiguration PermissionsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PermissionsConfiguration property is set.
        /// </summary>
        internal bool IsSetPermissionsConfiguration() => this.PermissionsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capacity provider. For possible values, see <c>CapacityProviderStatus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityProviderStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// A reason code for a capacity provider that is not in the <c>READY</c> state. Use this
        /// code for programmatic error handling.
        /// </para>
        /// </summary>
        public CapacityProviderStatusCode StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable message that describes why the capacity provider is not in the <c>READY</c>
        /// state. Because these messages can change, use <c>statusCode</c> for programmatic error
        /// handling.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
