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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRetrievalInstruction operation. Creates
    /// a new retrieval instruction. The retrieval instruction is usable once its status becomes
    /// ACTIVE. Use GetRetrievalInstruction to check whether it is ready.
    /// </summary>
    public partial class CreateRetrievalInstructionRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A caller-supplied token that makes a retried create return the existing resource rather
        /// than a second one. The window is 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a customer managed AWS Key Management Service (AWS
        /// KMS) key used to encrypt the instruction content at rest. If you omit it, the service
        /// uses an AWS owned key. You fix the key at create and cannot change it later.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a description of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Instruction. 
        /// <para>
        /// The instruction content, as a set of named fields. Get does not return this field
        /// until the create review passes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public RetrievalInstructionContent Instruction { get; set; }

        /// <summary>
        /// Checks to see if the Instruction property is set.
        /// </summary>
        internal bool IsSetInstruction() => this.Instruction != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the retrieval instruction.
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
