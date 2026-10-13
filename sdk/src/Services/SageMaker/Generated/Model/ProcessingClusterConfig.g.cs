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
    /// Configuration for the cluster used to run a processing job.
    /// </summary>
    public partial class ProcessingClusterConfig
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of ML compute instances to use in the processing job. For distributed processing
        /// jobs, specify a value greater than 1. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstancePreferences. 
        /// <para>
        /// An ordered list of ML compute instance types for the processing job, in priority order.
        /// Amazon SageMaker launches the job on the first instance type in the list that has
        /// available capacity. If capacity is insufficient, Amazon SageMaker evaluates the next
        /// instance type in the list. Exactly one instance type is selected for the job.
        /// </para>
        ///  
        /// <para>
        ///  <c>InstancePreferences</c> is mutually exclusive with <c>InstanceType</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<ProcessingInstancePreference> InstancePreferences { get; set; } = AWSConfigs.InitializeCollections ? new List<ProcessingInstancePreference>() : null;

        /// <summary>
        /// Checks to see if the InstancePreferences property is set.
        /// </summary>
        internal bool IsSetInstancePreferences() => this.InstancePreferences != null && (this.InstancePreferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type for the processing job.
        /// </para>
        /// </summary>
        public ProcessingInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property SelectedInstanceCount. 
        /// <para>
        /// The number of instances of <c>SelectedInstanceType</c> that the job launched with.
        /// The job is billed for this instance type and count. Returned by <c>DescribeProcessingJob</c>
        /// after an instance type is selected. This field is read-only and isn't accepted in
        /// <c>CreateProcessingJob</c> requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? SelectedInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the SelectedInstanceCount property is set.
        /// </summary>
        internal bool IsSetSelectedInstanceCount() => this.SelectedInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property SelectedInstanceType. 
        /// <para>
        /// The instance type that Amazon SageMaker selected for the job from <c>InstancePreferences</c>.
        /// Returned by <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeProcessingJob.html">DescribeProcessingJob</a>
        /// </c> after an instance type is selected. This field is read-only and isn't accepted
        /// in <c>CreateProcessingJob</c> requests.
        /// </para>
        /// </summary>
        public ProcessingInstanceType SelectedInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the SelectedInstanceType property is set.
        /// </summary>
        internal bool IsSetSelectedInstanceType() => this.SelectedInstanceType != null;

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance(s) that run the processing job. 
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
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string VolumeKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeKmsKeyId property is set.
        /// </summary>
        internal bool IsSetVolumeKmsKeyId() => this.VolumeKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size of the ML storage volume in gigabytes that you want to provision. You must
        /// specify sufficient ML storage for your scenario.
        /// </para>
        ///  <note> 
        /// <para>
        /// Certain Nitro-based instances include local storage with a fixed total size, dependent
        /// on the instance type. When using these instances for processing, Amazon SageMaker
        /// mounts the local instance storage instead of Amazon EBS gp2 storage. You can't request
        /// a <c>VolumeSizeInGB</c> greater than the total size of the local instance storage.
        /// </para>
        ///  
        /// <para>
        /// For a list of instance types that support local instance storage, including the total
        /// size per instance type, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#instance-store-volumes">Instance
        /// Store Volumes</a>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16384)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
