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
    /// Container for the parameters to the DisassociateResolverRule operation.
    /// Removes the association between a specified Resolver rule and a specified VPC.
    /// 
    ///  <important> 
    /// <para>
    /// If you disassociate a Resolver rule from a VPC, Resolver stops forwarding DNS queries
    /// for the domain name that you specified in the Resolver rule. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DisassociateResolverRuleRequest : AmazonRoute53ResolverRequest
    {
        private string _resolverRuleId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ResolverRuleId. 
        /// <para>
        /// The ID of the Resolver rule that you want to disassociate from the specified VPC.
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

        /// <summary>
        /// Gets and sets the property VPCId. 
        /// <para>
        /// The ID of the VPC that you want to disassociate the Resolver rule from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VPCId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VPCId property is set
        internal bool IsSetVPCId()
        {
            return this._vpcId != null;
        }

    }
}