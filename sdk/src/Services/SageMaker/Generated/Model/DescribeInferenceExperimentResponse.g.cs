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
    /// This is the response object from the DescribeInferenceExperiment operation.
    /// </summary>
    public partial class DescribeInferenceExperimentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the inference experiment being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        ///  The timestamp at which the inference experiment was completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp at which you created the inference experiment.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        /// Gets and sets the property EndpointMetadata. 
        /// <para>
        /// The metadata of the endpoint on which the inference experiment ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EndpointMetadata EndpointMetadata { get; set; }

        /// <summary>
        /// Checks to see if the EndpointMetadata property is set.
        /// </summary>
        internal bool IsSetEndpointMetadata() => this.EndpointMetadata != null;

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance that hosts the endpoint. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateInferenceExperiment.html">CreateInferenceExperiment</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsKey property is set.
        /// </summary>
        internal bool IsSetKmsKey() => this.KmsKey != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp at which you last modified the inference experiment.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelVariants. 
        /// <para>
        ///  An array of <c>ModelVariantConfigSummary</c> objects. There is one for each variant
        /// in the inference experiment. Each <c>ModelVariantConfigSummary</c> object in the array
        /// describes the infrastructure configuration for deploying the corresponding variant.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ModelVariantConfigSummary> ModelVariants { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelVariantConfigSummary>() : null;

        /// <summary>
        /// Checks to see if the ModelVariants property is set.
        /// </summary>
        internal bool IsSetModelVariants() => this.ModelVariants != null && (this.ModelVariants.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 120)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The ARN of the IAM role that Amazon SageMaker can assume to access model artifacts
        /// and container images, and manage Amazon SageMaker Inference endpoints for model deployment.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The duration for which the inference experiment ran or will run.
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
        ///  The configuration of <c>ShadowMode</c> inference experiment type, which shows the
        /// production variant that takes all the inference requests, and the shadow variant to
        /// which Amazon SageMaker replicates a percentage of the inference requests. For the
        /// shadow variant it also shows the percentage of requests that Amazon SageMaker replicates.
        /// 
        /// </para>
        /// </summary>
        public ShadowModeConfig ShadowModeConfig { get; set; }

        /// <summary>
        /// Checks to see if the ShadowModeConfig property is set.
        /// </summary>
        internal bool IsSetShadowModeConfig() => this.ShadowModeConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the inference experiment. The following are the possible statuses for
        /// an inference experiment: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Amazon SageMaker is creating your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Created</c> - Amazon SageMaker has finished the creation of your experiment and
        /// will begin the experiment at the scheduled time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c> - When you make changes to your experiment, your experiment shows
        /// as updating. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Starting</c> - Amazon SageMaker is beginning your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Running</c> - Your experiment is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Stopping</c> - Amazon SageMaker is stopping your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c> - Your experiment has completed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Cancelled</c> - When you conclude your experiment early using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StopInferenceExperiment.html">StopInferenceExperiment</a>
        /// API, or if any operation fails with an unexpected error, it shows as cancelled. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceExperimentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The error message or client-specified <c>Reason</c> from the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_StopInferenceExperiment.html">StopInferenceExperiment</a>
        /// API, that explains the status of the inference experiment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceExperimentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
