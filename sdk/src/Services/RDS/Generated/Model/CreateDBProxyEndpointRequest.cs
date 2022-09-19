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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBProxyEndpoint operation.
    /// Creates a <code>DBProxyEndpoint</code>. Only applies to proxies that are associated
    /// with Aurora DB clusters. You can use DB proxy endpoints to specify read/write or read-only
    /// access to the DB cluster. You can also use DB proxy endpoints to access a DB proxy
    /// through a different VPC than the proxy's default VPC.
    /// </summary>
    public partial class CreateDBProxyEndpointRequest : AmazonRDSRequest
    {
        private string _dbProxyEndpointName;
        private string _dbProxyName;
        private List<Tag> _tags = new List<Tag>();
        private DBProxyEndpointTargetRole _targetRole;
        private List<string> _vpcSecurityGroupIds = new List<string>();
        private List<string> _vpcSubnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DBProxyEndpointName. 
        /// <para>
        /// The name of the DB proxy endpoint to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// The name of the DB proxy associated with the DB proxy endpoint that you create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetRole. 
        /// <para>
        /// A value that indicates whether the DB proxy endpoint can be used for read/write or
        /// read-only operations. The default is <code>READ_WRITE</code>. The only role that proxies
        /// for RDS for Microsoft SQL Server support is <code>READ_WRITE</code>.
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
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs for the DB proxy endpoint that you create. You can specify
        /// a different set of security group IDs than for the original DB proxy. The default
        /// is the default security group for the VPC.
        /// </para>
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && this._vpcSecurityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcSubnetIds. 
        /// <para>
        /// The VPC subnet IDs for the DB proxy endpoint that you create. You can specify a different
        /// set of subnet IDs than for the original DB proxy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VpcSubnetIds
        {
            get { return this._vpcSubnetIds; }
            set { this._vpcSubnetIds = value; }
        }

        // Check to see if VpcSubnetIds property is set
        internal bool IsSetVpcSubnetIds()
        {
            return this._vpcSubnetIds != null && this._vpcSubnetIds.Count > 0; 
        }

    }
}