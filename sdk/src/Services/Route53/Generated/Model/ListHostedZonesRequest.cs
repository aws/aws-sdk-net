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
    /// Retrieves a list of the public and private hosted zones that are associated with the
    /// current AWS account. The response includes a <code>HostedZones</code> child element
    /// for each hosted zone.
    /// 
    ///  
    /// <para>
    /// Amazon Route 53 returns a maximum of 100 items in each response. If you have a lot
    /// of hosted zones, you can use the <code>maxitems</code> parameter to list them in groups
    /// of up to 100.
    /// </para>
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
        /// If the value of <code>IsTruncated</code> in the previous response was <code>true</code>,
        /// you have more hosted zones. To get more hosted zones, submit another <code>ListHostedZones</code>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// For the value of <code>marker</code>, specify the value of <code>NextMarker</code>
        /// from the previous response, which is the ID of the first hosted zone that Amazon Route
        /// 53 will return if you submit another request.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>IsTruncated</code> in the previous response was <code>false</code>,
        /// there are no more hosted zones to get.
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
        /// (Optional) The maximum number of hosted zones that you want Amazon Route 53 to return.
        /// If you have more than <code>maxitems</code> hosted zones, the value of <code>IsTruncated</code>
        /// in the response is <code>true</code>, and the value of <code>NextMarker</code> is
        /// the hosted zone ID of the first hosted zone that Route 53 will return if you submit
        /// another request.
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
        /// <para>
        /// If you're using reusable delegation sets and you want to list all of the hosted zones
        /// that are associated with a reusable delegation set, specify the ID of that reusable
        /// delegation set. 
        /// </para>
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