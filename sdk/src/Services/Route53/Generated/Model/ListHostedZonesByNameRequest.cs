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
    /// Container for the parameters to the ListHostedZonesByName operation.
    /// Retrieves a list of your hosted zones in lexicographic order. The response includes
    /// a <c>HostedZones</c> child element for each hosted zone created by the current Amazon
    /// Web Services account. 
    /// 
    ///  
    /// <para>
    ///  <c>ListHostedZonesByName</c> sorts hosted zones by name with the labels reversed.
    /// For example:
    /// </para>
    ///  
    /// <para>
    ///  <c>com.example.www.</c> 
    /// </para>
    ///  
    /// <para>
    /// Note the trailing dot, which can change the sort order in some circumstances.
    /// </para>
    ///  
    /// <para>
    /// If the domain name includes escape characters or Punycode, <c>ListHostedZonesByName</c>
    /// alphabetizes the domain name using the escaped or Punycoded value, which is the format
    /// that Amazon Route 53 saves in its database. For example, to create a hosted zone for
    /// exämple.com, you specify ex\344mple.com for the domain name. <c>ListHostedZonesByName</c>
    /// alphabetizes it as:
    /// </para>
    ///  
    /// <para>
    ///  <c>com.ex\344mple.</c> 
    /// </para>
    ///  
    /// <para>
    /// The labels are reversed and alphabetized using the escaped value. For more information
    /// about valid domain name formats, including internationalized domain names, see <a
    /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
    /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Route 53 returns up to 100 items in each response. If you have a lot of hosted zones,
    /// use the <c>MaxItems</c> parameter to list them in groups of up to 100. The response
    /// includes values that help navigate from one group of <c>MaxItems</c> hosted zones
    /// to the next:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>DNSName</c> and <c>HostedZoneId</c> elements in the response contain the values,
    /// if any, specified for the <c>dnsname</c> and <c>hostedzoneid</c> parameters in the
    /// request that produced the current response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>MaxItems</c> element in the response contains the value, if any, that you specified
    /// for the <c>maxitems</c> parameter in the request that produced the current response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the value of <c>IsTruncated</c> in the response is true, there are more hosted
    /// zones associated with the current Amazon Web Services account. 
    /// </para>
    ///  
    /// <para>
    /// If <c>IsTruncated</c> is false, this response includes the last hosted zone that is
    /// associated with the current account. The <c>NextDNSName</c> element and <c>NextHostedZoneId</c>
    /// elements are omitted from the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>NextDNSName</c> and <c>NextHostedZoneId</c> elements in the response contain
    /// the domain name and the hosted zone ID of the next hosted zone that is associated
    /// with the current Amazon Web Services account. If you want to list more hosted zones,
    /// make another call to <c>ListHostedZonesByName</c>, and specify the value of <c>NextDNSName</c>
    /// and <c>NextHostedZoneId</c> in the <c>dnsname</c> and <c>hostedzoneid</c> parameters,
    /// respectively.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListHostedZonesByNameRequest : AmazonRoute53Request
    {
        private string _dnsName;
        private string _hostedZoneId;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// (Optional) For your first request to <c>ListHostedZonesByName</c>, include the <c>dnsname</c>
        /// parameter only if you want to specify the name of the first hosted zone in the response.
        /// If you don't include the <c>dnsname</c> parameter, Amazon Route 53 returns all of
        /// the hosted zones that were created by the current Amazon Web Services account, in
        /// ASCII order. For subsequent requests, include both <c>dnsname</c> and <c>hostedzoneid</c>
        /// parameters. For <c>dnsname</c>, specify the value of <c>NextDNSName</c> from the previous
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// (Optional) For your first request to <c>ListHostedZonesByName</c>, do not include
        /// the <c>hostedzoneid</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more hosted zones than the value of <c>maxitems</c>, <c>ListHostedZonesByName</c>
        /// returns only the first <c>maxitems</c> hosted zones. To get the next group of <c>maxitems</c>
        /// hosted zones, submit another request to <c>ListHostedZonesByName</c> and include both
        /// <c>dnsname</c> and <c>hostedzoneid</c> parameters. For the value of <c>hostedzoneid</c>,
        /// specify the value of the <c>NextHostedZoneId</c> element from the previous response.
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

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of hosted zones to be included in the response body for this request.
        /// If you have more than <c>maxitems</c> hosted zones, then the value of the <c>IsTruncated</c>
        /// element in the response is true, and the values of <c>NextDNSName</c> and <c>NextHostedZoneId</c>
        /// specify the first hosted zone in the next group of <c>maxitems</c> hosted zones. 
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