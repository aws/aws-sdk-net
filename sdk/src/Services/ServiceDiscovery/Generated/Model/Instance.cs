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
    /// A complex type that contains information about an instance that Cloud Map creates
    /// when you submit a <c>RegisterInstance</c> request.
    /// </summary>
    public partial class Instance
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _createdByAccount;
        private string _creatorRequestId;
        private string _id;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A string map that contains the following information for the service that you specify
        /// in <c>ServiceId</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The attributes that apply to the records that are defined in the service. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each attribute, the applicable value.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Do not include sensitive information in the attributes if the namespace is discoverable
        /// by public DNS queries.
        /// </para>
        ///  </note> 
        /// <para>
        /// Supported attribute keys include the following:
        /// </para>
        ///  <dl> <dt>AWS_ALIAS_DNS_NAME</dt> <dd> 
        /// <para>
        /// If you want Cloud Map to create a Route 53 alias record that routes traffic to an
        /// Elastic Load Balancing load balancer, specify the DNS name that's associated with
        /// the load balancer. For information about how to get the DNS name, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_AliasTarget.html#Route53-Type-AliasTarget-DNSName">AliasTarget-&gt;DNSName</a>
        /// in the <i>Route 53 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The configuration for the service that's specified by <c>ServiceId</c> must include
        /// settings for an <c>A</c> record, an <c>AAAA</c> record, or both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In the service that's specified by <c>ServiceId</c>, the value of <c>RoutingPolicy</c>
        /// must be <c>WEIGHTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the service that's specified by <c>ServiceId</c> includes <c>HealthCheckConfig</c>
        /// settings, Cloud Map creates the health check, but it won't associate the health check
        /// with the alias record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Auto naming currently doesn't support creating alias records that route traffic to
        /// Amazon Web Services resources other than ELB load balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a value for <c>AWS_ALIAS_DNS_NAME</c>, don't specify values for any
        /// of the <c>AWS_INSTANCE</c> attributes.
        /// </para>
        ///  </li> </ul> </dd> <dt>AWS_EC2_INSTANCE_ID</dt> <dd> 
        /// <para>
        ///  <i>HTTP namespaces only.</i> The Amazon EC2 instance ID for the instance. The <c>AWS_INSTANCE_IPV4</c>
        /// attribute contains the primary private IPv4 address.
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
        /// If the service configuration includes a <c>CNAME</c> record, the domain name that
        /// you want Route 53 to return in response to DNS queries (for example, <c>example.com</c>).
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <c>ServiceId</c> includes settings
        /// for an <c>CNAME</c> record.
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_IPV4</dt> <dd> 
        /// <para>
        /// If the service configuration includes an <c>A</c> record, the IPv4 address that you
        /// want Route 53 to return in response to DNS queries (for example, <c>192.0.2.44</c>).
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <c>ServiceId</c> includes settings
        /// for an <c>A</c> record. If the service includes settings for an <c>SRV</c> record,
        /// you must specify a value for <c>AWS_INSTANCE_IPV4</c>, <c>AWS_INSTANCE_IPV6</c>, or
        /// both.
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_IPV6</dt> <dd> 
        /// <para>
        /// If the service configuration includes an <c>AAAA</c> record, the IPv6 address that
        /// you want Route 53 to return in response to DNS queries (for example, <c>2001:0db8:85a3:0000:0000:abcd:0001:2345</c>).
        /// </para>
        ///  
        /// <para>
        /// This value is required if the service specified by <c>ServiceId</c> includes settings
        /// for an <c>AAAA</c> record. If the service includes settings for an <c>SRV</c> record,
        /// you must specify a value for <c>AWS_INSTANCE_IPV4</c>, <c>AWS_INSTANCE_IPV6</c>, or
        /// both.
        /// </para>
        ///  </dd> <dt>AWS_INSTANCE_PORT</dt> <dd> 
        /// <para>
        /// If the service includes an <c>SRV</c> record, the value that you want Route 53 to
        /// return for the port.
        /// </para>
        ///  
        /// <para>
        /// If the service includes <c>HealthCheckConfig</c>, the port on the endpoint that you
        /// want Route 53 to send requests to. 
        /// </para>
        ///  
        /// <para>
        /// This value is required if you specified settings for an <c>SRV</c> record or a Route 53
        /// health check when you created the service.
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
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed <c>RegisterInstance</c>
        /// requests to be retried without the risk of executing the operation twice. You must
        /// use a unique <c>CreatorRequestId</c> string every time you submit a <c>RegisterInstance</c>
        /// request if you're registering additional instances for the same namespace and service.
        /// <c>CreatorRequestId</c> can be any unique string (for example, a date/time stamp).
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier that you want to associate with the instance. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the service that's specified by <c>ServiceId</c> includes settings for an <c>SRV</c>
        /// record, the value of <c>InstanceId</c> is automatically included as part of the value
        /// for the <c>SRV</c> record. For more information, see <a href="https://docs.aws.amazon.com/cloud-map/latest/api/API_DnsRecord.html#cloudmap-Type-DnsRecord-Type">DnsRecord
        /// &gt; Type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use this value to update an existing instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To register a new instance, you must specify a value that's unique among instances
        /// that you register by using the same service. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify an existing <c>InstanceId</c> and <c>ServiceId</c>, Cloud Map updates
        /// the existing DNS records. If there's also an existing health check, Cloud Map deletes
        /// the old health check and creates a new one. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The health check isn't deleted immediately, so it will still appear for a while if
        /// you submit a <c>ListHealthChecks</c> request, for example.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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