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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The version of the pipeline.
    /// </summary>
    public partial class PipelineVersion
    {
        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the pipeline version.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastExecutedPipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the most recent pipeline execution created from
        /// this pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LastExecutedPipelineExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutedPipelineExecutionArn property is set.
        /// </summary>
        internal bool IsSetLastExecutedPipelineExecutionArn() => this.LastExecutedPipelineExecutionArn != null;

        /// <summary>
        /// Gets and sets the property LastExecutedPipelineExecutionDisplayName. 
        /// <para>
        /// The display name of the most recent pipeline execution created from this pipeline
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 82)]
        public string LastExecutedPipelineExecutionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutedPipelineExecutionDisplayName property is set.
        /// </summary>
        internal bool IsSetLastExecutedPipelineExecutionDisplayName() => this.LastExecutedPipelineExecutionDisplayName != null;

        /// <summary>
        /// Gets and sets the property LastExecutedPipelineExecutionStatus. 
        /// <para>
        /// The status of the most recent pipeline execution created from this pipeline version.
        /// </para>
        /// </summary>
        public PipelineExecutionStatus LastExecutedPipelineExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutedPipelineExecutionStatus property is set.
        /// </summary>
        internal bool IsSetLastExecutedPipelineExecutionStatus() => this.LastExecutedPipelineExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the pipeline version was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string PipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the PipelineArn property is set.
        /// </summary>
        internal bool IsSetPipelineArn() => this.PipelineArn != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionAliases. 
        /// <para>
        /// The aliases assigned to the pipeline version.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> PipelineVersionAliases { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PipelineVersionAliases property is set.
        /// </summary>
        internal bool IsSetPipelineVersionAliases() => this.PipelineVersionAliases != null && (this.PipelineVersionAliases.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineVersionDescription. 
        /// <para>
        /// The description of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3072)]
        public string PipelineVersionDescription { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionDescription property is set.
        /// </summary>
        internal bool IsSetPipelineVersionDescription() => this.PipelineVersionDescription != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionDisplayName. 
        /// <para>
        /// The display name of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 82)]
        public string PipelineVersionDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionDisplayName property is set.
        /// </summary>
        internal bool IsSetPipelineVersionDisplayName() => this.PipelineVersionDisplayName != null;

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? PipelineVersionId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineVersionId property is set.
        /// </summary>
        internal bool IsSetPipelineVersionId() => this.PipelineVersionId.HasValue;
    }
}
