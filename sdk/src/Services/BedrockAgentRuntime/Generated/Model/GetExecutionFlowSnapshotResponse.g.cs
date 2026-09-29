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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetExecutionFlowSnapshot operation.
    /// </summary>
    public partial class GetExecutionFlowSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customer managed KMS key that's used to encrypt
        /// the flow snapshot.
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
        /// The flow definition used for the flow execution, including the nodes, connections,
        /// and configuration at the time when the execution started.
        /// </para>
        ///  
        /// <para>
        /// The definition returns as a string that follows the structure of a <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent_FlowDefinition.html">FlowDefinition</a>
        /// object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that's used by the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property FlowAliasIdentifier. 
        /// <para>
        /// The unique identifier of the flow alias used for the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string FlowAliasIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowAliasIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowAliasIdentifier() => this.FlowAliasIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string FlowIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowIdentifier() => this.FlowIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowVersion. 
        /// <para>
        /// The version of the flow used for the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// Checks to see if the FlowVersion property is set.
        /// </summary>
        internal bool IsSetFlowVersion() => this.FlowVersion != null;
    }
}
