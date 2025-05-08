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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
        private DateTime? _created;
        private string _pipelineArn;
        private DateTime? _pollingDisabledAt;
        private DateTime? _updated;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the pipeline was created, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        public string PipelineArn
        {
            get { return this._pipelineArn; }
            set { this._pipelineArn = value; }
        }

        // Check to see if PipelineArn property is set
        internal bool IsSetPipelineArn()
        {
            return this._pipelineArn != null;
        }

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
        /// polling pipelines to use event-based change detection</a> in the <i>CodePipeline User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public DateTime? PollingDisabledAt
        {
            get { return this._pollingDisabledAt; }
            set { this._pollingDisabledAt = value; }
        }

        // Check to see if PollingDisabledAt property is set
        internal bool IsSetPollingDisabledAt()
        {
            return this._pollingDisabledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Updated. 
        /// <para>
        /// The date and time the pipeline was last updated, in timestamp format.
        /// </para>
        /// </summary>
        public DateTime? Updated
        {
            get { return this._updated; }
            set { this._updated = value; }
        }

        // Check to see if Updated property is set
        internal bool IsSetUpdated()
        {
            return this._updated.HasValue; 
        }

    }
}