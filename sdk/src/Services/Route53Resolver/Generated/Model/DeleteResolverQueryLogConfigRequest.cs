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
    /// Container for the parameters to the DeleteResolverQueryLogConfig operation.
    /// Deletes a query logging configuration. When you delete a configuration, Resolver stops
    /// logging DNS queries for all of the Amazon VPCs that are associated with the configuration.
    /// This also applies if the query logging configuration is shared with other Amazon Web
    /// Services accounts, and the other accounts have associated VPCs with the shared configuration.
    /// 
    ///  
    /// <para>
    /// Before you can delete a query logging configuration, you must first disassociate all
    /// VPCs from the configuration. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverQueryLogConfig.html">DisassociateResolverQueryLogConfig</a>.
    /// </para>
    ///  
    /// <para>
    /// If you used Resource Access Manager (RAM) to share a query logging configuration with
    /// other accounts, you must stop sharing the configuration before you can delete a configuration.
    /// The accounts that you shared the configuration with can first disassociate VPCs that
    /// they associated with the configuration, but that's not necessary. If you stop sharing
    /// the configuration, those VPCs are automatically disassociated from the configuration.
    /// </para>
    /// </summary>
    public partial class DeleteResolverQueryLogConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverQueryLogConfigId;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigId. 
        /// <para>
        /// The ID of the query logging configuration that you want to delete.
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

    }
}