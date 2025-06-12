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
    /// Defines the input needed to run a transform job using the inference specification
    /// specified in the algorithm.
    /// </summary>
    public partial class TransformJobDefinition
    {
        private BatchStrategy _batchStrategy;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _maxConcurrentTransforms;
        private int? _maxPayloadInMB;
        private TransformInput _transformInput;
        private TransformOutput _transformOutput;
        private TransformResources _transformResources;

        /// <summary>
        /// Gets and sets the property BatchStrategy. 
        /// <para>
        /// A string that determines the number of records included in a single mini-batch.
        /// </para>
        ///  
        /// <para>
        ///  <c>SingleRecord</c> means only one record is used per mini-batch. <c>MultiRecord</c>
        /// means a mini-batch is set to contain as many records that can fit within the <c>MaxPayloadInMB</c>
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
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container. We support up to 16 key
        /// and values entries in the map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentTransforms. 
        /// <para>
        /// The maximum number of parallel requests that can be sent to each instance in a transform
        /// job. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxConcurrentTransforms
        {
            get { return this._maxConcurrentTransforms; }
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
        /// (without metadata).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MaxPayloadInMB
        {
            get { return this._maxPayloadInMB; }
            set { this._maxPayloadInMB = value; }
        }

        // Check to see if MaxPayloadInMB property is set
        internal bool IsSetMaxPayloadInMB()
        {
            return this._maxPayloadInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransformInput. 
        /// <para>
        /// A description of the input source and the way the transform job consumes it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TransformOutput. 
        /// <para>
        /// Identifies the Amazon S3 location where you want Amazon SageMaker to save the results
        /// from the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Identifies the ML compute instances for the transform job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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