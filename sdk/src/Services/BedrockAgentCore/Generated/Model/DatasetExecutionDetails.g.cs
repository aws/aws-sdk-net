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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The details of the dataset and agent that a batch evaluation ran.
    /// </summary>
    public partial class DatasetExecutionDetails
    {
        /// <summary>
        /// Gets and sets the property AgentInvocation. 
        /// <para>
        /// The agent that the batch evaluation invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentInvocationDetails AgentInvocation { get; set; }

        /// <summary>
        /// Checks to see if the AgentInvocation property is set.
        /// </summary>
        internal bool IsSetAgentInvocation() => this.AgentInvocation != null;

        /// <summary>
        /// Gets and sets the property Dataset. 
        /// <para>
        /// The dataset and the version of it that the batch evaluation ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DatasetDetails Dataset { get; set; }

        /// <summary>
        /// Checks to see if the Dataset property is set.
        /// </summary>
        internal bool IsSetDataset() => this.Dataset != null;
    }
}
