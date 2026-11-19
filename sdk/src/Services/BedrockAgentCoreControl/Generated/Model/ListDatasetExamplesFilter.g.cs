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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A filter for <c>ListDatasetExamples</c>.
    /// </summary>
    public partial class ListDatasetExamplesFilter
    {
        /// <summary>
        /// Gets and sets the property ExampleFields. 
        /// <para>
        ///  Returns only examples that meet at least one of these conditions. Examples last written
        /// before example field filtering was available never match. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<ExampleFieldCondition> ExampleFields { get; set; } = AWSConfigs.InitializeCollections ? new List<ExampleFieldCondition>() : null;

        /// <summary>
        /// Checks to see if the ExampleFields property is set.
        /// </summary>
        internal bool IsSetExampleFields() => this.ExampleFields != null && (this.ExampleFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GenerationIds. 
        /// <para>
        ///  Returns only examples created by this dataset generation. Specify one ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> GenerationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GenerationIds property is set.
        /// </summary>
        internal bool IsSetGenerationIds() => this.GenerationIds != null && (this.GenerationIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
