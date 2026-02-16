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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a serverless cluster operation.
    /// </summary>
    public partial class ClusterOperationV2Serverless
    {
        private ServerlessConnectivityInfo _sourceClusterInfo;
        private ServerlessConnectivityInfo _targetClusterInfo;
        private VpcConnectionInfoServerless _vpcConnectionInfo;

        /// <summary>
        /// Gets and sets the property SourceClusterInfo.             
        /// <para>
        /// Describes the cluster's attributes before any updates are applied. For example, networkType,
        /// which can be either IPv4 or DUAL.
        /// </para>
        /// </summary>
        public ServerlessConnectivityInfo SourceClusterInfo
        {
            get { return this._sourceClusterInfo; }
            set { this._sourceClusterInfo = value; }
        }

        // Check to see if SourceClusterInfo property is set
        internal bool IsSetSourceClusterInfo()
        {
            return this._sourceClusterInfo != null;
        }

        /// <summary>
        /// Gets and sets the property TargetClusterInfo.              
        /// <para>
        /// Describes the cluster's attributes after any updates are applied. For example, networkType,
        /// which can be either IPv4 or DUAL.
        /// </para>
        /// </summary>
        public ServerlessConnectivityInfo TargetClusterInfo
        {
            get { return this._targetClusterInfo; }
            set { this._targetClusterInfo = value; }
        }

        // Check to see if TargetClusterInfo property is set
        internal bool IsSetTargetClusterInfo()
        {
            return this._targetClusterInfo != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionInfo.             
        /// <para>
        /// Description of the VPC connection for CreateVpcConnection and DeleteVpcConnection
        /// operations.
        /// </para>
        /// </summary>
        public VpcConnectionInfoServerless VpcConnectionInfo
        {
            get { return this._vpcConnectionInfo; }
            set { this._vpcConnectionInfo = value; }
        }

        // Check to see if VpcConnectionInfo property is set
        internal bool IsSetVpcConnectionInfo()
        {
            return this._vpcConnectionInfo != null;
        }

    }
}