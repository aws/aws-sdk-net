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
    /// Describes the resources, including ML instance types and ML instance count, to use
    /// for transform job.
    /// </summary>
    public partial class TransformResources
    {
        private int? _instanceCount;
        private TransformInstanceType _instanceType;
        private string _transformAmiVersion;
        private string _volumeKmsKeyId;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of ML compute instances to use in the transform job. The default value
        /// is <c>1</c>, and the maximum is <c>100</c>. For distributed transform jobs, specify
        /// a value greater than <c>1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type for the transform job. If you are using built-in algorithms
        /// to transform moderately sized datasets, we recommend using ml.m4.xlarge or <c>ml.m5.large</c>instance
        /// types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformInstanceType InstanceType
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
        /// Gets and sets the property TransformAmiVersion. 
        /// <para>
        /// Specifies an option from a collection of preconfigured Amazon Machine Image (AMI)
        /// images. Each image is configured by Amazon Web Services with a set of software and
        /// driver versions.
        /// </para>
        ///  <dl> <dt>al2-ami-sagemaker-batch-gpu-470</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 470
        /// </para>
        ///  </li> </ul> </dd> <dt>al2-ami-sagemaker-batch-gpu-535</dt> <dd> <ul> <li> 
        /// <para>
        /// Accelerator: GPU
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NVIDIA driver version: 535
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string TransformAmiVersion
        {
            get { return this._transformAmiVersion; }
            set { this._transformAmiVersion = value; }
        }

        // Check to see if TransformAmiVersion property is set
        internal bool IsSetTransformAmiVersion()
        {
            return this._transformAmiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt model data on the storage volume attached to the
        /// ML compute instance(s) that run the batch transform job.
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
        ///  The <c>VolumeKmsKeyId</c> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <c>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</c> 
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

    }
}