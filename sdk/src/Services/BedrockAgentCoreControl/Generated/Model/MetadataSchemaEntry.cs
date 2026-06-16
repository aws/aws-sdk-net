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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
        private ExtractionConfig _extractionConfig;
        private ExtractionType _extractionType;
        private string _key;
        private MetadataValueType _type;

        /// <summary>
        /// Gets and sets the property ExtractionConfig. 
        /// <para>
        /// Configuration for extracting this metadata value from conversational content. Applicable
        /// only if extractionType is LLM inferred.
        /// </para>
        /// </summary>
        public ExtractionConfig ExtractionConfig
        {
            get { return this._extractionConfig; }
            set { this._extractionConfig = value; }
        }

        // Check to see if ExtractionConfig property is set
        internal bool IsSetExtractionConfig()
        {
            return this._extractionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionType. 
        /// <para>
        /// Specifies whether the metadata value is extracted by the LLM or passed through deterministically
        /// from the event.
        /// </para>
        /// </summary>
        public ExtractionType ExtractionType
        {
            get { return this._extractionType; }
            set { this._extractionType = value; }
        }

        // Check to see if ExtractionType property is set
        internal bool IsSetExtractionType()
        {
            return this._extractionType != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The metadata field name. Must match an indexed key to be queryable via metadata filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The MetadataValueType.
        /// </para>
        /// </summary>
        public MetadataValueType Type
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