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
    /// Container for the parameters to the CreateReusableDelegationSet operation.
    /// Creates a delegation set (a group of four name servers) that can be reused by multiple
    /// hosted zones that were created by the same Amazon Web Services account. 
    /// 
    ///  
    /// <para>
    /// You can also create a reusable delegation set that uses the four name servers that
    /// are associated with an existing hosted zone. Specify the hosted zone ID in the <c>CreateReusableDelegationSet</c>
    /// request.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't associate a reusable delegation set with a private hosted zone.
    /// </para>
    ///  </note> 
    /// <para>
    /// For information about using a reusable delegation set to configure white label name
    /// servers, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/white-label-name-servers.html">Configuring
    /// White Label Name Servers</a>.
    /// </para>
    ///  
    /// <para>
    /// The process for migrating existing hosted zones to use a reusable delegation set is
    /// comparable to the process for configuring white label name servers. You need to perform
    /// the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a reusable delegation set.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Recreate hosted zones, and reduce the TTL to 60 seconds or less.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Recreate resource record sets in the new hosted zones.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change the registrar's name servers to use the name servers for the new hosted zones.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Monitor traffic for the website or application.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Change TTLs back to their original values.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you want to migrate existing hosted zones to use a reusable delegation set, the
    /// existing hosted zones can't use any of the name servers that are assigned to the reusable
    /// delegation set. If one or more hosted zones do use one or more name servers that are
    /// assigned to the reusable delegation set, you can do one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For small numbers of hosted zones—up to a few hundred—it's relatively easy to create
    /// reusable delegation sets until you get one that has four name servers that don't overlap
    /// with any of the name servers in your hosted zones.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For larger numbers of hosted zones, the easiest solution is to use more than one reusable
    /// delegation set.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For larger numbers of hosted zones, you can also migrate hosted zones that have overlapping
    /// name servers to hosted zones that don't have overlapping name servers, then migrate
    /// the hosted zones again to use the reusable delegation set.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateReusableDelegationSetRequest : AmazonRoute53Request
    {
        private string _callerReference;
        private string _hostedZoneId;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request, and that allows you to retry failed <c>CreateReusableDelegationSet</c>
        /// requests without the risk of executing the operation twice. You must use a unique
        /// <c>CallerReference</c> string every time you submit a <c>CreateReusableDelegationSet</c>
        /// request. <c>CallerReference</c> can be any unique string, for example a date/time
        /// stamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// If you want to mark the delegation set for an existing hosted zone as reusable, the
        /// ID for that hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
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

    }
}