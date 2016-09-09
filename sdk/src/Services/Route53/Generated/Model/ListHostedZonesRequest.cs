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
    /// Container for the parameters to the ListHostedZones operation.
    /// To retrieve a list of your public and private hosted zones, send a <code>GET</code>
    /// request to the <code>/2013-04-01/hostedzone</code> resource. The response to this
    /// request includes a <code>HostedZones</code> child element for each hosted zone created
    /// by the current AWS account.
    /// 
    ///  
    /// <para>
    /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
    /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
    /// of up to 100. The response includes four values that help navigate from one group
    /// of <code>maxitems</code> hosted zones to the next:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>MaxItems</code>is the value specified for the <code>maxitems</code> parameter
    /// in the request that produced the current response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
    /// zones associated with the current AWS account. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>NextMarker</code>is the hosted zone ID of the next hosted zone that is associated
    /// with the current AWS account. If you want to list more hosted zones, make another
    /// call to <code>ListHostedZones</code>, and specify the value of the <code>NextMarker</code>
    /// element in the marker parameter. 
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is false, the <code>NextMarker</code> element is omitted
    /// from the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you're making the second or subsequent call to <code>ListHostedZones</code>, the
    /// <code>Marker</code> element matches the value that you specified in the <code>marker</code>
    /// parameter in the previous request.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListHostedZonesRequest : AmazonRoute53Request
    {
        private string _marker;
        private string _maxItems;
        private string _delegationSetId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListHostedZonesRequest() { }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// (Optional) If you have more hosted zones than the value of <code>maxitems</code>,
        /// <code>ListHostedZones</code> returns only the first <code>maxitems</code> hosted zones.
        /// To get the next group of <code>maxitems</code> hosted zones, submit another request
        /// to <code>ListHostedZones</code>. For the value of marker, specify the value of the
        /// <code>NextMarker</code> element that was returned in the previous response.
        /// </para>
        ///  
        /// <para>
        /// Hosted zones are listed in the order in which they were created.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) The maximum number of hosted zones to be included in the response body
        /// for this request. If you have more than <code>maxitems</code> hosted zones, the value
        /// of the <code>IsTruncated</code> element in the response is <code>true</code>, and
        /// the value of the <code>NextMarker</code> element is the hosted zone ID of the first
        /// hosted zone in the next group of <code>maxitems</code> hosted zones.
        /// </para>
        /// </summary>
        public string MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationSetId.
        /// </summary>
        public string DelegationSetId
        {
            get { return this._delegationSetId; }
            set { this._delegationSetId = value; }
        }

        // Check to see if DelegationSetId property is set
        internal bool IsSetDelegationSetId()
        {
            return this._delegationSetId != null;
        }

    }
}