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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the DescribePipeline operation.
    /// Describes the details of a pipeline.
    /// </summary>
    public partial class DescribePipelineRequest : AmazonSageMakerRequest
    {
        private string _pipelineName;
        private long? _pipelineVersionId;

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the pipeline to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? PipelineVersionId
        {
            get { return this._pipelineVersionId; }
            set { this._pipelineVersionId = value; }
        }

        // Check to see if PipelineVersionId property is set
        internal bool IsSetPipelineVersionId()
        {
            return this._pipelineVersionId.HasValue; 
        }

    }
}