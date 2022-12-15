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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInferenceExperiment operation.
    /// Updates an inference experiment that you created. The status of the inference experiment
    /// has to be either <code>Created</code>, <code>Running</code>. For more information
    /// on the status of an inference experiment, see <a>DescribeInferenceExperimentResponse$Status</a>.
    /// </summary>
    public partial class UpdateInferenceExperimentRequest : AmazonSageMakerRequest
    {
        private InferenceExperimentDataStorageConfig _dataStorageConfig;
        private string _description;
        private List<ModelVariantConfig> _modelVariants = new List<ModelVariantConfig>();
        private string _name;
        private InferenceExperimentSchedule _schedule;
        private ShadowModeConfig _shadowModeConfig;

        /// <summary>
        /// Gets and sets the property DataStorageConfig. 
        /// <para>
        /// The Amazon S3 location and configuration for storing inference request and response
        /// data.
        /// </para>
        /// </summary>
        public InferenceExperimentDataStorageConfig DataStorageConfig
        {
            get { return this._dataStorageConfig; }
            set { this._dataStorageConfig = value; }
        }

        // Check to see if DataStorageConfig property is set
        internal bool IsSetDataStorageConfig()
        {
            return this._dataStorageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVariants. 
        /// <para>
        ///  An array of <code>ModelVariantConfig</code> objects. There is one for each variant,
        /// whose infrastructure configuration you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ModelVariantConfig> ModelVariants
        {
            get { return this._modelVariants; }
            set { this._modelVariants = value; }
        }

        // Check to see if ModelVariants property is set
        internal bool IsSetModelVariants()
        {
            return this._modelVariants != null && this._modelVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the inference experiment to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The duration for which the inference experiment will run. If the status of the inference
        /// experiment is <code>Created</code>, then you can update both the start and end dates.
        /// If the status of the inference experiment is <code>Running</code>, then you can update
        /// only the end date. 
        /// </para>
        /// </summary>
        public InferenceExperimentSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ShadowModeConfig. 
        /// <para>
        ///  The configuration of <code>ShadowMode</code> inference experiment type. Use this
        /// field to specify a production variant which takes all the inference requests, and
        /// a shadow variant to which Amazon SageMaker replicates a percentage of the inference
        /// requests. For the shadow variant also specify the percentage of requests that Amazon
        /// SageMaker replicates. 
        /// </para>
        /// </summary>
        public ShadowModeConfig ShadowModeConfig
        {
            get { return this._shadowModeConfig; }
            set { this._shadowModeConfig = value; }
        }

        // Check to see if ShadowModeConfig property is set
        internal bool IsSetShadowModeConfig()
        {
            return this._shadowModeConfig != null;
        }

    }
}