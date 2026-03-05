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
    /// Defines the configuration for attaching an Amazon FSx for Lustre file system to instances
    /// in a SageMaker HyperPod cluster instance group.
    /// </summary>
    public partial class ClusterFsxLustreConfig
    {
        private string _dnsName;
        private string _mountName;
        private string _mountPath;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=275)]
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property MountName. 
        /// <para>
        /// The mount name of the Amazon FSx for Lustre file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8)]
        public string MountName
        {
            get { return this._mountName; }
            set { this._mountName = value; }
        }

        // Check to see if MountName property is set
        internal bool IsSetMountName()
        {
            return this._mountName != null;
        }

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The local path where the Amazon FSx for Lustre file system is mounted on instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string MountPath
        {
            get { return this._mountPath; }
            set { this._mountPath = value; }
        }

        // Check to see if MountPath property is set
        internal bool IsSetMountPath()
        {
            return this._mountPath != null;
        }

    }
}