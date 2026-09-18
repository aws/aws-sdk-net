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
    /// Container for the parameters to the GetFlowVersion operation. Retrieves information
    /// about a version of a flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-deploy.html">Deploy
    /// a flow in Amazon Bedrock</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class GetFlowVersionRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow for which to get information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the FlowIdentifier property is set.
        /// </summary>
        internal bool IsSetFlowIdentifier() => this.FlowIdentifier != null;

        /// <summary>
        /// Gets and sets the property FlowVersion. 
        /// <para>
        /// The version of the flow for which to get information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// Checks to see if the FlowVersion property is set.
        /// </summary>
        internal bool IsSetFlowVersion() => this.FlowVersion != null;

        /// <summary>
        /// Gets and sets the property IncludedData. 
        /// <para>
        /// Controls the scope of data returned. Set to <c>METADATA_ONLY</c> to return only resource
        /// metadata. Set to <c>ALL_DATA</c> or omit this field to return the full response.
        /// </para>
        /// </summary>
        public IncludedData IncludedData { get; set; }

        /// <summary>
        /// Checks to see if the IncludedData property is set.
        /// </summary>
        internal bool IsSetIncludedData() => this.IncludedData != null;
    }
}
