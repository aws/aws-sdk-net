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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Configuration for selectively including or excluding metadata fields during the reranking
    /// process. This allows you to control which metadata attributes are considered when
    /// reordering search results.
    /// </summary>
    public partial class RerankingMetadataSelectiveModeConfiguration
    {
        /// <summary>
        /// Gets and sets the property FieldsToExclude. 
        /// <para>
        /// A list of metadata field names to explicitly exclude from the reranking process. All
        /// metadata fields except these will be considered when reordering search results. This
        /// parameter cannot be used together with fieldsToInclude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public List<FieldForReranking> FieldsToExclude { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldForReranking>() : null;

        /// <summary>
        /// Checks to see if the FieldsToExclude property is set.
        /// </summary>
        internal bool IsSetFieldsToExclude() => this.FieldsToExclude != null && (this.FieldsToExclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldsToInclude. 
        /// <para>
        /// A list of metadata field names to explicitly include in the reranking process. Only
        /// these fields will be considered when reordering search results. This parameter cannot
        /// be used together with fieldsToExclude.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public List<FieldForReranking> FieldsToInclude { get; set; } = AWSConfigs.InitializeCollections ? new List<FieldForReranking>() : null;

        /// <summary>
        /// Checks to see if the FieldsToInclude property is set.
        /// </summary>
        internal bool IsSetFieldsToInclude() => this.FieldsToInclude != null && (this.FieldsToInclude.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
