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
    /// Inputs for the model bias job.
    /// </summary>
    public partial class ModelBiasJobInput
    {
        private BatchTransformInput _batchTransformInput;
        private EndpointInput _endpointInput;
        private MonitoringGroundTruthS3Input _groundTruthS3Input;

        /// <summary>
        /// Gets and sets the property BatchTransformInput. 
        /// <para>
        /// Input object for the batch transform job.
        /// </para>
        /// </summary>
        public BatchTransformInput BatchTransformInput
        {
            get { return this._batchTransformInput; }
            set { this._batchTransformInput = value; }
        }

        // Check to see if BatchTransformInput property is set
        internal bool IsSetBatchTransformInput()
        {
            return this._batchTransformInput != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointInput.
        /// </summary>
        public EndpointInput EndpointInput
        {
            get { return this._endpointInput; }
            set { this._endpointInput = value; }
        }

        // Check to see if EndpointInput property is set
        internal bool IsSetEndpointInput()
        {
            return this._endpointInput != null;
        }

        /// <summary>
        /// Gets and sets the property GroundTruthS3Input. 
        /// <para>
        /// Location of ground truth labels to use in model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringGroundTruthS3Input GroundTruthS3Input
        {
            get { return this._groundTruthS3Input; }
            set { this._groundTruthS3Input = value; }
        }

        // Check to see if GroundTruthS3Input property is set
        internal bool IsSetGroundTruthS3Input()
        {
            return this._groundTruthS3Input != null;
        }

    }
}