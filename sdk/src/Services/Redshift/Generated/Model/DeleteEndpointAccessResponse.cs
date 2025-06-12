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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a Redshift-managed VPC endpoint.
    /// </summary>
    public partial class DeleteEndpointAccessResponse : AmazonWebServiceResponse
    {
        private string _address;
        private string _clusterIdentifier;
        private DateTime? _endpointCreateTime;
        private string _endpointName;
        private string _endpointStatus;
        private int? _port;
        private string _resourceOwner;
        private string _subnetGroupName;
        private VpcEndpoint _vpcEndpoint;
        private List<VpcSecurityGroupMembership> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<VpcSecurityGroupMembership>() : null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The DNS address of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier of the cluster associated with the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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

        /// <summary>
        /// Gets and sets the property EndpointCreateTime. 
        /// <para>
        /// The time (UTC) that the endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? EndpointCreateTime
        {
            get { return this._endpointCreateTime; }
            set { this._endpointCreateTime = value; }
        }

        // Check to see if EndpointCreateTime property is set
        internal bool IsSetEndpointCreateTime()
        {
            return this._endpointCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number on which the cluster accepts incoming connections.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ResourceOwner
        {
            get { return this._resourceOwner; }
            set { this._resourceOwner = value; }
        }

        // Check to see if ResourceOwner property is set
        internal bool IsSetResourceOwner()
        {
            return this._resourceOwner != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The subnet group name where Amazon Redshift chooses to deploy the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string SubnetGroupName
        {
            get { return this._subnetGroupName; }
            set { this._subnetGroupName = value; }
        }

        // Check to see if SubnetGroupName property is set
        internal bool IsSetSubnetGroupName()
        {
            return this._subnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpoint.
        /// </summary>
        public VpcEndpoint VpcEndpoint
        {
            get { return this._vpcEndpoint; }
            set { this._vpcEndpoint = value; }
        }

        // Check to see if VpcEndpoint property is set
        internal bool IsSetVpcEndpoint()
        {
            return this._vpcEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// The security groups associated with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcSecurityGroupMembership> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}