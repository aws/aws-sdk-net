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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrafficPolicyInstance operation.
    /// <note> 
    /// <para>
    /// After you submit a <c>UpdateTrafficPolicyInstance</c> request, there's a brief delay
    /// while Route 53 creates the resource record sets that are specified in the traffic
    /// policy definition. Use <c>GetTrafficPolicyInstance</c> with the <c>id</c> of updated
    /// traffic policy instance confirm that the <c>UpdateTrafficPolicyInstance</c> request
    /// completed successfully. For more information, see the <c>State</c> response element.
    /// </para>
    ///  </note> 
    /// <para>
    /// Updates the resource record sets in a specified hosted zone that were created based
    /// on the settings in a specified traffic policy version.
    /// </para>
    ///  
    /// <para>
    /// When you update a traffic policy instance, Amazon Route 53 continues to respond to
    /// DNS queries for the root resource record set name (such as example.com) while it replaces
    /// one group of resource record sets with another. Route 53 performs the following operations:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Route 53 creates a new group of resource record sets based on the specified traffic
    /// policy. This is true regardless of how significant the differences are between the
    /// existing resource record sets and the new resource record sets. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When all of the new resource record sets have been created, Route 53 starts to respond
    /// to DNS queries for the root resource record set name (such as example.com) by using
    /// the new resource record sets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Route 53 deletes the old group of resource record sets that are associated with the
    /// root resource record set name.
    /// </para>
    ///  </li> </ol>
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
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public long? TTL
        {
            get { return this._ttl; }
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
        [AWSProperty(Required=true, Min=1, Max=36)]
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
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? TrafficPolicyVersion
        {
            get { return this._trafficPolicyVersion; }
            set { this._trafficPolicyVersion = value; }
        }

        // Check to see if TrafficPolicyVersion property is set
        internal bool IsSetTrafficPolicyVersion()
        {
            return this._trafficPolicyVersion.HasValue; 
        }

    }
}