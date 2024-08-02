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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Contains configurations for a Retrieval node in a flow. This node retrieves data from
    /// the Amazon S3 location that you specify and returns it as the output.
    /// </summary>
    public partial class RetrievalFlowNodeConfiguration
    {
        private RetrievalFlowNodeServiceConfiguration _serviceConfiguration;

        /// <summary>
        /// Gets and sets the property ServiceConfiguration. 
        /// <para>
        /// Contains configurations for the service to use for retrieving data to return as the
        /// output from the node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetrievalFlowNodeServiceConfiguration ServiceConfiguration
        {
            get { return this._serviceConfiguration; }
            set { this._serviceConfiguration = value; }
        }

        // Check to see if ServiceConfiguration property is set
        internal bool IsSetServiceConfiguration()
        {
            return this._serviceConfiguration != null;
        }

    }
}