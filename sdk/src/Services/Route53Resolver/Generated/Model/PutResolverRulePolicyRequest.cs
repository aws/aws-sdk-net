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
    /// Container for the parameters to the PutResolverRulePolicy operation.
    /// Specifies the Resolver operations and resources that you want to allow another AWS
    /// account to be able to use.
    /// </summary>
    public partial class PutResolverRulePolicyRequest : AmazonRoute53ResolverRequest
    {
        private string _arn;
        private string _resolverRulePolicy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that you want to grant permissions to.
        /// </para>
        /// </summary>
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
        /// An AWS Identity and Access Management policy statement that lists the permissions
        /// that you want to grant to another AWS account.
        /// </para>
        /// </summary>
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