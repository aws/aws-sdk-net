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
    /// In an <a>UpdateResolverRule</a> request, information about the changes that you want
    /// to make.
    /// </summary>
    public partial class ResolverRuleConfig
    {
        private string _name;
        private string _resolverEndpointId;
        private List<TargetAddress> _targetIps = new List<TargetAddress>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name for the resolver rule. The name that you specify appears in the Resolver
        /// dashboard in the Route 53 console. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the new outbound resolver endpoint that you want to use to route DNS queries
        /// to the IP addresses that you specify in <code>TargetIps</code>.
        /// </para>
        /// </summary>
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIps. 
        /// <para>
        /// For DNS queries that originate in your VPC, the new IP addresses that you want to
        /// route outbound DNS queries to.
        /// </para>
        /// </summary>
        public List<TargetAddress> TargetIps
        {
            get { return this._targetIps; }
            set { this._targetIps = value; }
        }

        // Check to see if TargetIps property is set
        internal bool IsSetTargetIps()
        {
            return this._targetIps != null && this._targetIps.Count > 0; 
        }

    }
}