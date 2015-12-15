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
    /// Container for the parameters to the UpdateTrafficPolicyInstance operation.
    /// Updates the resource record sets in a specified hosted zone that were created based
    /// on the settings in a specified traffic policy version.
    /// 
    ///  <important>The DNS type of the resource record sets that you're updating must match
    /// the DNS type in the JSON document that is associated with the traffic policy version
    /// that you're using to update the traffic policy instance.</important> 
    /// <para>
    /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
    /// DNS queries for the root resource record set name (such as example.com) while it replaces
    /// one group of resource record sets with another. Amazon Route 53 performs the following
    /// operations:
    /// </para>
    ///  <ol> <li>Amazon Route 53 creates a new group of resource record sets based on the
    /// specified traffic policy. This is true regardless of how substantial the differences
    /// are between the existing resource record sets and the new resource record sets. </li>
    /// <li>When all of the new resource record sets have been created, Amazon Route 53 starts
    /// to respond to DNS queries for the root resource record set name (such as example.com)
    /// by using the new resource record sets.</li> <li>Amazon Route 53 deletes the old group
    /// of resource record sets that are associated with the root resource record set name.</li>
    /// </ol> 
    /// <para>
    /// To update a traffic policy instance, send a <code>POST</code> request to the <code>/2013-04-01/trafficpolicyinstance/<i>traffic
    /// policy ID</i></code> resource. The request body must include an XML document with
    /// an <code>UpdateTrafficPolicyInstanceRequest</code> element.
    /// </para>
    /// </summary>
    public partial class UpdateTrafficPolicyInstanceRequest : AmazonRoute53Request
    {
        private string _id;
        private long? _ttl;
        private string _trafficPolicyId;
        private int? _trafficPolicyVersion;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the traffic policy instance that you want to update.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property TTL. 
        /// <para>
        /// The TTL that you want Amazon Route 53 to assign to all of the updated resource record
        /// sets.
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
        /// The ID of the traffic policy that you want Amazon Route 53 to use to update resource
        /// record sets for the specified traffic policy instance.
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
        /// The version of the traffic policy that you want Amazon Route 53 to use to update resource
        /// record sets for the specified traffic policy instance.
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