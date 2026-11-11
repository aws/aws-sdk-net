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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// This is the response object from the ListPipelines operation.
    /// </summary>
    public partial class ListPipelinesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// Indicates whether there are more results that can be obtained by a subsequent call.
        /// </para>
        /// </summary>
        public bool? HasMoreResults { get; set; }

        /// <summary>
        /// Checks to see if the HasMoreResults property is set.
        /// </summary>
        internal bool IsSetHasMoreResults() => this.HasMoreResults.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The starting point for the next page of results. To view the next page of results,
        /// call <c>ListPipelinesOutput</c> again with this marker value. If the value is null,
        /// there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property PipelineIdList. 
        /// <para>
        /// The pipeline identifiers. If you require additional information about the pipelines,
        /// you can use these identifiers to call <a>DescribePipelines</a> and <a>GetPipelineDefinition</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PipelineIdName> PipelineIdList { get; set; } = AWSConfigs.InitializeCollections ? new List<PipelineIdName>() : null;

        /// <summary>
        /// Checks to see if the PipelineIdList property is set.
        /// </summary>
        internal bool IsSetPipelineIdList() => this.PipelineIdList != null && (this.PipelineIdList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
