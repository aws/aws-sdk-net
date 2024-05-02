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
    /// Container for the parameters to the DeleteHostedZone operation.
    /// Deletes a hosted zone.
    /// 
    ///  
    /// <para>
    /// If the hosted zone was created by another service, such as Cloud Map, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DeleteHostedZone.html#delete-public-hosted-zone-created-by-another-service">Deleting
    /// Public Hosted Zones That Were Created by Another Service</a> in the <i>Amazon Route 53
    /// Developer Guide</i> for information about how to delete it. (The process is the same
    /// for public and private hosted zones that were created by another service.)
    /// </para>
    ///  
    /// <para>
    /// If you want to keep your domain registration but you want to stop routing internet
    /// traffic to your website or web application, we recommend that you delete resource
    /// record sets in the hosted zone instead of deleting the hosted zone.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you delete a hosted zone, you can't undelete it. You must create a new hosted zone
    /// and update the name servers for your domain registration, which can require up to
    /// 48 hours to take effect. (If you delegated responsibility for a subdomain to a hosted
    /// zone and you delete the child hosted zone, you must update the name servers in the
    /// parent hosted zone.) In addition, if you delete a hosted zone, someone could hijack
    /// the domain and route traffic to their own resources using your domain name.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you want to avoid the monthly charge for the hosted zone, you can transfer DNS
    /// service for the domain to a free DNS service. When you transfer DNS service, you have
    /// to update the name servers for the domain registration. If the domain is registered
    /// with Route 53, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_UpdateDomainNameservers.html">UpdateDomainNameservers</a>
    /// for information about how to replace Route 53 name servers with name servers for the
    /// new DNS service. If the domain is registered with another registrar, use the method
    /// provided by the registrar to update name servers for the domain registration. For
    /// more information, perform an internet search on "free DNS service."
    /// </para>
    ///  
    /// <para>
    /// You can delete a hosted zone only if it contains only the default SOA record and NS
    /// resource record sets. If the hosted zone contains other resource record sets, you
    /// must delete them before you can delete the hosted zone. If you try to delete a hosted
    /// zone that contains other resource record sets, the request fails, and Route 53 returns
    /// a <c>HostedZoneNotEmpty</c> error. For information about deleting records from your
    /// hosted zone, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_ChangeResourceRecordSets.html">ChangeResourceRecordSets</a>.
    /// </para>
    ///  
    /// <para>
    /// To verify that the hosted zone has been deleted, do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <c>GetHostedZone</c> action to request information about the hosted zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <c>ListHostedZones</c> action to get a list of the hosted zones associated
    /// with the current Amazon Web Services account.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteHostedZoneRequest : AmazonRoute53Request
    {
        private string _id;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteHostedZoneRequest() { }

        /// <summary>
        /// Instantiates DeleteHostedZoneRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The ID of the hosted zone you want to delete.</param>
        public DeleteHostedZoneRequest(string id)
        {
            _id = id;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the hosted zone you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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

    }
}