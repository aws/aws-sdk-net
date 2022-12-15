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
    /// The configuration of resources, including compute instances and storage volumes for
    /// use in training jobs launched by hyperparameter tuning jobs. <code>HyperParameterTuningResourceConfig</code>
    /// is similar to <code>ResourceConfig</code>, but has the additional <code>InstanceConfigs</code>
    /// and <code>AllocationStrategy</code> fields to allow for flexible instance management.
    /// Specify one or more instance types, count, and the allocation strategy for instance
    /// selection.
    /// 
    ///  <note> 
    /// <para>
    ///  <code>HyperParameterTuningResourceConfig</code> supports the capabilities of <code>ResourceConfig</code>
    /// with the exception of <code>KeepAlivePeriodInSeconds</code>. Hyperparameter tuning
    /// jobs use warm pools by default, which reuse clusters between training jobs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HyperParameterTuningResourceConfig
    {
        private HyperParameterTuningAllocationStrategy _allocationStrategy;
        private List<HyperParameterTuningInstanceConfig> _instanceConfigs = new List<HyperParameterTuningInstanceConfig>();
        private int? _instanceCount;
        private TrainingInstanceType _instanceType;
        private string _volumeKmsKeyId;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy that determines the order of preference for resources specified in <code>InstanceConfigs</code>
        /// used in hyperparameter optimization.
        /// </para>
        /// </summary>
        public HyperParameterTuningAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceConfigs. 
        /// <para>
        /// A list containing the configuration(s) for one or more resources for processing hyperparameter
        /// jobs. These resources include compute instances and storage volumes to use in model
        /// training jobs launched by hyperparameter tuning jobs. The <code>AllocationStrategy</code>
        /// controls the order in which multiple configurations provided in <code>InstanceConfigs</code>
        /// are used.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you only want to use a single instance configuration inside the <code>HyperParameterTuningResourceConfig</code>
        /// API, do not provide a value for <code>InstanceConfigs</code>. Instead, use <code>InstanceType</code>,
        /// <code>VolumeSizeInGB</code> and <code>InstanceCount</code>. If you use <code>InstanceConfigs</code>,
        /// do not provide values for <code>InstanceType</code>, <code>VolumeSizeInGB</code> or
        /// <code>InstanceCount</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<HyperParameterTuningInstanceConfig> InstanceConfigs
        {
            get { return this._instanceConfigs; }
            set { this._instanceConfigs = value; }
        }

        // Check to see if InstanceConfigs property is set
        internal bool IsSetInstanceConfigs()
        {
            return this._instanceConfigs != null && this._instanceConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of compute instances of type <code>InstanceType</code> to use. For <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/data-parallel-use-api.html">distributed
        /// training</a>, select a value greater than 1.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type used to run hyperparameter optimization tuning jobs. See <a href="https://docs.aws.amazon.com/notebooks-available-instance-types.html">
        /// descriptions of instance types</a> for more information.
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
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// A key used by Amazon Web Services Key Management Service to encrypt data on the storage
        /// volume attached to the compute instances used to run the training job. You can use
        /// either of the following formats to specify a key.
        /// </para>
        ///  
        /// <para>
        /// KMS Key ID:
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS key:
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Some instances use local storage, which use a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ssd-instance-store.html">hardware
        /// module to encrypt</a> storage volumes. If you choose one of these instance types,
        /// you cannot request a <code>VolumeKmsKeyId</code>. For a list of instance types that
        /// use local storage, see <a href="http://aws.amazon.com/releasenotes/host-instance-storage-volumes-table/">instance
        /// store volumes</a>. For more information about Amazon Web Services Key Management Service,
        /// see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-security-kms-permissions.html">KMS
        /// encryption</a> for more information.
        /// </para>
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
        /// The volume size in GB for the storage volume to be used in processing hyperparameter
        /// optimization jobs (optional). These volumes store model artifacts, incremental states
        /// and optionally, scratch space for training algorithms. Do not provide a value for
        /// this parameter if a value for <code>InstanceConfigs</code> is also specified.
        /// </para>
        ///  
        /// <para>
        /// Some instance types have a fixed total local storage size. If you select one of these
        /// instances for training, <code>VolumeSizeInGB</code> cannot be greater than this total
        /// size. For a list of instance types with local instance storage and their sizes, see
        /// <a href="http://aws.amazon.com/releasenotes/host-instance-storage-volumes-table/">instance
        /// store volumes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// SageMaker supports only the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-volume-types.html">General
        /// Purpose SSD (gp2)</a> storage volume type.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
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