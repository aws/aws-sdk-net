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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Configuration for the foundation model.
    /// </summary>
    public partial class FoundationModelConfiguration
    {
        private BedrockFoundationModelConfiguration _bedrockFoundationModelConfiguration;
        private FoundationModelConfigurationType _type;

        /// <summary>
        /// Gets and sets the property BedrockFoundationModelConfiguration. 
        /// <para>
        /// The Bedrock foundation model configuration.
        /// </para>
        /// </summary>
        public BedrockFoundationModelConfiguration BedrockFoundationModelConfiguration
        {
            get { return this._bedrockFoundationModelConfiguration; }
            set { this._bedrockFoundationModelConfiguration = value; }
        }

        // Check to see if BedrockFoundationModelConfiguration property is set
        internal bool IsSetBedrockFoundationModelConfiguration()
        {
            return this._bedrockFoundationModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of foundation model configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FoundationModelConfigurationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}