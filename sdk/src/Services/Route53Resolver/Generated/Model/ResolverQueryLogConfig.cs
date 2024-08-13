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
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverQueryLogConfig.html">CreateResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DeleteResolverQueryLogConfig.html">DeleteResolverQueryLogConfig</a>,
    /// <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverQueryLogConfig.html">GetResolverQueryLogConfig</a>,
    /// or <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_ListResolverQueryLogConfigs.html">ListResolverQueryLogConfigs</a>
    /// request, a complex type that contains settings for one query logging configuration.
    /// </summary>
    public partial class ResolverQueryLogConfig
    {
        private string _arn;
        private int? _associationCount;
        private string _creationTime;
        private string _creatorRequestId;
        private string _destinationArn;
        private string _id;
        private string _name;
        private string _ownerId;
        private ShareStatus _shareStatus;
        private ResolverQueryLogConfigStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationCount. 
        /// <para>
        /// The number of VPCs that are associated with the query logging configuration.
        /// </para>
        /// </summary>
        public int? AssociationCount
        {
            get { return this._associationCount; }
            set { this._associationCount = value; }
        }

        // Check to see if AssociationCount property is set
        internal bool IsSetAssociationCount()
        {
            return this._associationCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the query logging configuration was created, in Unix time format
        /// and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the query logging configuration.
        /// The <c>CreatorRequestId</c> allows failed requests to be retried without the risk
        /// of running the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The ARN of the resource that you want Resolver to send query logs: an Amazon S3 bucket,
        /// a CloudWatch Logs log group, or a Kinesis Data Firehose delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the query logging configuration. 
        /// </para>
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID for the account that created the query logging
        /// configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=32)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ShareStatus. 
        /// <para>
        /// An indication of whether the query logging configuration is shared with other Amazon
        /// Web Services accounts, or was shared with the current account by another Amazon Web
        /// Services account. Sharing is configured through Resource Access Manager (RAM).
        /// </para>
        /// </summary>
        public ShareStatus ShareStatus
        {
            get { return this._shareStatus; }
            set { this._shareStatus = value; }
        }

        // Check to see if ShareStatus property is set
        internal bool IsSetShareStatus()
        {
            return this._shareStatus != null;
        }

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
        public ResolverQueryLogConfigStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}