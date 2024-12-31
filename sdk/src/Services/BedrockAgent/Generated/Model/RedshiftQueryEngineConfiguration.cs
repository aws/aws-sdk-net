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
    /// Contains configurations for an Amazon Redshift query engine. Specify the type of query
    /// engine in <c>type</c> and include the corresponding field. For more information, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-build-structured.html">Build
    /// a knowledge base by connecting to a structured data source</a> in the Amazon Bedrock
    /// User Guide.
    /// </summary>
    public partial class RedshiftQueryEngineConfiguration
    {
        private RedshiftProvisionedConfiguration _provisionedConfiguration;
        private RedshiftServerlessConfiguration _serverlessConfiguration;
        private RedshiftQueryEngineType _type;

        /// <summary>
        /// Gets and sets the property ProvisionedConfiguration. 
        /// <para>
        /// Specifies configurations for a provisioned Amazon Redshift query engine.
        /// </para>
        /// </summary>
        public RedshiftProvisionedConfiguration ProvisionedConfiguration
        {
            get { return this._provisionedConfiguration; }
            set { this._provisionedConfiguration = value; }
        }

        // Check to see if ProvisionedConfiguration property is set
        internal bool IsSetProvisionedConfiguration()
        {
            return this._provisionedConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessConfiguration. 
        /// <para>
        /// Specifies configurations for a serverless Amazon Redshift query engine.
        /// </para>
        /// </summary>
        public RedshiftServerlessConfiguration ServerlessConfiguration
        {
            get { return this._serverlessConfiguration; }
            set { this._serverlessConfiguration = value; }
        }

        // Check to see if ServerlessConfiguration property is set
        internal bool IsSetServerlessConfiguration()
        {
            return this._serverlessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of query engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftQueryEngineType Type
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