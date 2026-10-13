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
    /// The configuration for hyperparameter tuning resources for use in training jobs launched
    /// by the tuning job. These resources include compute instances and storage volumes.
    /// Specify one or more compute instance configurations and allocation strategies to select
    /// resources (optional).
    /// </summary>
    public partial class HyperParameterTuningInstanceConfig
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances of the type specified by <c>InstanceType</c>. Choose an instance
        /// count larger than 1 for distributed training algorithms. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/data-parallel-use-api.html">Step
        /// 2: Launch a SageMaker Distributed Training Job Using the SageMaker Python SDK</a>
        /// for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

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
        [AWSProperty(Required = true)]
        public TrainingInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The volume size in GB of the data to be processed for hyperparameter optimization
        /// (optional).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
