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
    /// Container for the parameters to the PutResolverRulePolicy operation.
    /// Specifies an Amazon Web Services rule that you want to share with another account,
    /// the account that you want to share the rule with, and the operations that you want
    /// the account to be able to perform on the rule.
    /// </summary>
    public partial class PutResolverRulePolicyRequest : AmazonRoute53ResolverRequest
    {
        private string _arn;
        private string _resolverRulePolicy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule that you want to share with another account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property ResolverRulePolicy. 
        /// <para>
        /// An Identity and Access Management policy statement that lists the rules that you want
        /// to share with another Amazon Web Services account and the operations that you want
        /// the account to be able to perform. You can specify the following operations in the
        /// <code>Action</code> section of the statement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>route53resolver:GetResolverRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route53resolver:AssociateResolverRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route53resolver:DisassociateResolverRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route53resolver:ListResolverRules</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route53resolver:ListResolverRuleAssociations</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the <code>Resource</code> section of the statement, specify the ARN for the rule
        /// that you want to share with another account. Specify the same ARN that you specified
        /// in <code>Arn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=30000)]
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