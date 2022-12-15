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
    /// This is the response object from the DescribeInferenceExperiment operation.
    /// </summary>
    public partial class DescribeInferenceExperimentResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private InferenceExperimentDataStorageConfig _dataStorageConfig;
        private string _description;
        private EndpointMetadata _endpointMetadata;
        private string _kmsKey;
        private DateTime? _lastModifiedTime;
        private List<ModelVariantConfigSummary> _modelVariants = new List<ModelVariantConfigSummary>();
        private string _name;
        private string _roleArn;
        private InferenceExperimentSchedule _schedule;
        private ShadowModeConfig _shadowModeConfig;
        private InferenceExperimentStatus _status;
        private string _statusReason;
        private InferenceExperimentType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the inference experiment being described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        ///  The timestamp at which the inference experiment was completed. 
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp at which you created the inference experiment.
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
        /// Gets and sets the property EndpointMetadata. 
        /// <para>
        /// The metadata of the endpoint on which the inference experiment ran.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointMetadata EndpointMetadata
        {
            get { return this._endpointMetadata; }
            set { this._endpointMetadata = value; }
        }

        // Check to see if EndpointMetadata property is set
        internal bool IsSetEndpointMetadata()
        {
            return this._endpointMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance that hosts the endpoint. For more information, see <a>CreateInferenceExperimentRequest$KmsKey</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp at which you last modified the inference experiment.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelVariants. 
        /// <para>
        ///  An array of <code>ModelVariantConfigSummary</code> objects. There is one for each
        /// variant in the inference experiment. Each <code>ModelVariantConfigSummary</code> object
        /// in the array describes the infrastructure configuration for deploying the corresponding
        /// variant. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ModelVariantConfigSummary> ModelVariants
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
        /// The name of the inference experiment.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The ARN of the IAM role that Amazon SageMaker can assume to access model artifacts
        /// and container images, and manage Amazon SageMaker Inference endpoints for model deployment.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The duration for which the inference experiment ran or will run.
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
        ///  The configuration of <code>ShadowMode</code> inference experiment type, which shows
        /// the production variant that takes all the inference requests, and the shadow variant
        /// to which Amazon SageMaker replicates a percentage of the inference requests. For the
        /// shadow variant it also shows the percentage of requests that Amazon SageMaker replicates.
        /// 
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the inference experiment. The following are the possible statuses for
        /// an inference experiment: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Creating</code> - Amazon SageMaker is creating your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Created</code> - Amazon SageMaker has finished the creation of your experiment
        /// and will begin the experiment at the scheduled time. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Updating</code> - When you make changes to your experiment, your experiment
        /// shows as updating. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Starting</code> - Amazon SageMaker is beginning your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Running</code> - Your experiment is in progress. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Stopping</code> - Amazon SageMaker is stopping your experiment. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Completed</code> - Your experiment has completed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code> - When you conclude your experiment early using the <a>StopInferenceExperiment</a>
        /// API, or if any operation fails with an unexpected error, it shows as cancelled. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceExperimentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The error message or client-specified <code>Reason</code> from the <a>StopInferenceExperiment</a>
        /// API, that explains the status of the inference experiment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceExperimentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}