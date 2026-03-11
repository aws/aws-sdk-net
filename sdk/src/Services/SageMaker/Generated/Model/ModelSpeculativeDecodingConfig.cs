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
    /// Settings for the model speculative decoding technique that's applied by a model optimization
    /// job.
    /// </summary>
    public partial class ModelSpeculativeDecodingConfig
    {
        private ModelSpeculativeDecodingTechnique _technique;
        private ModelSpeculativeDecodingTrainingDataSource _trainingDataSource;

        /// <summary>
        /// Gets and sets the property Technique. 
        /// <para>
        /// The speculative decoding technique to apply during model optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelSpeculativeDecodingTechnique Technique
        {
            get { return this._technique; }
            set { this._technique = value; }
        }

        // Check to see if Technique property is set
        internal bool IsSetTechnique()
        {
            return this._technique != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataSource. 
        /// <para>
        /// The location of the training data to use for speculative decoding. The data must be
        /// formatted as ShareGPT, OpenAI Completions or OpenAI Chat Completions. The input can
        /// also be unencrypted captured data from a SageMaker endpoint as long as the endpoint
        /// uses one of the above formats.
        /// </para>
        /// </summary>
        public ModelSpeculativeDecodingTrainingDataSource TrainingDataSource
        {
            get { return this._trainingDataSource; }
            set { this._trainingDataSource = value; }
        }

        // Check to see if TrainingDataSource property is set
        internal bool IsSetTrainingDataSource()
        {
            return this._trainingDataSource != null;
        }

    }
}