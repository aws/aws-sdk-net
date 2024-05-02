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
    /// Container for the parameters to the GetResolverQueryLogConfigAssociation operation.
    /// Gets information about a specified association between a Resolver query logging configuration
    /// and an Amazon VPC. When you associate a VPC with a query logging configuration, Resolver
    /// logs DNS queries that originate in that VPC.
    /// </summary>
    public partial class GetResolverQueryLogConfigAssociationRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverQueryLogConfigAssociationId;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigAssociationId. 
        /// <para>
        /// The ID of the Resolver query logging configuration association that you want to get
        /// information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResolverQueryLogConfigAssociationId
        {
            get { return this._resolverQueryLogConfigAssociationId; }
            set { this._resolverQueryLogConfigAssociationId = value; }
        }

        // Check to see if ResolverQueryLogConfigAssociationId property is set
        internal bool IsSetResolverQueryLogConfigAssociationId()
        {
            return this._resolverQueryLogConfigAssociationId != null;
        }

    }
}