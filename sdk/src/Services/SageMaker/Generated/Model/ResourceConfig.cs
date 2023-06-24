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
    /// Describes the resources, including machine learning (ML) compute instances and ML
    /// storage volumes, to use for model training.
    /// </summary>
    public partial class ResourceConfig
    {
        private int? _instanceCount;
        private List<InstanceGroup> _instanceGroups = new List<InstanceGroup>();
        private TrainingInstanceType _instanceType;
        private int? _keepAlivePeriodInSeconds;
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
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
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
        /// </summary>
        [AWSProperty(Max=5)]
        public List<InstanceGroup> InstanceGroups
        {
            get { return this._instanceGroups; }
            set { this._instanceGroups = value; }
        }

        // Check to see if InstanceGroups property is set
        internal bool IsSetInstanceGroups()
        {
            return this._instanceGroups != null && this._instanceGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type. 
        /// </para>
        ///  <note> 
        /// <para>
        /// SageMaker Training on Amazon Elastic Compute Cloud (EC2) P4de instances is in preview
        /// release starting December 9th, 2022. 
        /// </para>
        ///  
        /// <para>
        ///  <a href="http://aws.amazon.com/ec2/instance-types/p4/">Amazon EC2 P4de instances</a>
        /// (currently in preview) are powered by 8 NVIDIA A100 GPUs with 80GB high-performance
        /// HBM2e GPU memory, which accelerate the speed of training ML models that need to be
        /// trained on large datasets of high-resolution data. In this preview release, Amazon
        /// SageMaker supports ML training jobs on P4de instances (<code>ml.p4de.24xlarge</code>)
        /// to reduce model training time. The <code>ml.p4de.24xlarge</code> instances are available
        /// in the following Amazon Web Services Regions. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (N. Virginia) (us-east-1)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (Oregon) (us-west-2)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To request quota limit increase and start using P4de instances, contact the SageMaker
        /// Training service team through your account team.
        /// </para>
        ///  </note>
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
        public int KeepAlivePeriodInSeconds
        {
            get { return this._keepAlivePeriodInSeconds.GetValueOrDefault(); }
            set { this._keepAlivePeriodInSeconds = value; }
        }

        // Check to see if KeepAlivePeriodInSeconds property is set
        internal bool IsSetKeepAlivePeriodInSeconds()
        {
            return this._keepAlivePeriodInSeconds.HasValue; 
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
        /// request a <code>VolumeKmsKeyId</code> when using an instance type with local storage.
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
        /// The <code>VolumeKmsKeyId</code> can be in any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// data in the ML storage volume, choose <code>File</code> as the <code>TrainingInputMode</code>
        /// in the algorithm specification. 
        /// </para>
        ///  
        /// <para>
        /// When using an ML instance with <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html#nvme-ssd-volumes">NVMe
        /// SSD volumes</a>, SageMaker doesn't provision Amazon EBS General Purpose SSD (gp2)
        /// storage. Available storage is fixed to the NVMe-type instance's storage capacity.
        /// SageMaker configures storage paths for training datasets, checkpoints, model artifacts,
        /// and outputs to use the entire capacity of the instance storage. For example, ML instance
        /// families with the NVMe-type instance storage include <code>ml.p4d</code>, <code>ml.g4dn</code>,
        /// and <code>ml.g5</code>. 
        /// </para>
        ///  
        /// <para>
        /// When using an ML instance with the EBS-only storage option and without instance storage,
        /// you must define the size of EBS volume through <code>VolumeSizeInGB</code> in the
        /// <code>ResourceConfig</code> API. For example, ML instance families that use EBS volumes
        /// include <code>ml.c5</code> and <code>ml.p2</code>. 
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
        public int VolumeSizeInGB
        {
            get { return this._volumeSizeInGB.GetValueOrDefault(); }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}