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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the StartIdMappingJob operation. Starts the <c>IdMappingJob</c>
    /// of a workflow. The workflow must have previously been created using the <c>CreateIdMappingWorkflow</c>
    /// endpoint.
    /// </summary>
    public partial class StartIdMappingJobRequest : AmazonEntityResolutionRequest
    {
        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        ///  The job type for the ID mapping job.
        /// </para>
        ///  
        /// <para>
        /// If the <c>jobType</c> value is set to <c>INCREMENTAL</c>, only new or changed data
        /// is processed since the last job run. This is the default value if the <c>CreateIdMappingWorkflow</c>
        /// API is configured with an <c>incrementalRunConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>jobType</c> value is set to <c>BATCH</c>, all data is processed from the
        /// input source, regardless of previous job runs. This is the default value if the <c>CreateIdMappingWorkflow</c>
        /// API isn't configured with an <c>incrementalRunConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>jobType</c> value is set to <c>DELETE_ONLY</c>, only deletion requests from
        /// <c>BatchDeleteUniqueIds</c> are processed.
        /// </para>
        /// </summary>
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property OutputSourceConfig. 
        /// <para>
        /// A list of <c>OutputSource</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IdMappingJobOutputSource> OutputSourceConfig { get; set; } = AWSConfigs.InitializeCollections ? new List<IdMappingJobOutputSource>() : null;

        /// <summary>
        /// Checks to see if the OutputSourceConfig property is set.
        /// </summary>
        internal bool IsSetOutputSourceConfig() => this.OutputSourceConfig != null && (this.OutputSourceConfig.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the ID mapping job to be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowName property is set.
        /// </summary>
        internal bool IsSetWorkflowName() => this.WorkflowName != null;
    }
}
