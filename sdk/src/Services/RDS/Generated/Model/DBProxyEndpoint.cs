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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The data structure representing an endpoint associated with a DB proxy. RDS automatically
    /// creates one endpoint for each DB proxy. For Aurora DB clusters, you can associate
    /// additional endpoints with the same DB proxy. These endpoints can be read/write or
    /// read-only. They can also reside in different VPCs than the associated DB proxy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <c>DescribeDBProxyEndpoints</c>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DBProxyEndpoint
    {
        private DateTime? _createdDate;
        private string _dbProxyEndpointArn;
        private string _dbProxyEndpointName;
        private string _dbProxyName;
        private string _endpoint;
        private EndpointNetworkType _endpointNetworkType;
        private bool? _isDefault;
        private DBProxyEndpointStatus _status;
        private DBProxyEndpointTargetRole _targetRole;
        private string _vpcId;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _vpcSubnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the DB proxy endpoint was first created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBProxyEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB proxy endpoint.
        /// </para>
        /// </summary>
        public string DBProxyEndpointArn
        {
            get { return this._dbProxyEndpointArn; }
            set { this._dbProxyEndpointArn = value; }
        }

        // Check to see if DBProxyEndpointArn property is set
        internal bool IsSetDBProxyEndpointArn()
        {
            return this._dbProxyEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBProxyEndpointName. 
        /// <para>
        /// The name for the DB proxy endpoint. An identifier must begin with a letter and must
        /// contain only ASCII letters, digits, and hyphens; it can't end with a hyphen or contain
        /// two consecutive hyphens.
        /// </para>
        /// </summary>
        public string DBProxyEndpointName
        {
            get { return this._dbProxyEndpointName; }
            set { this._dbProxyEndpointName = value; }
        }

        // Check to see if DBProxyEndpointName property is set
        internal bool IsSetDBProxyEndpointName()
        {
            return this._dbProxyEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier for the DB proxy that is associated with this DB proxy endpoint.
        /// </para>
        /// </summary>
        public string DBProxyName
        {
            get { return this._dbProxyName; }
            set { this._dbProxyName = value; }
        }

        // Check to see if DBProxyName property is set
        internal bool IsSetDBProxyName()
        {
            return this._dbProxyName != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that you can use to connect to the DB proxy. You include the endpoint
        /// value in the connection string for a database client application.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointNetworkType. 
        /// <para>
        /// The network type of the DB proxy endpoint. The network type determines the IP version
        /// that the proxy endpoint supports.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IPV4</c> - The proxy endpoint supports IPv4 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IPV6</c> - The proxy endpoint supports IPv6 only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DUAL</c> - The proxy endpoint supports both IPv4 and IPv6.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndpointNetworkType EndpointNetworkType
        {
            get { return this._endpointNetworkType; }
            set { this._endpointNetworkType = value; }
        }

        // Check to see if EndpointNetworkType property is set
        internal bool IsSetEndpointNetworkType()
        {
            return this._endpointNetworkType != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this endpoint is the default endpoint for the associated DB proxy.
        /// Default DB proxy endpoints always have read/write capability. Other endpoints that
        /// you associate with the DB proxy can be either read/write or read-only.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this DB proxy endpoint. A status of <c>available</c> means the
        /// endpoint is ready to handle requests. Other values indicate that you must wait for
        /// the endpoint to be ready, or take some action to resolve an issue.
        /// </para>
        /// </summary>
        public DBProxyEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRole. 
        /// <para>
        /// A value that indicates whether the DB proxy endpoint can be used for read/write or
        /// read-only operations.
        /// </para>
        /// </summary>
        public DBProxyEndpointTargetRole TargetRole
        {
            get { return this._targetRole; }
            set { this._targetRole = value; }
        }

        // Check to see if TargetRole property is set
        internal bool IsSetTargetRole()
        {
            return this._targetRole != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Provides the VPC ID of the DB proxy endpoint.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// Provides a list of VPC security groups that the DB proxy endpoint belongs to.
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

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// The EC2 subnet IDs for the DB proxy endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSubnetIds
        {
            get { return this._vpcSubnetIds; }
            set { this._vpcSubnetIds = value; }
        }

        // Check to see if VpcSubnetIds property is set
        internal bool IsSetVpcSubnetIds()
        {
            return this._vpcSubnetIds != null && (this._vpcSubnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}