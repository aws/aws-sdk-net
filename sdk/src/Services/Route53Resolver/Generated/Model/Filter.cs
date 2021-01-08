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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// For Resolver list operations (<a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverEndpoints.html">ListResolverEndpoints</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html">ListResolverRules</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRuleAssociations.html">ListResolverRuleAssociations</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html">ListResolverQueryLogConfigs</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigAssociations.html">ListResolverQueryLogConfigAssociations</a>),
    /// and <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverDnssecConfigs.html">ListResolverDnssecConfigs</a>),
    /// an optional specification to return a subset of objects.
    /// 
    ///  
    /// <para>
    /// To filter objects, such as Resolver endpoints or Resolver rules, you specify <code>Name</code>
    /// and <code>Values</code>. For example, to list only inbound Resolver endpoints, specify
    /// <code>Direction</code> for <code>Name</code> and specify <code>INBOUND</code> for
    /// <code>Values</code>. 
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that you want to use to filter objects.
        /// </para>
        ///  
        /// <para>
        /// The valid values for <code>Name</code> depend on the action that you're including
        /// the filter in, <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverEndpoints.html">ListResolverEndpoints</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html">ListResolverRules</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRuleAssociations.html">ListResolverRuleAssociations</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html">ListResolverQueryLogConfigs</a>,
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigAssociations.html">ListResolverQueryLogConfigAssociations</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// In early versions of Resolver, values for <code>Name</code> were listed as uppercase,
        /// with underscore (_) delimiters. For example, <code>CreatorRequestId</code> was originally
        /// listed as <code>CREATOR_REQUEST_ID</code>. Uppercase values for <code>Name</code>
        /// are still supported.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>ListResolverEndpoints</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreatorRequestId</code>: The value that you specified when you created the
        /// Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Direction</code>: Whether you want to return inbound or outbound Resolver endpoints.
        /// If you specify <code>DIRECTION</code> for <code>Name</code>, specify <code>INBOUND</code>
        /// or <code>OUTBOUND</code> for <code>Values</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostVpcId</code>: The ID of the VPC that inbound DNS queries pass through on
        /// the way from your network to your VPCs in a region, or the VPC that outbound queries
        /// pass through on the way from your VPCs to your network. In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
        /// request, <code>SubnetId</code> indirectly identifies the VPC. In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>
        /// request, the VPC ID for a Resolver endpoint is returned in the <code>HostVPCId</code>
        /// element. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IpAddressCount</code>: The number of IP addresses that you have associated
        /// with the Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Name</code>: The name of the Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SecurityGroupIds</code>: The IDs of the VPC security groups that you specified
        /// when you created the Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code>: The status of the Resolver endpoint. If you specify <code>Status</code>
        /// for <code>Name</code>, specify one of the following status codes for <code>Values</code>:
        /// <code>CREATING</code>, <code>OPERATIONAL</code>, <code>UPDATING</code>, <code>AUTO_RECOVERING</code>,
        /// <code>ACTION_NEEDED</code>, or <code>DELETING</code>. For more information, see <code>Status</code>
        /// in <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverEndpoint.html">ResolverEndpoint</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverRules</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreatorRequestId</code>: The value that you specified when you created the
        /// Resolver rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DomainName</code>: The domain name for which Resolver is forwarding DNS queries
        /// to your network. In the value that you specify for <code>Values</code>, include a
        /// trailing dot (.) after the domain name. For example, if the domain name is example.com,
        /// specify the following value. Note the "." after <code>com</code>:
        /// </para>
        ///  
        /// <para>
        ///  <code>example.com.</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Name</code>: The name of the Resolver rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResolverEndpointId</code>: The ID of the Resolver endpoint that the Resolver
        /// rule is associated with.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can filter on the Resolver endpoint only for rules that have a value of <code>FORWARD</code>
        /// for <code>RuleType</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>Status</code>: The status of the Resolver rule. If you specify <code>Status</code>
        /// for <code>Name</code>, specify one of the following status codes for <code>Values</code>:
        /// <code>COMPLETE</code>, <code>DELETING</code>, <code>UPDATING</code>, or <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Type</code>: The type of the Resolver rule. If you specify <code>TYPE</code>
        /// for <code>Name</code>, specify <code>FORWARD</code> or <code>SYSTEM</code> for <code>Values</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverRuleAssociations</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Name</code>: The name of the Resolver rule association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResolverRuleId</code>: The ID of the Resolver rule that is associated with
        /// one or more VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code>: The status of the Resolver rule association. If you specify
        /// <code>Status</code> for <code>Name</code>, specify one of the following status codes
        /// for <code>Values</code>: <code>CREATING</code>, <code>COMPLETE</code>, <code>DELETING</code>,
        /// or <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VPCId</code>: The ID of the VPC that the Resolver rule is associated with.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverQueryLogConfigs</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Arn</code>: The ARN for the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AssociationCount</code>: The number of VPCs that are associated with the query
        /// logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code>: The date and time that the query logging configuration
        /// was created, in Unix time format and Coordinated Universal Time (UTC). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreatorRequestId</code>: A unique string that identifies the request that created
        /// the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Destination</code>: The AWS service that you want to forward query logs to.
        /// Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>S3</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CloudWatchLogs</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KinesisFirehose</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>DestinationArn</code>: The ARN of the location that Resolver is sending query
        /// logs to. This value can be the ARN for an S3 bucket, a CloudWatch Logs log group,
        /// or a Kinesis Data Firehose delivery stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Id</code>: The ID of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Name</code>: The name of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OwnerId</code>: The AWS account ID for the account that created the query logging
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ShareStatus</code>: An indication of whether the query logging configuration
        /// is shared with other AWS accounts, or was shared with the current account by another
        /// AWS account. Valid values include: <code>NOT_SHARED</code>, <code>SHARED_WITH_ME</code>,
        /// or <code>SHARED_BY_ME</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code>: The status of the query logging configuration. If you specify
        /// <code>Status</code> for <code>Name</code>, specify the applicable status code for
        /// <code>Values</code>: <code>CREATING</code>, <code>CREATED</code>, <code>DELETING</code>,
        /// or <code>FAILED</code>. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverQueryLogConfig.html#Route53Resolver-Type-route53resolver_ResolverQueryLogConfig-Status">Status</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverQueryLogConfigAssociations</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Name</code> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code>: The date and time that the VPC was associated with the
        /// query logging configuration, in Unix time format and Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Error</code>: If the value of <code>Status</code> is <code>FAILED</code>, specify
        /// the cause: <code>DESTINATION_NOT_FOUND</code> or <code>ACCESS_DENIED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Id</code>: The ID of the query logging association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResolverQueryLogConfigId</code>: The ID of the query logging configuration
        /// that a VPC is associated with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ResourceId</code>: The ID of the Amazon VPC that is associated with the query
        /// logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code>: The status of the query logging association. If you specify
        /// <code>Status</code> for <code>Name</code>, specify the applicable status code for
        /// <code>Values</code>: <code>CREATING</code>, <code>CREATED</code>, <code>DELETING</code>,
        /// or <code>FAILED</code>. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverQueryLogConfigAssociation.html#Route53Resolver-Type-route53resolver_ResolverQueryLogConfigAssociation-Status">Status</a>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// When you're using a <code>List</code> operation and you want the operation to return
        /// a subset of objects, such as Resolver endpoints or Resolver rules, the value of the
        /// parameter that you want to use to filter objects. For example, to list only inbound
        /// Resolver endpoints, specify <code>Direction</code> for <code>Name</code> and specify
        /// <code>INBOUND</code> for <code>Values</code>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}