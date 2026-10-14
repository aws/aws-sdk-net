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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the PutResolverQueryLogConfigPolicy operation. Specifies
    /// an Amazon Web Services account that you want to share a query logging configuration
    /// with, the query logging configuration that you want to share, and the operations that
    /// you want the account to be able to perform on the configuration.
    /// </summary>
    public partial class PutResolverQueryLogConfigPolicyRequest : AmazonRoute53ResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the account that you want to share rules with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        [AWSProperty(Required = true, Min = 0, Max = 30000)]
        public string ResolverQueryLogConfigPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResolverQueryLogConfigPolicy property is set.
        /// </summary>
        internal bool IsSetResolverQueryLogConfigPolicy() => this.ResolverQueryLogConfigPolicy != null;
    }
}
