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
    /// This is the response object from the AssociateResolverQueryLogConfig operation.
    /// </summary>
    public partial class AssociateResolverQueryLogConfigResponse : AmazonWebServiceResponse
    {
        private ResolverQueryLogConfigAssociation _resolverQueryLogConfigAssociation;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigAssociation. 
        /// <para>
        /// A complex type that contains settings for a specified association between an Amazon
        /// VPC and a query logging configuration.
        /// </para>
        /// </summary>
        public ResolverQueryLogConfigAssociation ResolverQueryLogConfigAssociation
        {
            get { return this._resolverQueryLogConfigAssociation; }
            set { this._resolverQueryLogConfigAssociation = value; }
        }

        // Check to see if ResolverQueryLogConfigAssociation property is set
        internal bool IsSetResolverQueryLogConfigAssociation()
        {
            return this._resolverQueryLogConfigAssociation != null;
        }

    }
}