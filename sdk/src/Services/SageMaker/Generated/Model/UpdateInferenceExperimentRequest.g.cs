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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateInferenceExperiment operation. Updates an
    /// inference experiment that you created. The status of the inference experiment has
    /// to be either <c>Created</c>, <c>Running</c>. For more information on the status of
    /// an inference experiment, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeInferenceExperiment.html">DescribeInferenceExperiment</a>.
    /// </summary>
    public partial class UpdateInferenceExperimentRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DataStorageConfig. 
        /// <para>
        /// The Amazon S3 location and configuration for storing inference request and response
        /// data.
        /// </para>
        /// </summary>
        public InferenceExperimentDataStorageConfig DataStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataStorageConfig property is set.
        /// </summary>
        internal bool IsSetDataStorageConfig() => this.DataStorageConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ModelVariants. 
        /// <para>
        ///  An array of <c>ModelVariantConfig</c> objects. There is one for each variant, whose
        /// infrastructure configuration you want to update. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<ModelVariantConfig> ModelVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelVariantConfig>() : null;

        /// <summary>
        /// Checks to see if the ModelVariants property is set.
        /// </summary>
        internal bool IsSetModelVariants() => this.ModelVariants != null && (this.ModelVariants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the inference experiment to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The duration for which the inference experiment will run. If the status of the inference
        /// experiment is <c>Created</c>, then you can update both the start and end dates. If
        /// the status of the inference experiment is <c>Running</c>, then you can update only
        /// the end date. 
        /// </para>
        /// </summary>
        public InferenceExperimentSchedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ShadowModeConfig. 
        /// <para>
        ///  The configuration of <c>ShadowMode</c> inference experiment type. Use this field
        /// to specify a production variant which takes all the inference requests, and a shadow
        /// variant to which Amazon SageMaker replicates a percentage of the inference requests.
        /// For the shadow variant also specify the percentage of requests that Amazon SageMaker
        /// replicates. 
        /// </para>
        /// </summary>
        public ShadowModeConfig ShadowModeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ShadowModeConfig property is set.
        /// </summary>
        internal bool IsSetShadowModeConfig() => this.ShadowModeConfig != null;
    }
}
