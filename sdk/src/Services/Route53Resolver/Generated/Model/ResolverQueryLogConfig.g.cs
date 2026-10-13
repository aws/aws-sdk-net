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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverQueryLogConfig.html">CreateResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverQueryLogConfig.html">DeleteResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverQueryLogConfig.html">GetResolverQueryLogConfig</a>,
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html">ListResolverQueryLogConfigs</a>
    /// request, a complex type that contains settings for one query logging configuration.
    /// </summary>
    public partial class ResolverQueryLogConfig
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociationCount. 
        /// <para>
        /// The number of VPCs that are associated with the query logging configuration.
        /// </para>
        /// </summary>
        public int? AssociationCount { get; set; }

        /// <summary>
        /// Checks to see if the AssociationCount property is set.
        /// </summary>
        internal bool IsSetAssociationCount() => this.AssociationCount.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the query logging configuration was created, in Unix time format
        /// and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the query logging configuration.
        /// The <c>CreatorRequestId</c> allows failed requests to be retried without the risk
        /// of running the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the resource that you want Resolver to send query logs: an Amazon S3 bucket,
        /// a CloudWatch Logs log group, or a Kinesis Data Firehose delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the query logging configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID for the account that created the query logging
        /// configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 32)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// An indication of whether the query logging configuration is shared with other Amazon
        /// Web Services accounts, or was shared with the current account by another Amazon Web
        /// Services account. Sharing is configured through Resource Access Manager (RAM).
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShareStatus property is set.
        /// </summary>
        internal bool IsSetShareStatus() => this.ShareStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the specified query logging configuration. Valid values include the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: Resolver is creating the query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c>: The query logging configuration was successfully created. Resolver
        /// is logging queries that originate in the specified VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Resolver is deleting this query logging configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: Resolver can't deliver logs to the location that is specified in the
        /// query logging configuration. Here are two common causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The specified destination (for example, an Amazon S3 bucket) was deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Permissions don't allow sending logs to the destination.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public ResolverQueryLogConfigStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
