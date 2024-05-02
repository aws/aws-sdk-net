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
    /// Networking options for a job, such as network traffic encryption between containers,
    /// whether to allow inbound and outbound network calls to and from containers, and the
    /// VPC subnets and security groups to use for VPC-enabled jobs.
    /// </summary>
    public partial class NetworkConfig
    {
        private bool? _enableInterContainerTrafficEncryption;
        private bool? _enableNetworkIsolation;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property EnableInterContainerTrafficEncryption. 
        /// <para>
        /// Whether to encrypt all communications between distributed processing jobs. Choose
        /// <c>True</c> to encrypt communications. Encryption provides greater security for distributed
        /// processing jobs, but the processing might take longer.
        /// </para>
        /// </summary>
        public bool? EnableInterContainerTrafficEncryption
        {
            get { return this._enableInterContainerTrafficEncryption; }
            set { this._enableInterContainerTrafficEncryption = value; }
        }

        // Check to see if EnableInterContainerTrafficEncryption property is set
        internal bool IsSetEnableInterContainerTrafficEncryption()
        {
            return this._enableInterContainerTrafficEncryption.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableNetworkIsolation. 
        /// <para>
        /// Whether to allow inbound and outbound network calls to and from the containers used
        /// for the processing job.
        /// </para>
        /// </summary>
        public bool? EnableNetworkIsolation
        {
            get { return this._enableNetworkIsolation; }
            set { this._enableNetworkIsolation = value; }
        }

        // Check to see if EnableNetworkIsolation property is set
        internal bool IsSetEnableNetworkIsolation()
        {
            return this._enableNetworkIsolation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
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