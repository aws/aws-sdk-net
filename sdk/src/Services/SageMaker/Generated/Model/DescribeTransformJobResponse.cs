/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeTransformJob operation.
    /// </summary>
    public partial class DescribeTransformJobResponse : AmazonWebServiceResponse
    {
        private BatchStrategy _batchStrategy;
        private DateTime? _creationTime;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private string _failureReason;
        private string _labelingJobArn;
        private int? _maxConcurrentTransforms;
        private int? _maxPayloadInMB;
        private string _modelName;
        private DateTime? _transformEndTime;
        private TransformInput _transformInput;
        private string _transformJobArn;
        private string _transformJobName;
        private TransformJobStatus _transformJobStatus;
        private TransformOutput _transformOutput;
        private TransformResources _transformResources;
        private DateTime? _transformStartTime;

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// SingleRecord means only one record was used per a batch. <code>MultiRecord</code>
        /// means batches contained as many records that could possibly fit within the <code>MaxPayloadInMB</code>
        /// limit.
        /// </para>
        /// </summary>
        public BatchStrategy BatchStrategy
        {
            get { return this._batchStrategy; }
            set { this._batchStrategy = value; }
        }

        // Check to see if BatchStrategy property is set
        internal bool IsSetBatchStrategy()
        {
            return this._batchStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the transform Job was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment.
        /// </summary>
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the transform job failed, the reason that it failed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LabelingJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SageMaker Ground Truth labeling job that
        /// created the transform or training job.
        /// </para>
        /// </summary>
        public string LabelingJobArn
        {
            get { return this._labelingJobArn; }
            set { this._labelingJobArn = value; }
        }

        // Check to see if LabelingJobArn property is set
        internal bool IsSetLabelingJobArn()
        {
            return this._labelingJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentTransforms. 
        /// <para>
        /// The maximum number of parallel requests on each instance node that can be launched
        /// in a transform job. The default value is 1.
        /// </para>
        /// </summary>
        public int MaxConcurrentTransforms
        {
            get { return this._maxConcurrentTransforms.GetValueOrDefault(); }
            set { this._maxConcurrentTransforms = value; }
        }

        // Check to see if MaxConcurrentTransforms property is set
        internal bool IsSetMaxConcurrentTransforms()
        {
            return this._maxConcurrentTransforms.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPayloadInMB. 
        /// <para>
        /// The maximum payload size , in MB used in the transform job.
        /// </para>
        /// </summary>
        public int MaxPayloadInMB
        {
            get { return this._maxPayloadInMB.GetValueOrDefault(); }
            set { this._maxPayloadInMB = value; }
        }

        // Check to see if MaxPayloadInMB property is set
        internal bool IsSetMaxPayloadInMB()
        {
            return this._maxPayloadInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model used in the transform job.
        /// </para>
        /// </summary>
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property TransformEndTime. 
        /// <para>
        /// Indicates when the transform job is <code>Completed</code>, <code>Stopped</code>,
        /// or <code>Failed</code>. You are billed for the time interval between this time and
        /// the value of <code>TransformStartTime</code>.
        /// </para>
        /// </summary>
        public DateTime TransformEndTime
        {
            get { return this._transformEndTime.GetValueOrDefault(); }
            set { this._transformEndTime = value; }
        }

        // Check to see if TransformEndTime property is set
        internal bool IsSetTransformEndTime()
        {
            return this._transformEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformInput. 
        /// <para>
        /// Describes the dataset to be transformed and the Amazon S3 location where it is stored.
        /// </para>
        /// </summary>
        public TransformInput TransformInput
        {
            get { return this._transformInput; }
            set { this._transformInput = value; }
        }

        // Check to see if TransformInput property is set
        internal bool IsSetTransformInput()
        {
            return this._transformInput != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transform job.
        /// </para>
        /// </summary>
        public string TransformJobArn
        {
            get { return this._transformJobArn; }
            set { this._transformJobArn = value; }
        }

        // Check to see if TransformJobArn property is set
        internal bool IsSetTransformJobArn()
        {
            return this._transformJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job.
        /// </para>
        /// </summary>
        public string TransformJobName
        {
            get { return this._transformJobName; }
            set { this._transformJobName = value; }
        }

        // Check to see if TransformJobName property is set
        internal bool IsSetTransformJobName()
        {
            return this._transformJobName != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJobStatus. 
        /// <para>
        /// The status of the transform job. If the transform job failed, the reason is returned
        /// in the <code>FailureReason</code> field.
        /// </para>
        /// </summary>
        public TransformJobStatus TransformJobStatus
        {
            get { return this._transformJobStatus; }
            set { this._transformJobStatus = value; }
        }

        // Check to see if TransformJobStatus property is set
        internal bool IsSetTransformJobStatus()
        {
            return this._transformJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TransformOutput. 
        /// <para>
        /// Identifies the Amazon S3 location where you want Amazon SageMaker to save the results
        /// from the transform job.
        /// </para>
        /// </summary>
        public TransformOutput TransformOutput
        {
            get { return this._transformOutput; }
            set { this._transformOutput = value; }
        }

        // Check to see if TransformOutput property is set
        internal bool IsSetTransformOutput()
        {
            return this._transformOutput != null;
        }

        /// <summary>
        /// Gets and sets the property TransformResources. 
        /// <para>
        /// Describes the resources, including ML instance types and ML instance count, to use
        /// for the transform job.
        /// </para>
        /// </summary>
        public TransformResources TransformResources
        {
            get { return this._transformResources; }
            set { this._transformResources = value; }
        }

        // Check to see if TransformResources property is set
        internal bool IsSetTransformResources()
        {
            return this._transformResources != null;
        }

        /// <summary>
        /// Gets and sets the property TransformStartTime. 
        /// <para>
        /// Indicates when the transform job starts on ML instances. You are billed for the time
        /// interval between this time and the value of <code>TransformEndTime</code>.
        /// </para>
        /// </summary>
        public DateTime TransformStartTime
        {
            get { return this._transformStartTime.GetValueOrDefault(); }
            set { this._transformStartTime = value; }
        }

        // Check to see if TransformStartTime property is set
        internal bool IsSetTransformStartTime()
        {
            return this._transformStartTime.HasValue; 
        }

    }
}