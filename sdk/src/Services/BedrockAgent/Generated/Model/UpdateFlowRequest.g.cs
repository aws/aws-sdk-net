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
    /// Container for the parameters to the UpdateFlow operation. Modifies a flow. Include
    /// both fields that you want to keep and fields that you want to change. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-how-it-works.html">How
    /// it works</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-create.html">Create
    /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class UpdateFlowRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to encrypt the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CustomerEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetCustomerEncryptionKeyArn() => this.CustomerEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// A definition of the nodes and the connections between the nodes in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role with permissions to create and
        /// manage a flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-permissions.html">Create
        /// a service role for flows in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowIdentifier() => this.FlowIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
