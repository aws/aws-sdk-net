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
    /// Container for the parameters to the CreateIntegration operation. Creates a new integration
    /// with a third-party provider, such as GitHub, for code review and remediation.
    /// </summary>
    public partial class CreateIntegrationRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The provider-specific input required to create the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property IntegrationDisplayName. 
        /// <para>
        /// The display name for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IntegrationDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationDisplayName property is set.
        /// </summary>
        internal bool IsSetIntegrationDisplayName() => this.IntegrationDisplayName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS KMS key to use for encrypting data associated with the integration.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of an active private connection used to reach a self-hosted provider instance
        /// over private networking. Specify this when the instance is not publicly reachable.
        /// </para>
        /// </summary>
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The integration provider. Currently, only GITHUB is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Provider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the integration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
