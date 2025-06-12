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
    /// Contains configurations for an Amazon Redshift database. For more information, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-build-structured.html">Build
    /// a knowledge base by connecting to a structured data source</a> in the Amazon Bedrock
    /// User Guide.
    /// </summary>
    public partial class RedshiftConfiguration
    {
        private RedshiftQueryEngineConfiguration _queryEngineConfiguration;
        private QueryGenerationConfiguration _queryGenerationConfiguration;
        private List<RedshiftQueryEngineStorageConfiguration> _storageConfigurations = AWSConfigs.InitializeCollections ? new List<RedshiftQueryEngineStorageConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property QueryEngineConfiguration. 
        /// <para>
        /// Specifies configurations for an Amazon Redshift query engine.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RedshiftQueryEngineConfiguration QueryEngineConfiguration
        {
            get { return this._queryEngineConfiguration; }
            set { this._queryEngineConfiguration = value; }
        }

        // Check to see if QueryEngineConfiguration property is set
        internal bool IsSetQueryEngineConfiguration()
        {
            return this._queryEngineConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QueryGenerationConfiguration. 
        /// <para>
        /// Specifies configurations for generating queries.
        /// </para>
        /// </summary>
        public QueryGenerationConfiguration QueryGenerationConfiguration
        {
            get { return this._queryGenerationConfiguration; }
            set { this._queryGenerationConfiguration = value; }
        }

        // Check to see if QueryGenerationConfiguration property is set
        internal bool IsSetQueryGenerationConfiguration()
        {
            return this._queryGenerationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfigurations. 
        /// <para>
        /// Specifies configurations for Amazon Redshift database storage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<RedshiftQueryEngineStorageConfiguration> StorageConfigurations
        {
            get { return this._storageConfigurations; }
            set { this._storageConfigurations = value; }
        }

        // Check to see if StorageConfigurations property is set
        internal bool IsSetStorageConfigurations()
        {
            return this._storageConfigurations != null && (this._storageConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}