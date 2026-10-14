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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpace operation. Creates a space in a domain.
    /// Use GetSpace to retrieve the space, ListSpaces to enumerate spaces, UpdateSpace to
    /// modify it, and DeleteSpace to remove it.
    /// </summary>
    public partial class CreateSpaceRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property AgentCoreEvaluationRoleArn. The ARN of the IAM role used
        /// by AgentCore online evaluation. Must be in the caller's account. Omit if the space
        /// does not use AgentCore online evaluation.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AgentCoreEvaluationRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentCoreEvaluationRoleArn property is set.
        /// </summary>
        internal bool IsSetAgentCoreEvaluationRoleArn() => this.AgentCoreEvaluationRoleArn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token for safe retries. Repeated
        /// requests with the same token return the original result instead of creating a duplicate.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. The ARN of the IAM role used for data
        /// access. The role must be in the caller's account.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DomainId. The ID of the domain to create the space in.
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. How to encrypt the space's data
        /// at rest. Omit for service owned encryption, which is equivalent to passing `encryptionStrategy`
        /// AWS_OWNED.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. A name that identifies the space. Must be 3-64 characters:
        /// lowercase letters, numbers, and hyphens. It must begin and end with a letter or number
        /// and cannot contain consecutive hyphens.
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags to associate with the space.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
