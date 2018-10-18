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
    /// Container for the parameters to the DeleteHostedZone operation.
    /// Deletes a hosted zone.
    /// 
    ///  <important> 
    /// <para>
    /// If the name servers for the hosted zone are associated with a domain and if you want
    /// to make the domain unavailable on the Internet, we recommend that you delete the name
    /// servers from the domain to prevent future DNS queries from possibly being misrouted.
    /// If the domain is registered with Amazon Route 53, see <code>UpdateDomainNameservers</code>.
    /// If the domain is registered with another registrar, use the method provided by the
    /// registrar to delete name servers for the domain.
    /// </para>
    ///  
    /// <para>
    /// Some domain registries don't allow you to remove all of the name servers for a domain.
    /// If the registry for your domain requires one or more name servers, we recommend that
    /// you delete the hosted zone only if you transfer DNS service to another service provider,
    /// and you replace the name servers for the domain with name servers from the new provider.
    /// </para>
    ///  </important> 
    /// <para>
    /// You can delete a hosted zone only if it contains only the default SOA record and NS
    /// resource record sets. If the hosted zone contains other resource record sets, you
    /// must delete them before you can delete the hosted zone. If you try to delete a hosted
    /// zone that contains other resource record sets, the request fails, and Route 53 returns
    /// a <code>HostedZoneNotEmpty</code> error. For information about deleting records from
    /// your hosted zone, see <a>ChangeResourceRecordSets</a>.
    /// </para>
    ///  
    /// <para>
    /// To verify that the hosted zone has been deleted, do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>GetHostedZone</code> action to request information about the hosted
    /// zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <code>ListHostedZones</code> action to get a list of the hosted zones associated
    /// with the current AWS account.
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