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
    /// Container for the parameters to the ListHostedZonesByName operation.
    /// To retrieve a list of your hosted zones in lexicographic order, send a <code>GET</code>
    /// request to the <code>/<i>Route 53 API version</i>/hostedzonesbyname</code> resource.
    /// The response to this request includes a <code>HostedZones</code> element with zero
    /// or more <code>HostedZone</code> child elements lexicographically ordered by DNS name.
    /// By default, the list of hosted zones is displayed on a single page. You can control
    /// the length of the page that is displayed by using the <code>MaxItems</code> parameter.
    /// You can use the <code>DNSName</code> and <code>HostedZoneId</code> parameters to control
    /// the hosted zone that the list begins with.
    /// 
    ///  <note> Amazon Route 53 returns a maximum of 100 items. If you set MaxItems to a value
    /// greater than 100, Amazon Route 53 returns only the first 100.</note>
    /// </summary>
    public partial class ListHostedZonesByNameRequest : AmazonRoute53Request
    {
        private string _dnsName;
        private string _hostedZoneId;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The first name in the lexicographic ordering of domain names that you want the <code>ListHostedZonesByNameRequest</code>
        /// request to list.
        /// </para>
        ///  
        /// <para>
        /// If the request returned more than one page of results, submit another request and
        /// specify the value of <code>NextDNSName</code> and <code>NextHostedZoneId</code> from
        /// the last response in the <code>DNSName</code> and <code>HostedZoneId</code> parameters
        /// to get the next page of results.
        /// </para>
        /// </summary>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// If the request returned more than one page of results, submit another request and
        /// specify the value of <code>NextDNSName</code> and <code>NextHostedZoneId</code> from
        /// the last response in the <code>DNSName</code> and <code>HostedZoneId</code> parameters
        /// to get the next page of results.
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
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Specify the maximum number of hosted zones to return per page of results.
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

    }
}