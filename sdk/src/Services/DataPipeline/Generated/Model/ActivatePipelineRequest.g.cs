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
    /// Container for the parameters to the ActivatePipeline operation. Validates the specified
    /// pipeline and starts processing pipeline tasks. If the pipeline does not pass validation,
    /// activation fails. <para> If you need to pause the pipeline to investigate an issue
    /// with a component, such as a data source or script, call <a>DeactivatePipeline</a>.
    /// </para> <para> To activate a finished pipeline, modify the end date for the pipeline
    /// and then activate it. </para>
    /// </summary>
    public partial class ActivatePipelineRequest : AmazonDataPipelineRequest
    {
        /// <summary>
        /// Gets and sets the property ParameterValues. 
        /// <para>
        /// A list of parameter values to pass to the pipeline at activation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterValue> ParameterValues { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterValue>() : null;

        /// <summary>
        /// Checks to see if the ParameterValues property is set.
        /// </summary>
        internal bool IsSetParameterValues() => this.ParameterValues != null && (this.ParameterValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PipelineId. 
        /// <para>
        /// The ID of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string PipelineId { get; set; }

        /// <summary>
        /// Checks to see if the PipelineId property is set.
        /// </summary>
        internal bool IsSetPipelineId() => this.PipelineId != null;

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The date and time to resume the pipeline. By default, the pipeline resumes from the
        /// last completed execution.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartTimestamp property is set.
        /// </summary>
        internal bool IsSetStartTimestamp() => this.StartTimestamp.HasValue;
    }
}
