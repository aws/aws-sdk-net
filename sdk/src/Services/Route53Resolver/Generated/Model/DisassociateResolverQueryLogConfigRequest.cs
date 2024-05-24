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
    /// Container for the parameters to the DisassociateResolverQueryLogConfig operation.
    /// Disassociates a VPC from a query logging configuration.
    /// 
    ///  <note> 
    /// <para>
    /// Before you can delete a query logging configuration, you must first disassociate all
    /// VPCs from the configuration. If you used Resource Access Manager (RAM) to share a
    /// query logging configuration with other accounts, VPCs can be disassociated from the
    /// configuration in the following ways:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The accounts that you shared the configuration with can disassociate VPCs from the
    /// configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can stop sharing the configuration.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DisassociateResolverQueryLogConfigRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverQueryLogConfigId;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property ResolverQueryLogConfigId. 
        /// <para>
        /// The ID of the query logging configuration that you want to disassociate a specified
        /// VPC from.
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

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon VPC that you want to disassociate from a specified query logging
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}