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
    /// Contains configurations for the metadata fields to include or exclude when considering
    /// reranking. If you include the <c>fieldsToExclude</c> field, the reranker ignores all
    /// the metadata fields that you specify. If you include the <c>fieldsToInclude</c> field,
    /// the reranker uses only the metadata fields that you specify and ignores all others.
    /// You can include only one of these fields.
    /// </summary>
    public partial class RerankingMetadataSelectiveModeConfiguration
    {
        private List<FieldForReranking> _fieldsToExclude = AWSConfigs.InitializeCollections ? new List<FieldForReranking>() : null;
        private List<FieldForReranking> _fieldsToInclude = AWSConfigs.InitializeCollections ? new List<FieldForReranking>() : null;

        /// <summary>
        /// Gets and sets the property FieldsToExclude. 
        /// <para>
        /// An array of objects, each of which specifies a metadata field to exclude from consideration
        /// when reranking.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public List<FieldForReranking> FieldsToExclude
        {
            get { return this._fieldsToExclude; }
            set { this._fieldsToExclude = value; }
        }

        // Check to see if FieldsToExclude property is set
        internal bool IsSetFieldsToExclude()
        {
            return this._fieldsToExclude != null && (this._fieldsToExclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldsToInclude. 
        /// <para>
        /// An array of objects, each of which specifies a metadata field to include in consideration
        /// when reranking. The remaining metadata fields are ignored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public List<FieldForReranking> FieldsToInclude
        {
            get { return this._fieldsToInclude; }
            set { this._fieldsToInclude = value; }
        }

        // Check to see if FieldsToInclude property is set
        internal bool IsSetFieldsToInclude()
        {
            return this._fieldsToInclude != null && (this._fieldsToInclude.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}