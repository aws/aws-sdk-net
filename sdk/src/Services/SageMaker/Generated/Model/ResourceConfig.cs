/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the resources, including ML compute instances and ML storage volumes, to
    /// use for model training.
    /// </summary>
    public partial class ResourceConfig
    {
        private int? _instanceCount;
        private TrainingInstanceType _instanceType;
        private string _volumeKmsKeyId;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of ML compute instances to use. For distributed training, provide a value
        /// greater than 1. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a AWS Key Management Service key that Amazon SageMaker
        /// uses to encrypt data on the storage volume attached to the ML compute instance(s)
        /// that run the training job.
        /// </para>
        /// </summary>
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
        /// You must specify sufficient ML storage for your scenario. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Amazon SageMaker supports only the General Purpose SSD (gp2) ML storage volume type.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
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