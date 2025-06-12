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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// To filter objects, such as Resolver endpoints or Resolver rules, you specify <c>Name</c>
    /// and <c>Values</c>. For example, to list only inbound Resolver endpoints, specify <c>Direction</c>
    /// for <c>Name</c> and specify <c>INBOUND</c> for <c>Values</c>. 
    /// </para>
    /// </summary>
    public partial class Filter
    {
        private string _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter that you want to use to filter objects.
        /// </para>
        ///  
        /// <para>
        /// The valid values for <c>Name</c> depend on the action that you're including the filter
        /// in, <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverEndpoints.html">ListResolverEndpoints</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRules.html">ListResolverRules</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverRuleAssociations.html">ListResolverRuleAssociations</a>,
        /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html">ListResolverQueryLogConfigs</a>,
        /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigAssociations.html">ListResolverQueryLogConfigAssociations</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// In early versions of Resolver, values for <c>Name</c> were listed as uppercase, with
        /// underscore (_) delimiters. For example, <c>CreatorRequestId</c> was originally listed
        /// as <c>CREATOR_REQUEST_ID</c>. Uppercase values for <c>Name</c> are still supported.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>ListResolverEndpoints</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreatorRequestId</c>: The value that you specified when you created the Resolver
        /// endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Direction</c>: Whether you want to return inbound or outbound Resolver endpoints.
        /// If you specify <c>DIRECTION</c> for <c>Name</c>, specify <c>INBOUND</c> or <c>OUTBOUND</c>
        /// for <c>Values</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HostVPCId</c>: The ID of the VPC that inbound DNS queries pass through on the
        /// way from your network to your VPCs in a region, or the VPC that outbound queries pass
        /// through on the way from your VPCs to your network. In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
        /// request, <c>SubnetId</c> indirectly identifies the VPC. In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>
        /// request, the VPC ID for a Resolver endpoint is returned in the <c>HostVPCId</c> element.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IpAddressCount</c>: The number of IP addresses that you have associated with the
        /// Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c>: The name of the Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SecurityGroupIds</c>: The IDs of the VPC security groups that you specified when
        /// you created the Resolver endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c>: The status of the Resolver endpoint. If you specify <c>Status</c>
        /// for <c>Name</c>, specify one of the following status codes for <c>Values</c>: <c>CREATING</c>,
        /// <c>OPERATIONAL</c>, <c>UPDATING</c>, <c>AUTO_RECOVERING</c>, <c>ACTION_NEEDED</c>,
        /// or <c>DELETING</c>. For more information, see <c>Status</c> in <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverEndpoint.html">ResolverEndpoint</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverRules</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreatorRequestId</c>: The value that you specified when you created the Resolver
        /// rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DomainName</c>: The domain name for which Resolver is forwarding DNS queries to
        /// your network. In the value that you specify for <c>Values</c>, include a trailing
        /// dot (.) after the domain name. For example, if the domain name is example.com, specify
        /// the following value. Note the "." after <c>com</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>example.com.</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c>: The name of the Resolver rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResolverEndpointId</c>: The ID of the Resolver endpoint that the Resolver rule
        /// is associated with.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can filter on the Resolver endpoint only for rules that have a value of <c>FORWARD</c>
        /// for <c>RuleType</c>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>Status</c>: The status of the Resolver rule. If you specify <c>Status</c> for
        /// <c>Name</c>, specify one of the following status codes for <c>Values</c>: <c>COMPLETE</c>,
        /// <c>DELETING</c>, <c>UPDATING</c>, or <c>FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Type</c>: The type of the Resolver rule. If you specify <c>TYPE</c> for <c>Name</c>,
        /// specify <c>FORWARD</c> or <c>SYSTEM</c> for <c>Values</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverRuleAssociations</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Name</c>: The name of the Resolver rule association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResolverRuleId</c>: The ID of the Resolver rule that is associated with one or
        /// more VPCs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c>: The status of the Resolver rule association. If you specify <c>Status</c>
        /// for <c>Name</c>, specify one of the following status codes for <c>Values</c>: <c>CREATING</c>,
        /// <c>COMPLETE</c>, <c>DELETING</c>, or <c>FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPCId</c>: The ID of the VPC that the Resolver rule is associated with.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverQueryLogConfigs</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Arn</c>: The ARN for the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AssociationCount</c>: The number of VPCs that are associated with the query logging
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreationTime</c>: The date and time that the query logging configuration was created,
        /// in Unix time format and Coordinated Universal Time (UTC). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreatorRequestId</c>: A unique string that identifies the request that created
        /// the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Destination</c>: The Amazon Web Services service that you want to forward query
        /// logs to. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>S3</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CloudWatchLogs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KinesisFirehose</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DestinationArn</c>: The ARN of the location that Resolver is sending query logs
        /// to. This value can be the ARN for an S3 bucket, a CloudWatch Logs log group, or a
        /// Kinesis Data Firehose delivery stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Id</c>: The ID of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c>: The name of the query logging configuration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OwnerId</c>: The Amazon Web Services account ID for the account that created the
        /// query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ShareStatus</c>: An indication of whether the query logging configuration is shared
        /// with other Amazon Web Services accounts, or was shared with the current account by
        /// another Amazon Web Services account. Valid values include: <c>NOT_SHARED</c>, <c>SHARED_WITH_ME</c>,
        /// or <c>SHARED_BY_ME</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c>: The status of the query logging configuration. If you specify <c>Status</c>
        /// for <c>Name</c>, specify the applicable status code for <c>Values</c>: <c>CREATING</c>,
        /// <c>CREATED</c>, <c>DELETING</c>, or <c>FAILED</c>. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverQueryLogConfig.html#Route53Resolver-Type-route53resolver_ResolverQueryLogConfig-Status">Status</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>ListResolverQueryLogConfigAssociations</b> 
        /// </para>
        ///  
        /// <para>
        /// Valid values for <c>Name</c> include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreationTime</c>: The date and time that the VPC was associated with the query
        /// logging configuration, in Unix time format and Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Error</c>: If the value of <c>Status</c> is <c>FAILED</c>, specify the cause:
        /// <c>DESTINATION_NOT_FOUND</c> or <c>ACCESS_DENIED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Id</c>: The ID of the query logging association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResolverQueryLogConfigId</c>: The ID of the query logging configuration that a
        /// VPC is associated with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceId</c>: The ID of the Amazon VPC that is associated with the query logging
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Status</c>: The status of the query logging association. If you specify <c>Status</c>
        /// for <c>Name</c>, specify the applicable status code for <c>Values</c>: <c>CREATING</c>,
        /// <c>CREATED</c>, <c>DELETING</c>, or <c>FAILED</c>. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ResolverQueryLogConfigAssociation.html#Route53Resolver-Type-route53resolver_ResolverQueryLogConfigAssociation-Status">Status</a>.
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
        /// When you're using a <c>List</c> operation and you want the operation to return a subset
        /// of objects, such as Resolver endpoints or Resolver rules, the value of the parameter
        /// that you want to use to filter objects. For example, to list only inbound Resolver
        /// endpoints, specify <c>Direction</c> for <c>Name</c> and specify <c>INBOUND</c> for
        /// <c>Values</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}