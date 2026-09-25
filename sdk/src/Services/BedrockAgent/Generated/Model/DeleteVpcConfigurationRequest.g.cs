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
    /// Container for the parameters to the DeleteVpcConfiguration operation. Deletes a VPC
    /// configuration. This operation is asynchronous: it returns status <c>DELETING</c>.
    /// Poll <c>GetVpcConfiguration</c> until it returns a <c>ResourceNotFoundException</c>,
    /// indicating the configuration is deleted. Delete requests are idempotent and safe to
    /// retry.
    /// </summary>
    public partial class DeleteVpcConfigurationRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base that owns the VPC configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property VpcConfigurationId. 
        /// <para>
        /// The unique identifier of the VPC configuration to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string VpcConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfigurationId property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationId() => this.VpcConfigurationId != null;
    }
}
