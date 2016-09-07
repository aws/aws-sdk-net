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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrafficPolicyInstance operation.
    /// Creates resource record sets in a specified hosted zone based on the settings in a
    /// specified traffic policy version. In addition, <code>CreateTrafficPolicyInstance</code>
    /// associates the resource record sets with a specified domain name (such as example.com)
    /// or subdomain name (such as www.example.com). Amazon Route 53 responds to DNS queries
    /// for the domain or subdomain name by using the resource record sets that <code>CreateTrafficPolicyInstance</code>
    /// created.
    /// 
    ///  
    /// <para>
    /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/trafficpolicyinstance</code>
    /// resource. The request body must include a document with a <code>CreateTrafficPolicyRequest</code>
    /// element. The response returns the <code>CreateTrafficPolicyInstanceResponse</code>
    /// element, which contains information about the traffic policy instance.
    /// </para>
    /// </summary>
    public partial class CreateTrafficPolicyInstanceRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _name;
        private long? _ttl;
        private string _trafficPolicyId;
        private int? _trafficPolicyVersion;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone in which you want Amazon Route 53 to create resource record
        /// sets by using the configuration in a traffic policy.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The domain name (such as example.com) or subdomain name (such as www.example.com)
        /// for which Amazon Route 53 responds to DNS queries by using the resource record sets
        /// that Amazon Route 53 creates for this traffic policy instance.
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
        /// Gets and sets the property TTL. 
        /// <para>
        /// (Optional) The TTL that you want Amazon Route 53 to assign to all of the resource
        /// record sets that it creates in the specified hosted zone.
        /// </para>
        /// </summary>
        public long TTL
        {
            get { return this._ttl.GetValueOrDefault(); }
            set { this._ttl = value; }
        }

        // Check to see if TTL property is set
        internal bool IsSetTTL()
        {
            return this._ttl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyId. 
        /// <para>
        /// The ID of the traffic policy that you want to use to create resource record sets in
        /// the specified hosted zone.
        /// </para>
        /// </summary>
        public string TrafficPolicyId
        {
            get { return this._trafficPolicyId; }
            set { this._trafficPolicyId = value; }
        }

        // Check to see if TrafficPolicyId property is set
        internal bool IsSetTrafficPolicyId()
        {
            return this._trafficPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyVersion. 
        /// <para>
        /// The version of the traffic policy that you want to use to create resource record sets
        /// in the specified hosted zone.
        /// </para>
        /// </summary>
        public int TrafficPolicyVersion
        {
            get { return this._trafficPolicyVersion.GetValueOrDefault(); }
            set { this._trafficPolicyVersion = value; }
        }

        // Check to see if TrafficPolicyVersion property is set
        internal bool IsSetTrafficPolicyVersion()
        {
            return this._trafficPolicyVersion.HasValue; 
        }

    }
}