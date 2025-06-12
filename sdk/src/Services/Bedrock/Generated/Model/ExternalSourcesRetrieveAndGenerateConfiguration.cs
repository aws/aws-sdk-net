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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The configuration of the external source wrapper object in the <c>retrieveAndGenerate</c>
    /// function.
    /// </summary>
    public partial class ExternalSourcesRetrieveAndGenerateConfiguration
    {
        private ExternalSourcesGenerationConfiguration _generationConfiguration;
        private string _modelArn;
        private List<ExternalSource> _sources = AWSConfigs.InitializeCollections ? new List<ExternalSource>() : null;

        /// <summary>
        /// Gets and sets the property GenerationConfiguration. 
        /// <para>
        /// Contains configurations details for response generation based on retrieved text chunks.
        /// </para>
        /// </summary>
        public ExternalSourcesGenerationConfiguration GenerationConfiguration
        {
            get { return this._generationConfiguration; }
            set { this._generationConfiguration = value; }
        }

        // Check to see if GenerationConfiguration property is set
        internal bool IsSetGenerationConfiguration()
        {
            return this._generationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a> used to generate responses. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The document for the external source wrapper object in the <c>retrieveAndGenerate</c>
        /// function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ExternalSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}