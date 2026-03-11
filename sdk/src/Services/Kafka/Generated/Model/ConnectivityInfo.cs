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
    /// Information about the broker access configuration.
    /// </summary>
    public partial class ConnectivityInfo
    {
        private NetworkType _networkType;
        private PublicAccess _publicAccess;
        private VpcConnectivity _vpcConnectivity;

        /// <summary>
        /// Gets and sets the property NetworkType.             
        /// <para>
        /// The network type of the cluster, which is IPv4 or DUAL. The DUAL network type uses
        /// both IPv4 and IPv6 addresses for your cluster and its resources.
        /// </para>
        /// 
        /// <para>
        /// By default, a cluster uses the IPv4 network type.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccess.             
        /// <para>
        /// Public access control for brokers.
        /// </para>
        /// </summary>
        public PublicAccess PublicAccess
        {
            get { return this._publicAccess; }
            set { this._publicAccess = value; }
        }

        // Check to see if PublicAccess property is set
        internal bool IsSetPublicAccess()
        {
            return this._publicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectivity.             
        /// <para>
        /// VPC connectivity access control for brokers.
        /// </para>
        /// </summary>
        public VpcConnectivity VpcConnectivity
        {
            get { return this._vpcConnectivity; }
            set { this._vpcConnectivity = value; }
        }

        // Check to see if VpcConnectivity property is set
        internal bool IsSetVpcConnectivity()
        {
            return this._vpcConnectivity != null;
        }

    }
}