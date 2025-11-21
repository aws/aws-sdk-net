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
    /// Defines the configuration for attaching an additional Amazon Elastic Block Store (EBS)
    /// volume to each instance of the SageMaker HyperPod cluster instance group. To learn
    /// more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-release-notes.html#sagemaker-hyperpod-release-notes-20240620">SageMaker
    /// HyperPod release notes: June 20, 2024</a>.
    /// </summary>
    public partial class ClusterEbsVolumeConfig
    {
        private bool? _rootVolume;
        private string _volumeKmsKeyId;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property RootVolume. 
        /// <para>
        /// Specifies whether the configuration is for the cluster's root or secondary Amazon
        /// EBS volume. You can specify two <c>ClusterEbsVolumeConfig</c> fields to configure
        /// both the root and secondary volumes. Set the value to <c>True</c> if you'd like to
        /// provide your own customer managed Amazon Web Services KMS key to encrypt the root
        /// volume. When <c>True</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The configuration is applied to the root volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't specify the <c>VolumeSizeInGB</c> field. The size of the root volume is
        /// determined for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify a KMS key ID for <c>VolumeKmsKeyId</c> to encrypt the root volume
        /// with your own KMS key instead of an Amazon Web Services owned KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Otherwise, by default, the value is <c>False</c>, and the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The configuration is applied to the secondary volume, while the root volume is encrypted
        /// with an Amazon Web Services owned key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must specify the <c>VolumeSizeInGB</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can optionally specify the <c>VolumeKmsKeyId</c> to encrypt the secondary volume
        /// with your own KMS key instead of an Amazon Web Services owned KMS key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? RootVolume
        {
            get { return this._rootVolume; }
            set { this._rootVolume = value; }
        }

        // Check to see if RootVolume property is set
        internal bool IsSetRootVolume()
        {
            return this._rootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The ID of a KMS key to encrypt the Amazon EBS volume.
        /// </para>
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
        /// The size in gigabytes (GB) of the additional EBS volume to be attached to the instances
        /// in the SageMaker HyperPod cluster instance group. The additional EBS volume is attached
        /// to each instance within the SageMaker HyperPod cluster instance group and mounted
        /// to <c>/opt/sagemaker</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16384)]
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