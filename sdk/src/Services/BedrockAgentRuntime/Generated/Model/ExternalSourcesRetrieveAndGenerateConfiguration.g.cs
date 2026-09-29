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
    /// The configurations of the external source wrapper object in the <c>retrieveAndGenerate</c>
    /// function.
    /// </summary>
    public partial class ExternalSourcesRetrieveAndGenerateConfiguration
    {
        /// <summary>
        /// Gets and sets the property GenerationConfiguration. 
        /// <para>
        /// The prompt used with the external source wrapper object with the <c>retrieveAndGenerate</c>
        /// function.
        /// </para>
        /// </summary>
        public ExternalSourcesGenerationConfiguration GenerationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GenerationConfiguration property is set.
        /// </summary>
        internal bool IsSetGenerationConfiguration() => this.GenerationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The model Amazon Resource Name (ARN) for the external source wrapper object in the
        /// <c>retrieveAndGenerate</c> function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The document for the external source wrapper object in the <c>retrieveAndGenerate</c>
        /// function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<ExternalSource> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<ExternalSource>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
