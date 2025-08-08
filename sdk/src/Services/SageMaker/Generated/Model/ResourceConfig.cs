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
    /// Describes the resources, including machine learning (ML) compute instances and ML
    /// storage volumes, to use for model training.
    /// </summary>
    public partial class ResourceConfig
    {
        private int? _instanceCount;
        private List<InstanceGroup> _instanceGroups = AWSConfigs.InitializeCollections ? new List<InstanceGroup>() : null;
        private InstancePlacementConfig _instancePlacementConfig;
        private TrainingInstanceType _instanceType;
        private int? _keepAlivePeriodInSeconds;
        private string _trainingPlanArn;
        private string _volumeKmsKeyId;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of ML compute instances to use. For distributed training, provide a value
        /// greater than 1. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The configuration of a heterogeneous cluster in JSON format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<InstanceGroup> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && (this._instanceGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstancePlacementConfig. 
        /// <para>
        /// Configuration for how training job instances are placed and allocated within UltraServers.
        /// Only applicable for UltraServer capacity.
        /// </para>
        /// </summary>
        public InstancePlacementConfig InstancePlacementConfig
        {
            get { return this._instancePlacementConfig; }
            set { this._instancePlacementConfig = value; }
        }

        // Check to see if InstancePlacementConfig property is set
        internal bool IsSetInstancePlacementConfig()
        {
            return this._instancePlacementConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type. 
        /// </para>
        /// </summary>
        public TrainingInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KeepAlivePeriodInSeconds. 
        /// <para>
        /// The duration of time in seconds to retain configured resources in a warm pool for
        /// subsequent training jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? KeepAlivePeriodInSeconds
        {
            get { return this._keepAlivePeriodInSeconds; }
            set { this._keepAlivePeriodInSeconds = value; }
        }

        // Check to see if KeepAlivePeriodInSeconds property is set
        internal bool IsSetKeepAlivePeriodInSeconds()
        {
            return this._keepAlivePeriodInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan to use for this resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=2048)]
        public string TrainingPlanArn
        {
            get { return this._trainingPlanArn; }
            set { this._trainingPlanArn = value; }
        }

        // Check to see if TrainingPlanArn property is set
        internal bool IsSetTrainingPlanArn()
        {
            return this._trainingPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key that SageMaker uses to encrypt data on the storage
        /// volume attached to the ML compute instance(s) that run the training job.
        /// </para>
        ///  <note> 
        /// <para>
        /// Certain Nitro-based instances include local storage, dependent on the instance type.
        /// Local storage volumes are encrypted using a hardware module on the instance. You can't
        /// request a <c>VolumeKmsKeyId</c> when using an instance type with local storage.
        /// </para>
        ///  
        /// <para>
        /// For a list of instance types that support local instance storage, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#instance-store-volumes">Instance
        /// Store Volumes</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about local instance storage encryption, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html">SSD
        /// Instance Store Volumes</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <c>VolumeKmsKeyId</c> can be in any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string VolumeKmsKeyId
        {
            get { return this._volumeKmsKeyId; }
            set { this._volumeKmsKeyId = value; }
        }

        // Check to see if VolumeKmsKeyId property is set
        internal bool IsSetVolumeKmsKeyId()
        {
            return this._volumeKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size of the ML storage volume that you want to provision. 
        /// </para>
        ///  
        /// <para>
        /// ML storage volumes store model artifacts and incremental states. Training algorithms
        /// might also use the ML storage volume for scratch space. If you want to store the training
        /// data in the ML storage volume, choose <c>File</c> as the <c>TrainingInputMode</c>
        /// in the algorithm specification. 
        /// </para>
        ///  
        /// <para>
        /// When using an ML instance with <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html#nvme-ssd-volumes">NVMe
        /// SSD volumes</a>, SageMaker doesn't provision Amazon EBS General Purpose SSD (gp2)
        /// storage. Available storage is fixed to the NVMe-type instance's storage capacity.
        /// SageMaker configures storage paths for training datasets, checkpoints, model artifacts,
        /// and outputs to use the entire capacity of the instance storage. For example, ML instance
        /// families with the NVMe-type instance storage include <c>ml.p4d</c>, <c>ml.g4dn</c>,
        /// and <c>ml.g5</c>. 
        /// </para>
        ///  
        /// <para>
        /// When using an ML instance with the EBS-only storage option and without instance storage,
        /// you must define the size of EBS volume through <c>VolumeSizeInGB</c> in the <c>ResourceConfig</c>
        /// API. For example, ML instance families that use EBS volumes include <c>ml.c5</c> and
        /// <c>ml.p2</c>. 
        /// </para>
        ///  
        /// <para>
        /// To look up instance types and their instance storage types and volumes, see <a href="http://aws.amazon.com/ec2/instance-types/">Amazon
        /// EC2 Instance Types</a>.
        /// </para>
        ///  
        /// <para>
        /// To find the default local paths defined by the SageMaker training platform, see <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-train-storage.html">Amazon
        /// SageMaker Training Storage Folders for Training Datasets, Checkpoints, Model Artifacts,
        /// and Outputs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? VolumeSizeInGB
        {
            get { return this._volumeSizeInGB; }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}