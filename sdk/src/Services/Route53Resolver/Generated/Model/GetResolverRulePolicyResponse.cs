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
    /// This is the response object from the GetResolverRulePolicy operation.
    /// </summary>
    public partial class GetResolverRulePolicyResponse : AmazonWebServiceResponse
    {
        private string _resolverRulePolicy;

        /// <summary>
        /// Gets and sets the property ResolverRulePolicy. 
        /// <para>
        /// The Resolver rule policy for the rule that you specified in a <code>GetResolverRulePolicy</code>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30000)]
        public string ResolverRulePolicy
        {
            get { return this._resolverRulePolicy; }
            set { this._resolverRulePolicy = value; }
        }

        // Check to see if ResolverRulePolicy property is set
        internal bool IsSetResolverRulePolicy()
        {
            return this._resolverRulePolicy != null;
        }

    }
}