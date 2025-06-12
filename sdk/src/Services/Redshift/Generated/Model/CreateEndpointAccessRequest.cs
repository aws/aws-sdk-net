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
    /// Container for the parameters to the CreateEndpointAccess operation.
    /// Creates a Redshift-managed VPC endpoint.
    /// </summary>
    public partial class CreateEndpointAccessRequest : AmazonRedshiftRequest
    {
        private string _clusterIdentifier;
        private string _endpointName;
        private string _resourceOwner;
        private string _subnetGroupName;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier of the cluster to access.
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
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The Redshift-managed VPC endpoint name.
        /// </para>
        ///  
        /// <para>
        /// An endpoint name must contain 1-30 characters. Valid characters are A-Z, a-z, 0-9,
        /// and hyphen(-). The first character must be a letter. The name can't contain two consecutive
        /// hyphens or end with a hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the cluster. This is only required
        /// if the cluster is in another Amazon Web Services account.
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
        /// The subnet group from which Amazon Redshift chooses the subnet to deploy the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The security group that defines the ports, protocols, and sources for inbound traffic
        /// that you are authorizing into your endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}