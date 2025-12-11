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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCapability operation.
    /// Returns detailed information about a specific managed capability in your Amazon EKS
    /// cluster, including its current status, configuration, health information, and any
    /// issues that may be affecting its operation.
    /// </summary>
    public partial class DescribeCapabilityRequest : AmazonEKSRequest
    {
        private string _capabilityName;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property CapabilityName. 
        /// <para>
        /// The name of the capability to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapabilityName
        {
            get { return this._capabilityName; }
            set { this._capabilityName = value; }
        }

        // Check to see if CapabilityName property is set
        internal bool IsSetCapabilityName()
        {
            return this._capabilityName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that contains the capability you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

    }
}