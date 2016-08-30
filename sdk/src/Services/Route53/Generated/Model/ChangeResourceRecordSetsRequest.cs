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
    /// Container for the parameters to the ChangeResourceRecordSets operation.
    /// Create, change, update, or delete authoritative DNS information on all Amazon Route
    /// 53 servers. Send a <code>POST</code> request to: 
    /// 
    ///  
    /// <para>
    ///  <code>/2013-04-01/hostedzone/<i>Amazon Route 53 hosted Zone ID</i>/rrset</code> resource.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The request body must include a document with a <code>ChangeResourceRecordSetsRequest</code>
    /// element. The request body contains a list of change items, known as a change batch.
    /// Change batches are considered transactional changes. When using the Amazon Route 53
    /// API to change resource record sets, Amazon Route 53 either makes all or none of the
    /// changes in a change batch request. This ensures that Amazon Route 53 never partially
    /// implements the intended changes to the resource record sets in a hosted zone. 
    /// </para>
    ///  
    /// <para>
    /// For example, a change batch request that deletes the <code>CNAME</code>record for
    /// www.example.com and creates an alias resource record set for www.example.com. Amazon
    /// Route 53 deletes the first resource record set and creates the second resource record
    /// set in a single operation. If either the <code>DELETE</code> or the <code>CREATE</code>
    /// action fails, then both changes (plus any other changes in the batch) fail, and the
    /// original <code>CNAME</code> record continues to exist.
    /// </para>
    ///  <important> 
    /// <para>
    /// Due to the nature of transactional changes, you cannot delete the same resource record
    /// set more than once in a single change batch. If you attempt to delete the same change
    /// batch more than once, Amazon Route 53 returns an <code>InvalidChangeBatch</code> error.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// To create resource record sets for complex routing configurations, use either the
    /// traffic flow visual editor in the Amazon Route 53 console or the API actions for traffic
    /// policies and traffic policy instances. Save the configuration as a traffic policy,
    /// then associate the traffic policy with one or more domain names (such as example.com)
    /// or subdomain names (such as www.example.com), in the same hosted zone or in multiple
    /// hosted zones. You can roll back the updates if the new configuration isn't performing
    /// as expected. For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/traffic-flow.html">Using
    /// Traffic Flow to Route DNS Traffic</a> in the Amazon Route 53 API Reference or <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/actions-on-polices">Actions
    /// on Traffic Policies and Traffic Policy Instances</a> in this guide.
    /// </para>
    ///  </note> 
    /// <para>
    /// Use <code>ChangeResourceRecordsSetsRequest</code> to perform the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CREATE</code>:Creates a resource record set that has the specified values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DELETE</code>: Deletes an existing resource record set that has the specified
    /// values for <code>Name</code>, <code>Type</code>, <code>Set Identifier</code> (for
    /// code latency, weighted, geolocation, and failover resource record sets), and <code>TTL</code>
    /// (except alias resource record sets, for which the TTL is determined by the AWS resource
    /// you're routing queries to).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UPSERT</code>: If a resource record set does not already exist, AWS creates
    /// it. If a resource set does exist, Amazon Route 53 updates it with the values in the
    /// request. Amazon Route 53 can update an existing resource record set only when all
    /// of the following values match: <code>Name</code>, <code>Type</code>, and <code>Set
    /// Identifier</code> (for weighted, latency, geolocation, and failover resource record
    /// sets).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In response to a <code>ChangeResourceRecordSets</code> request, the DNS data is changed
    /// on all Amazon Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>,
    /// meaning the change has not yet propagated to all the authoritative Amazon Route 53
    /// DNS servers. When the change is propagated to all hosts, the change returns a status
    /// of <code>INSYNC</code>.
    /// </para>
    ///  
    /// <para>
    /// After sending a change request, confirm your change has propagated to all Amazon Route
    /// 53 DNS servers. Changes generally propagate to all Amazon Route 53 name servers in
    /// a few minutes. In rare circumstances, propagation can take up to 30 minutes. For more
    /// information, see <a>GetChange</a>.
    /// </para>
    ///  
    /// <para>
    /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  A request cannot contain more than 100 Change elements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  A request cannot contain more than 1000 ResourceRecord elements.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The sum of the number of characters (including spaces) in all <code>Value</code> elements
    /// in a request cannot exceed 32,000 characters.
    /// </para>
    ///  </li> <li> <note> 
    /// <para>
    /// If the value of the Action element in a ChangeResourceRecordSets request is <code>UPSERT</code>
    /// and the resource record set already exists, Amazon Route 53 automatically performs
    /// a <code>DELETE</code> request and a <code>CREATE</code> request. When Amazon Route
    /// 53 calculates the number of characters in the Value elements of a change batch request,
    /// it adds the number of characters in the Value element of the resource record set being
    /// deleted and the number of characters in the Value element of the resource record set
    /// being created.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// The same resource cannot be deleted more than once in a single batch.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If the value of the Action element in a ChangeResourceRecordSets request is <code>UPSERT</code>
    /// and the resource record set already exists, Amazon Route 53 automatically performs
    /// a <code>DELETE</code> request and a <code>CREATE</code> request. When Amazon Route
    /// 53 calculates the number of characters in the Value elements of a change batch request,
    /// it adds the number of characters in the Value element of the resource record set being
    /// deleted and the number of characters in the Value element of the resource record set
    /// being created.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on transactional changes, see <a>ChangeResourceRecordSets</a>.
    /// </para>
    /// </summary>
    public partial class ChangeResourceRecordSetsRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private ChangeBatch _changeBatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeResourceRecordSetsRequest() { }

        /// <summary>
        /// Instantiates ChangeResourceRecordSetsRequest with the parameterized properties
        /// </summary>
        /// <param name="hostedZoneId">The ID of the hosted zone that contains the resource record sets that you want to change.</param>
        /// <param name="changeBatch">A complex type that contains an optional comment and the <code>Changes</code> element.</param>
        public ChangeResourceRecordSetsRequest(string hostedZoneId, ChangeBatch changeBatch)
        {
            _hostedZoneId = hostedZoneId;
            _changeBatch = changeBatch;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the resource record sets that you want to
        /// change.
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
        /// Gets and sets the property ChangeBatch. 
        /// <para>
        /// A complex type that contains an optional comment and the <code>Changes</code> element.
        /// </para>
        /// </summary>
        public ChangeBatch ChangeBatch
        {
            get { return this._changeBatch; }
            set { this._changeBatch = value; }
        }

        // Check to see if ChangeBatch property is set
        internal bool IsSetChangeBatch()
        {
            return this._changeBatch != null;
        }

    }
}