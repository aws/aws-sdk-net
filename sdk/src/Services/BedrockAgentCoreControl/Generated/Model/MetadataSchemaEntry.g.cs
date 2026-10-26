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
    /// A metadata field definition within a strategy's schema.
    /// </summary>
    public partial class MetadataSchemaEntry
    {
        /// <summary>
        /// Gets and sets the property ExtractionConfig. 
        /// <para>
        /// Configuration for extracting this metadata value from conversational content. Applicable
        /// only if extractionType is LLM inferred.
        /// </para>
        /// </summary>
        public ExtractionConfig ExtractionConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionConfig property is set.
        /// </summary>
        internal bool IsSetExtractionConfig() => this.ExtractionConfig != null;

        /// <summary>
        /// Gets and sets the property ExtractionType. 
        /// <para>
        /// Specifies whether the metadata value is extracted by the LLM or passed through deterministically
        /// from the event.
        /// </para>
        /// </summary>
        public ExtractionType ExtractionType { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionType property is set.
        /// </summary>
        internal bool IsSetExtractionType() => this.ExtractionType != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The metadata field name. Must match an indexed key to be queryable via metadata filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The MetadataValueType.
        /// </para>
        /// </summary>
        public MetadataValueType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
