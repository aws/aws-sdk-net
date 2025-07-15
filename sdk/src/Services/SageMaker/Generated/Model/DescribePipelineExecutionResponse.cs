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
    /// This is the response object from the DescribePipelineExecution operation.
    /// </summary>
    public partial class DescribePipelineExecutionResponse : AmazonWebServiceResponse
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _failureReason;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private ParallelismConfiguration _parallelismConfiguration;
        private string _pipelineArn;
        private string _pipelineExecutionArn;
        private string _pipelineExecutionDescription;
        private string _pipelineExecutionDisplayName;
        private PipelineExecutionStatus _pipelineExecutionStatus;
        private PipelineExperimentConfig _pipelineExperimentConfig;
        private long? _pipelineVersionId;
        private SelectiveExecutionConfig _selectiveExecutionConfig;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the pipeline execution was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the execution failed, a message describing why.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1300)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the pipeline execution was modified last.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfiguration. 
        /// <para>
        /// The parallelism configuration applied to the pipeline.
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
        /// Gets and sets the property PipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property PipelineExecutionStatus. 
        /// <para>
        /// The status of the pipeline execution.
        /// </para>
        /// </summary>
        public PipelineExecutionStatus PipelineExecutionStatus
        {
            get { return this._pipelineExecutionStatus; }
            set { this._pipelineExecutionStatus = value; }
        }

        // Check to see if PipelineExecutionStatus property is set
        internal bool IsSetPipelineExecutionStatus()
        {
            return this._pipelineExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExperimentConfig.
        /// </summary>
        public PipelineExperimentConfig PipelineExperimentConfig
        {
            get { return this._pipelineExperimentConfig; }
            set { this._pipelineExperimentConfig = value; }
        }

        // Check to see if PipelineExperimentConfig property is set
        internal bool IsSetPipelineExperimentConfig()
        {
            return this._pipelineExperimentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineVersionId. 
        /// <para>
        /// The ID of the pipeline version.
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

        /// <summary>
        /// Gets and sets the property SelectiveExecutionConfig. 
        /// <para>
        /// The selective execution configuration applied to the pipeline run.
        /// </para>
        /// </summary>
        public SelectiveExecutionConfig SelectiveExecutionConfig
        {
            get { return this._selectiveExecutionConfig; }
            set { this._selectiveExecutionConfig = value; }
        }

        // Check to see if SelectiveExecutionConfig property is set
        internal bool IsSetSelectiveExecutionConfig()
        {
            return this._selectiveExecutionConfig != null;
        }

    }
}