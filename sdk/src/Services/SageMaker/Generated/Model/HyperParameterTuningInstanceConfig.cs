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
    /// The configuration for hyperparameter tuning resources for use in training jobs launched
    /// by the tuning job. These resources include compute instances and storage volumes.
    /// Specify one or more compute instance configurations and allocation strategies to select
    /// resources (optional).
    /// </summary>
    public partial class HyperParameterTuningInstanceConfig
    {
        private int? _instanceCount;
        private TrainingInstanceType _instanceType;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances of the type specified by <code>InstanceType</code>. Choose
        /// an instance count larger than 1 for distributed training algorithms. See <a href="https://docs.aws.amazon.com/data-parallel-use-api.html">SageMaker
        /// distributed training jobs</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
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
        /// The instance type used for processing of hyperparameter optimization jobs. Choose
        /// from general purpose (no GPUs) instance types: ml.m5.xlarge, ml.m5.2xlarge, and ml.m5.4xlarge
        /// or compute optimized (no GPUs) instance types: ml.c5.xlarge and ml.c5.2xlarge. For
        /// more information about instance types, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/notebooks-available-instance-types.html">instance
        /// type descriptions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The volume size in GB of the data to be processed for hyperparameter optimization
        /// (optional).
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