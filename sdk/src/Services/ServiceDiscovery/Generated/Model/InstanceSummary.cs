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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
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
namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// A complex type that contains information about the instances that you registered by
    /// using a specified service.
    /// </summary>
    public partial class InstanceSummary
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _createdByAccount;
        private string _id;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contains the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The attributes that are associated with the instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each attribute, the applicable value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Supported attribute keys include the following:
        /// </para>
        ///  <dl> <dt>AWS_ALIAS_DNS_NAME</dt> <dd> 
        /// <para>
        /// For an alias record that routes traffic to an Elastic Load Balancing load balancer,
        /// the DNS name that's associated with the load balancer. 
        /// </para>
        ///  </dd> <dt>AWS_EC2_INSTANCE_ID (HTTP namespaces only)</dt> <dd> 
        /// <para>
        /// The Amazon EC2 instance ID for the instance. When the <c>AWS_EC2_INSTANCE_ID</c> attribute
        /// is specified, then the <c>AWS_INSTANCE_IPV4</c> attribute contains the primary private
        /// IPv4 address.
        /// </para>
        ///  </dd> <dt>AWS_INIT_HEALTH_STATUS</dt> <dd> 
        /// <para>
        /// If the service configuration includes <c>HealthCheckCustomConfig</c>, you can optionally
        /// use <c>AWS_INIT_HEALTH_STATUS</c> to specify the initial status of the custom health
        /// check, <c>HEALTHY</c> or <c>UNHEALTHY</c>. If you don't specify a value for <c>AWS_INIT_HEALTH_STATUS</c>,
        /// the initial status is <c>HEALTHY</c>.
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_CNAME</dt> <dd> 
        /// <para>
        /// For a <c>CNAME</c> record, the domain name that Route 53 returns in response to DNS
        /// queries (for example, <c>example.com</c>).
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_IPV4</dt> <dd> 
        /// <para>
        /// For an <c>A</c> record, the IPv4 address that Route 53 returns in response to DNS
        /// queries (for example, <c>192.0.2.44</c>).
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_IPV6</dt> <dd> 
        /// <para>
        /// For an <c>AAAA</c> record, the IPv6 address that Route 53 returns in response to DNS
        /// queries (for example, <c>2001:0db8:85a3:0000:0000:abcd:0001:2345</c>).
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_PORT</dt> <dd> 
        /// <para>
        /// For an <c>SRV</c> record, the value that Route 53 returns for the port. In addition,
        /// if the service includes <c>HealthCheckConfig</c>, the port on the endpoint that Route 53
        /// sends requests to.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedByAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that registered the instance. If this isn't
        /// your account ID, it's the ID of the account that shared the namespace with your account
        /// or the ID of another account with which the namespace has been shared. For more information
        /// about shared namespaces, see <a href="https://docs.aws.amazon.com/cloud-map/latest/dg/sharing-namespaces.html">Cross-account
        /// Cloud Map namespace sharing</a> in the <i>Cloud Map Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string CreatedByAccount
        {
            get { return this._createdByAccount; }
            set { this._createdByAccount = value; }
        }

        // Check to see if CreatedByAccount property is set
        internal bool IsSetCreatedByAccount()
        {
            return this._createdByAccount != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for an instance that you created by using a specified service.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}