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
    /// Container for the parameters to the UpdatePipelineExecution operation.
    /// Updates a pipeline execution.
    /// </summary>
    public partial class UpdatePipelineExecutionRequest : AmazonSageMakerRequest
    {
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineExecutionArn;
        private string _pipelineExecutionDescription;
        private string _pipelineExecutionDisplayName;

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// This configuration, if specified, overrides the parallelism configuration of the parent
        /// pipeline for this specific run.
        /// </para>
        /// </summary>
        public ParallelismConfiguration ParallelismConfiguration
        {
            get { return this._parallelismConfiguration; }
            set { this._parallelismConfiguration = value; }
        }

        // Check to see if ParallelismConfiguration property is set
        internal bool IsSetParallelismConfiguration()
        {
            return this._parallelismConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string PipelineExecutionArn
        {
            get { return this._pipelineExecutionArn; }
            set { this._pipelineExecutionArn = value; }
        }

        // Check to see if PipelineExecutionArn property is set
        internal bool IsSetPipelineExecutionArn()
        {
            return this._pipelineExecutionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDescription. 
        /// <para>
        /// The description of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string PipelineExecutionDescription
        {
            get { return this._pipelineExecutionDescription; }
            set { this._pipelineExecutionDescription = value; }
        }

        // Check to see if PipelineExecutionDescription property is set
        internal bool IsSetPipelineExecutionDescription()
        {
            return this._pipelineExecutionDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionDisplayName. 
        /// <para>
        /// The display name of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=82)]
        public string PipelineExecutionDisplayName
        {
            get { return this._pipelineExecutionDisplayName; }
            set { this._pipelineExecutionDisplayName = value; }
        }

        // Check to see if PipelineExecutionDisplayName property is set
        internal bool IsSetPipelineExecutionDisplayName()
        {
            return this._pipelineExecutionDisplayName != null;
        }

    }
}