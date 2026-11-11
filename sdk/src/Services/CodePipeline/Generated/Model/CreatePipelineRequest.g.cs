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
    /// Container for the parameters to the CreatePipeline operation. Creates a pipeline.
    /// <note> <para> In the pipeline structure, you must include either <c>artifactStore</c>
    /// or <c>artifactStores</c> in your pipeline, but you cannot use both. If you create
    /// a cross-region action in your pipeline, you must use <c>artifactStores</c>. </para>
    /// </note>
    /// </summary>
    public partial class CreatePipelineRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// Represents the structure of actions and stages to be performed in the pipeline. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PipelineDeclaration Pipeline { get; set; }

        /// <summary>
        /// Checks to see if the Pipeline property is set.
        /// </summary>
        internal bool IsSetPipeline() => this.Pipeline != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
