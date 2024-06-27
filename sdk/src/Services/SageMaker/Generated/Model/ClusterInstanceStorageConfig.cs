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
    /// Defines the configuration for attaching additional storage to the instances in the
    /// SageMaker HyperPod cluster instance group. To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-release-notes.html#sagemaker-hyperpod-release-notes-20240620">SageMaker
    /// HyperPod release notes: June 20, 2024</a>.
    /// </summary>
    public partial class ClusterInstanceStorageConfig
    {
        private ClusterEbsVolumeConfig _ebsVolumeConfig;

        /// <summary>
        /// Gets and sets the property EbsVolumeConfig. 
        /// <para>
        /// Defines the configuration for attaching additional Amazon Elastic Block Store (EBS)
        /// volumes to the instances in the SageMaker HyperPod cluster instance group. The additional
        /// EBS volume is attached to each instance within the SageMaker HyperPod cluster instance
        /// group and mounted to <c>/opt/sagemaker</c>.
        /// </para>
        /// </summary>
        public ClusterEbsVolumeConfig EbsVolumeConfig
        {
            get { return this._ebsVolumeConfig; }
            set { this._ebsVolumeConfig = value; }
        }

        // Check to see if EbsVolumeConfig property is set
        internal bool IsSetEbsVolumeConfig()
        {
            return this._ebsVolumeConfig != null;
        }

    }
}