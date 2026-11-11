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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// This is the response object from the GetPipelineState operation.
    /// </summary>
    public partial class GetPipelineStateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the pipeline was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline for which you want to get the state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PipelineName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineName property is set.
        /// </summary>
        internal bool IsSetPipelineName() => this.PipelineName != null;

        /// <summary>
        /// Gets and sets the property PipelineVersion. 
        /// <para>
        /// The version number of the pipeline.
        /// </para>
        ///  <note> 
        /// <para>
        /// A newly created pipeline is always assigned a version number of <c>1</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? PipelineVersion { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersion property is set.
        /// </summary>
        internal bool IsSetPipelineVersion() => this.PipelineVersion.HasValue;

        /// <summary>
        /// Gets and sets the property StageStates. 
        /// <para>
        /// A list of the pipeline stage output information, including stage name, state, most
        /// recent run details, whether the stage is disabled, and other data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StageState> StageStates { get; set; } = AWSConfigs.InitializeCollections ? new List<StageState>() : null;

        /// <summary>
        /// Checks to see if the StageStates property is set.
        /// </summary>
        internal bool IsSetStageStates() => this.StageStates != null && (this.StageStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Updated. 
        /// <para>
        /// The date and time the pipeline was last updated, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Checks to see if the Updated property is set.
        /// </summary>
        internal bool IsSetUpdated() => this.Updated.HasValue;
    }
}
