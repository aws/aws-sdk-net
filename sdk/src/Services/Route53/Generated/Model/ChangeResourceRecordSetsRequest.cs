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
    /// Container for the parameters to the ChangeResourceRecordSets operation.
    /// Creates, changes, or deletes a resource record set, which contains authoritative DNS
    /// information for a specified domain name or subdomain name. For example, you can use
    /// <c>ChangeResourceRecordSets</c> to create a resource record set that routes traffic
    /// for test.example.com to a web server that has an IP address of 192.0.2.44.
    /// 
    ///  
    /// <para>
    ///  <b>Deleting Resource Record Sets</b> 
    /// </para>
    ///  
    /// <para>
    /// To delete a resource record set, you must specify all the same values that you specified
    /// when you created it.
    /// </para>
    ///  
    /// <para>
    ///  <b>Change Batches and Transactional Changes</b> 
    /// </para>
    ///  
    /// <para>
    /// The request body must include a document with a <c>ChangeResourceRecordSetsRequest</c>
    /// element. The request body contains a list of change items, known as a change batch.
    /// Change batches are considered transactional changes. Route 53 validates the changes
    /// in the request and then either makes all or none of the changes in the change batch
    /// request. This ensures that DNS routing isn't adversely affected by partial changes
    /// to the resource record sets in a hosted zone. 
    /// </para>
    ///  
    /// <para>
    /// For example, suppose a change batch request contains two changes: it deletes the <c>CNAME</c>
    /// resource record set for www.example.com and creates an alias resource record set for
    /// www.example.com. If validation for both records succeeds, Route 53 deletes the first
    /// resource record set and creates the second resource record set in a single operation.
    /// If validation for either the <c>DELETE</c> or the <c>CREATE</c> action fails, then
    /// the request is canceled, and the original <c>CNAME</c> record continues to exist.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you try to delete the same resource record set more than once in a single change
    /// batch, Route 53 returns an <c>InvalidChangeBatch</c> error.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Traffic Flow</b> 
    /// </para>
    ///  
    /// <para>
    /// To create resource record sets for complex routing configurations, use either the
    /// traffic flow visual editor in the Route 53 console or the API actions for traffic
    /// policies and traffic policy instances. Save the configuration as a traffic policy,
    /// then associate the traffic policy with one or more domain names (such as example.com)
    /// or subdomain names (such as www.example.com), in the same hosted zone or in multiple
    /// hosted zones. You can roll back the updates if the new configuration isn't performing
    /// as expected. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/traffic-flow.html">Using
    /// Traffic Flow to Route DNS Traffic</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Create, Delete, and Upsert</b> 
    /// </para>
    ///  
    /// <para>
    /// Use <c>ChangeResourceRecordsSetsRequest</c> to perform the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CREATE</c>: Creates a resource record set that has the specified values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DELETE</c>: Deletes an existing resource record set that has the specified values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UPSERT</c>: If a resource set doesn't exist, Route 53 creates it. If a resource
    /// set exists Route 53 updates it with the values in the request. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Syntaxes for Creating, Updating, and Deleting Resource Record Sets</b> 
    /// </para>
    ///  
    /// <para>
    /// The syntax for a request depends on the type of resource record set that you want
    /// to create, delete, or update, such as weighted, alias, or failover. The XML elements
    /// in your request must appear in the order listed in the syntax. 
    /// </para>
    ///  
    /// <para>
    /// For an example for each type of resource record set, see "Examples."
    /// </para>
    ///  
    /// <para>
    /// Don't refer to the syntax in the "Parameter Syntax" section, which includes all of
    /// the elements for every kind of resource record set that you can create, delete, or
    /// update by using <c>ChangeResourceRecordSets</c>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Change Propagation to Route 53 DNS Servers</b> 
    /// </para>
    ///  
    /// <para>
    /// When you submit a <c>ChangeResourceRecordSets</c> request, Route 53 propagates your
    /// changes to all of the Route 53 authoritative DNS servers managing the hosted zone.
    /// While your changes are propagating, <c>GetChange</c> returns a status of <c>PENDING</c>.
    /// When propagation is complete, <c>GetChange</c> returns a status of <c>INSYNC</c>.
    /// Changes generally propagate to all Route 53 name servers managing the hosted zone
    /// within 60 seconds. For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_GetChange.html">GetChange</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Limits on ChangeResourceRecordSets Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// For information about the limits on a <c>ChangeResourceRecordSets</c> request, see
    /// <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
    /// in the <i>Amazon Route 53 Developer Guide</i>.
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
        /// <param name="changeBatch">A complex type that contains an optional comment and the <c>Changes</c> element.</param>
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
        [AWSProperty(Required=true, Max=32)]
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
        /// A complex type that contains an optional comment and the <c>Changes</c> element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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