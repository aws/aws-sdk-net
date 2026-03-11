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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterComputeNodeGroupInstance operation.
    /// <important> 
    /// <para>
    /// This API action isn't intended for you to use.
    /// 
    ///  </important> 
    /// <para>
    /// PCS uses this API action to register the compute nodes it launches in your account.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class RegisterComputeNodeGroupInstanceRequest : AmazonPCSRequest
    {
        private string _bootstrapId;
        private string _clusterIdentifier;

        /// <summary>
        /// Gets and sets the property BootstrapId. 
        /// <para>
        /// The client-generated token to allow for retries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string BootstrapId
        {
            get { return this._bootstrapId; }
            set { this._bootstrapId = value; }
        }

        // Check to see if BootstrapId property is set
        internal bool IsSetBootstrapId()
        {
            return this._bootstrapId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The name or ID of the cluster to register the compute node group instance in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

    }
}