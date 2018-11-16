/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the GetResolverRuleAssociation operation.
    /// Gets information about an association between a specified resolver rule and a VPC.
    /// You associate a resolver rule and a VPC using <a>AssociateResolverRule</a>.
    /// </summary>
    public partial class GetResolverRuleAssociationRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverRuleAssociationId;

        /// <summary>
        /// Gets and sets the property ResolverRuleAssociationId. 
        /// <para>
        /// The ID of the resolver rule association that you want to get information about.
        /// </para>
        /// </summary>
        public string ResolverRuleAssociationId
        {
            get { return this._resolverRuleAssociationId; }
            set { this._resolverRuleAssociationId = value; }
        }

        // Check to see if ResolverRuleAssociationId property is set
        internal bool IsSetResolverRuleAssociationId()
        {
            return this._resolverRuleAssociationId != null;
        }

    }
}