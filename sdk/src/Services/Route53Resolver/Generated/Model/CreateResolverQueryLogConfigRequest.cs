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
    /// Container for the parameters to the CreateResolverQueryLogConfig operation.
    /// Creates a Resolver query logging configuration, which defines where you want Resolver
    /// to save DNS query logs that originate in your VPCs. Resolver can log queries only
    /// for VPCs that are in the same Region as the query logging configuration.
    /// 
    ///  
    /// <para>
    /// To specify which VPCs you want to log queries for, you use <c>AssociateResolverQueryLogConfig</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverQueryLogConfig.html">AssociateResolverQueryLogConfig</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can optionally use Resource Access Manager (RAM) to share a query logging configuration
    /// with other Amazon Web Services accounts. The other accounts can then associate VPCs
    /// with the configuration. The query logs that Resolver creates for a configuration include
    /// all DNS queries that originate in all VPCs that are associated with the configuration.
    /// </para>
    /// </summary>
    public partial class CreateResolverQueryLogConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _creatorRequestId;
        private string _destinationArn;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and that allows failed requests to be
        /// retried without the risk of running the operation twice. <c>CreatorRequestId</c> can
        /// be any unique string, for example, a date/time stamp. 
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
        /// The ARN of the resource that you want Resolver to send query logs. You can send query
        /// logs to an S3 bucket, a CloudWatch Logs log group, or a Kinesis Data Firehose delivery
        /// stream. Examples of valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>S3 bucket</b>: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:s3:::amzn-s3-demo-bucket</c> 
        /// </para>
        ///  
        /// <para>
        /// You can optionally append a file prefix to the end of the ARN.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:s3:::amzn-s3-demo-bucket/development/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudWatch Logs log group</b>: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:logs:us-west-1:123456789012:log-group:/mystack-testgroup-12ABC1AB12A1:*</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Kinesis Data Firehose delivery stream</b>:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:kinesis:us-east-2:0123456789:stream/my_stream_name</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=600)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you want to give the query logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tag keys and values that you want to associate with the query logging
        /// configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}