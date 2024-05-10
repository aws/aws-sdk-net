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
    /// Container for the parameters to the AssociateResolverQueryLogConfig operation.
    /// Associates an Amazon VPC with a specified query logging configuration. Route 53 Resolver
    /// logs DNS queries that originate in all of the Amazon VPCs that are associated with
    /// a specified query logging configuration. To associate more than one VPC with a configuration,
    /// submit one <c>AssociateResolverQueryLogConfig</c> request for each VPC.
    /// 
    ///  <note> 
    /// <para>
    /// The VPCs that you associate with a query logging configuration must be in the same
    /// Region as the configuration.
    /// </para>
    ///  </note> 
    /// <para>
    /// To remove a VPC from a query logging configuration, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverQueryLogConfig.html">DisassociateResolverQueryLogConfig</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class AssociateResolverQueryLogConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverQueryLogConfigId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigId. 
        /// <para>
        /// The ID of the query logging configuration that you want to associate a VPC with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResolverQueryLogConfigId
        {
            get { return this._resolverQueryLogConfigId; }
            set { this._resolverQueryLogConfigId = value; }
        }

        // Check to see if ResolverQueryLogConfigId property is set
        internal bool IsSetResolverQueryLogConfigId()
        {
            return this._resolverQueryLogConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of an Amazon VPC that you want this query logging configuration to log queries
        /// for.
        /// </para>
        ///  <note> 
        /// <para>
        /// The VPCs and the query logging configuration must be in the same Region.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}