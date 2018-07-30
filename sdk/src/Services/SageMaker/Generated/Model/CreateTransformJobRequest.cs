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
    /// Container for the parameters to the CreateTransformJob operation.
    /// Starts a transform job. A transform job uses a trained model to get inferences on
    /// a dataset and saves these results to an Amazon S3 location that you specify.
    /// 
    ///  
    /// <para>
    /// To perform batch transformations, you create a transform job and use the data that
    /// you have readily available.
    /// </para>
    ///  
    /// <para>
    /// In the request body, you provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>TransformJobName</code> - Identifies the transform job. The name must be unique
    /// within an AWS Region in an AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ModelName</code> - Identifies the model to use. <code>ModelName</code> must
    /// be the name of an existing Amazon SageMaker model within an AWS Region in an AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TransformInput</code> - Describes the dataset to be transformed and the Amazon
    /// S3 location where it is stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TransformOutput</code> - Identifies the Amazon S3 location where you want Amazon
    /// SageMaker to save the results from the transform job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TransformResources</code> - Identifies the ML compute instances for the transform
    /// job.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about how batch transformation works Amazon SageMaker, see <a
    /// href="http://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">How It
    /// Works</a>. 
    /// </para>
    /// </summary>
    public partial class CreateTransformJobRequest : AmazonSageMakerRequest
    {
        private BatchStrategy _batchStrategy;
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private int? _maxConcurrentTransforms;
        private int? _maxPayloadInMB;
        private string _modelName;
        private List<Tag> _tags = new List<Tag>();
        private TransformInput _transformInput;
        private string _transformJobName;
        private TransformOutput _transformOutput;
        private TransformResources _transformResources;

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// Determines the number of records included in a single mini-batch. <code>SingleRecord</code>
        /// means only one record is used per mini-batch. <code>MultiRecord</code> means a mini-batch
        /// is set to contain as many records that can fit within the <code>MaxPayloadInMB</code>
        /// limit.
        /// </para>
        ///  
        /// <para>
        /// Batch transform will automatically split your input data into whatever payload size
        /// is specified if you set <code>SplitType</code> to <code>Line</code> and <code>BatchStrategy</code>
        /// to <code>MultiRecord</code>. There's no need to split the dataset into smaller files
        /// or to use larger payload sizes unless the records in your dataset are very large.
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. We support up to 16 key
        /// and values entries in the map.
        /// </para>
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
        /// Gets and sets the property MaxConcurrentTransforms. 
        /// <para>
        /// The maximum number of parallel requests that can be sent to each instance in a transform
        /// job. This is good for algorithms that implement multiple workers on larger instances
        /// . The default value is <code>1</code>. To allow Amazon SageMaker to determine the
        /// appropriate number for <code>MaxConcurrentTransforms</code>, set the value to <code>0</code>.
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
        /// The maximum payload size allowed, in MB. A payload is the data portion of a record
        /// (without metadata). The value in <code>MaxPayloadInMB</code> must be greater or equal
        /// to the size of a single record. You can approximate the size of a record by dividing
        /// the size of your dataset by the number of records. Then multiply this value by the
        /// number of records you want in a mini-batch. It is recommended to enter a value slightly
        /// larger than this to ensure the records fit within the maximum payload size. The default
        /// value is <code>6</code> MB. For an unlimited payload size, set the value to <code>0</code>.
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
        /// The name of the model that you want to use for the transform job. <code>ModelName</code>
        /// must be the name of an existing Amazon SageMaker model within an AWS Region in an
        /// AWS account.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. Adding tags is optional. For more information, see <a
        /// href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TransformInput. 
        /// <para>
        /// Describes the input source and the way the transform job consumes it.
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
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the transform job. The name must be unique within an AWS Region in an
        /// AWS account. 
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
        /// Gets and sets the property TransformOutput. 
        /// <para>
        /// Describes the results of the transform job.
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

    }
}