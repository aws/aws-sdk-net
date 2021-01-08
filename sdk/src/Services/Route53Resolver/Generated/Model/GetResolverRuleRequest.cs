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
    /// Container for the parameters to the GetResolverRule operation.
    /// Gets information about a specified Resolver rule, such as the domain name that the
    /// rule forwards DNS queries for and the ID of the outbound Resolver endpoint that the
    /// rule is associated with.
    /// </summary>
    public partial class GetResolverRuleRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverRuleId;

        /// <summary>
        /// Gets and sets the property ResolverRuleId. 
        /// <para>
        /// The ID of the Resolver rule that you want to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResolverRuleId
        {
            get { return this._resolverRuleId; }
            set { this._resolverRuleId = value; }
        }

        // Check to see if ResolverRuleId property is set
        internal bool IsSetResolverRuleId()
        {
            return this._resolverRuleId != null;
        }

    }
}