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
    /// Defines the configuration for managed tier checkpointing in a HyperPod cluster. Managed
    /// tier checkpointing uses multiple storage tiers, including cluster CPU memory, to provide
    /// faster checkpoint operations and improved fault tolerance for large-scale model training.
    /// The system automatically saves checkpoints at high frequency to memory and periodically
    /// persists them to durable storage, like Amazon S3.
    /// </summary>
    public partial class ClusterTieredStorageConfig
    {
        private int? _instanceMemoryAllocationPercentage;
        private ClusterConfigMode _mode;

        /// <summary>
        /// Gets and sets the property InstanceMemoryAllocationPercentage. 
        /// <para>
        /// The percentage (int) of cluster memory to allocate for checkpointing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? InstanceMemoryAllocationPercentage
        {
            get { return this._instanceMemoryAllocationPercentage; }
            set { this._instanceMemoryAllocationPercentage = value; }
        }

        // Check to see if InstanceMemoryAllocationPercentage property is set
        internal bool IsSetInstanceMemoryAllocationPercentage()
        {
            return this._instanceMemoryAllocationPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies whether managed tier checkpointing is enabled or disabled for the HyperPod
        /// cluster. When set to <c>Enable</c>, the system installs a memory management daemon
        /// that provides disaggregated memory as a service for checkpoint storage. When set to
        /// <c>Disable</c>, the feature is turned off and the memory management daemon is removed
        /// from the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterConfigMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}