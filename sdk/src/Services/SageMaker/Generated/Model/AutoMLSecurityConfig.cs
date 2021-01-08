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
    /// Security options.
    /// </summary>
    public partial class AutoMLSecurityConfig
    {
        private bool? _enableInterContainerTrafficEncryption;
        private string _volumeKmsKeyId;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// Whether to use traffic encryption between the container layers.
        /// </para>
        /// </summary>
        public bool EnableInterContainerTrafficEncryption
        {
            get { return this._enableInterContainerTrafficEncryption.GetValueOrDefault(); }
            set { this._enableInterContainerTrafficEncryption = value; }
        }

        // Check to see if EnableInterContainerTrafficEncryption property is set
        internal bool IsSetEnableInterContainerTrafficEncryption()
        {
            return this._enableInterContainerTrafficEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The key used to encrypt stored data.
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}