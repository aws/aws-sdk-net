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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the RDS options for a Verified Access endpoint.
    /// </summary>
    public partial class VerifiedAccessEndpointRdsOptions
    {
        private int? _port;
        private VerifiedAccessEndpointProtocol _protocol;
        private string _rdsDbClusterArn;
        private string _rdsDbInstanceArn;
        private string _rdsDbProxyArn;
        private string _rdsEndpoint;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public VerifiedAccessEndpointProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbClusterArn. 
        /// <para>
        /// The ARN of the DB cluster.
        /// </para>
        /// </summary>
        public string RdsDbClusterArn
        {
            get { return this._rdsDbClusterArn; }
            set { this._rdsDbClusterArn = value; }
        }

        // Check to see if RdsDbClusterArn property is set
        internal bool IsSetRdsDbClusterArn()
        {
            return this._rdsDbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbInstanceArn. 
        /// <para>
        /// The ARN of the RDS instance.
        /// </para>
        /// </summary>
        public string RdsDbInstanceArn
        {
            get { return this._rdsDbInstanceArn; }
            set { this._rdsDbInstanceArn = value; }
        }

        // Check to see if RdsDbInstanceArn property is set
        internal bool IsSetRdsDbInstanceArn()
        {
            return this._rdsDbInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RdsDbProxyArn. 
        /// <para>
        /// The ARN of the RDS proxy.
        /// </para>
        /// </summary>
        public string RdsDbProxyArn
        {
            get { return this._rdsDbProxyArn; }
            set { this._rdsDbProxyArn = value; }
        }

        // Check to see if RdsDbProxyArn property is set
        internal bool IsSetRdsDbProxyArn()
        {
            return this._rdsDbProxyArn != null;
        }

        /// <summary>
        /// Gets and sets the property RdsEndpoint. 
        /// <para>
        /// The RDS endpoint.
        /// </para>
        /// </summary>
        public string RdsEndpoint
        {
            get { return this._rdsEndpoint; }
            set { this._rdsEndpoint = value; }
        }

        // Check to see if RdsEndpoint property is set
        internal bool IsSetRdsEndpoint()
        {
            return this._rdsEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The IDs of the subnets.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}