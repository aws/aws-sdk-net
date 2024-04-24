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
    /// Container for the parameters to the PutResolverQueryLogConfigPolicy operation.
    /// Specifies an Amazon Web Services account that you want to share a query logging configuration
    /// with, the query logging configuration that you want to share, and the operations that
    /// you want the account to be able to perform on the configuration.
    /// </summary>
    public partial class PutResolverQueryLogConfigPolicyRequest : AmazonRoute53ResolverRequest
    {
        private string _arn;
        private string _resolverQueryLogConfigPolicy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that you want to share rules with.
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
        /// Gets and sets the property ResolverQueryLogConfigPolicy. 
        /// <para>
        /// An Identity and Access Management policy statement that lists the query logging configurations
        /// that you want to share with another Amazon Web Services account and the operations
        /// that you want the account to be able to perform. You can specify the following operations
        /// in the <c>Actions</c> section of the statement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>route53resolver:AssociateResolverQueryLogConfig</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route53resolver:DisassociateResolverQueryLogConfig</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route53resolver:ListResolverQueryLogConfigs</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In the <c>Resource</c> section of the statement, you specify the ARNs for the query
        /// logging configurations that you want to share with the account that you specified
        /// in <c>Arn</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=30000)]
        public string ResolverQueryLogConfigPolicy
        {
            get { return this._resolverQueryLogConfigPolicy; }
            set { this._resolverQueryLogConfigPolicy = value; }
        }

        // Check to see if ResolverQueryLogConfigPolicy property is set
        internal bool IsSetResolverQueryLogConfigPolicy()
        {
            return this._resolverQueryLogConfigPolicy != null;
        }

    }
}