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
    /// Information about a pipeline.
    /// </summary>
    public partial class PipelineMetadata
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
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

        /// <summary>
        /// Gets and sets the property PollingDisabledAt. 
        /// <para>
        /// The date and time that polling for source changes (periodic checks) was stopped for
        /// the pipeline, in timestamp format. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Pipelines that are inactive for longer than 30 days will have polling disabled for
        /// the pipeline. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#metadata.pollingDisabledAt">pollingDisabledAt</a>
        /// in the pipeline structure reference. For the steps to migrate your pipeline from polling
        /// to event-based change detection, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/update-change-detection.html">Migrate
        /// polling pipelines to use event-based change detection</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can migrate (update) a polling pipeline to use event-based change detection. For
        /// example, for a pipeline with a CodeCommit source, we recommend you migrate (update)
        /// your pipeline to use CloudWatch Events. To learn more, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/update-change-detection.html">Migrate
        /// polling pipelines to use event-based change detection</a> in the <i> CodePipeline
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public DateTime? PollingDisabledAt { get; set; }

        /// <summary>
        /// Checks to see if the PollingDisabledAt property is set.
        /// </summary>
        internal bool IsSetPollingDisabledAt() => this.PollingDisabledAt.HasValue;

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
