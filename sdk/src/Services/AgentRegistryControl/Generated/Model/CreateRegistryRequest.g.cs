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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRegistry operation. Creates a new registry,
    /// a catalog that organizes registry records and defines their discovery authorization
    /// and record approval behavior. Creation is asynchronous: the registry begins in the
    /// CREATING status and becomes usable once it reaches READY.
    /// </summary>
    public partial class CreateRegistryRequest : AmazonAgentRegistryControlRequest
    {
        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// Approval configuration for registry records
        /// </para>
        /// </summary>
        public ApprovalConfiguration ApprovalConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalConfiguration property is set.
        /// </summary>
        internal bool IsSetApprovalConfiguration() => this.ApprovalConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoDetectionConfiguration. 
        /// <para>
        /// The optional auto-detection configuration for the registry. When provided, the registry
        /// is automatically populated with resources discovered according to the configuration.
        /// Omit this field for registries whose records are managed exclusively through the Agent
        /// Registry Control API.
        /// </para>
        /// </summary>
        public AutoDetectionConfiguration AutoDetectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoDetectionConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoDetectionConfiguration() => this.AutoDetectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the registry
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscoveryConfiguration. 
        /// <para>
        /// Discovery configuration for the registry
        /// </para>
        /// </summary>
        public DiscoveryConfiguration DiscoveryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DiscoveryConfiguration property is set.
        /// </summary>
        internal bool IsSetDiscoveryConfiguration() => this.DiscoveryConfiguration != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The optional server-side encryption configuration for the registry. When you provide
        /// this field, the specified customer-managed Amazon Web Services KMS key encrypts the
        /// registry's content. Omit this field to use an Amazon Web Services-owned encryption
        /// key. You cannot change the encryption configuration after registry creation.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the registry
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the registry
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
