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
    /// Container for the parameters to the CreatePipeline operation. Creates a new, empty
    /// pipeline. Use <a>PutPipelineDefinition</a> to populate the pipeline.
    /// </summary>
    public partial class CreatePipelineRequest : AmazonDataPipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the pipeline. You can use the same name for multiple pipelines associated
        /// with your AWS account, because AWS Data Pipeline assigns each pipeline a unique pipeline
        /// identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the pipeline at creation. Tags let you control access
        /// to pipelines. For more information, see <a href="http://docs.aws.amazon.com/datapipeline/latest/DeveloperGuide/dp-control-access.html">Controlling
        /// User Access to Pipelines</a> in the <i>AWS Data Pipeline Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// A unique identifier. This identifier is not the same as the pipeline identifier assigned
        /// by AWS Data Pipeline. You are responsible for defining the format and ensuring the
        /// uniqueness of this identifier. You use this parameter to ensure idempotency during
        /// repeated calls to <c>CreatePipeline</c>. For example, if the first call to <c>CreatePipeline</c>
        /// does not succeed, you can pass in the same unique identifier and pipeline name combination
        /// on a subsequent call to <c>CreatePipeline</c>. <c>CreatePipeline</c> ensures that
        /// if a pipeline already exists with the same name and unique identifier, a new pipeline
        /// is not created. Instead, you'll receive the pipeline identifier from the previous
        /// attempt. The uniqueness of the name and unique identifier combination is scoped to
        /// the AWS account or IAM user credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Checks to see if the UniqueId property is set.
        /// </summary>
        internal bool IsSetUniqueId() => this.UniqueId != null;
    }
}
