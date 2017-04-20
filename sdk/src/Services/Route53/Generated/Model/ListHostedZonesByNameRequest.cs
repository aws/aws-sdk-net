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
    /// Retrieves a list of your hosted zones in lexicographic order. The response includes
    /// a <code>HostedZones</code> child element for each hosted zone created by the current
    /// AWS account. 
    /// 
    ///  
    /// <para>
    ///  <code>ListHostedZonesByName</code> sorts hosted zones by name with the labels reversed.
    /// For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>com.example.www.</code> 
    /// </para>
    ///  
    /// <para>
    /// Note the trailing dot, which can change the sort order in some circumstances.
    /// </para>
    ///  
    /// <para>
    /// If the domain name includes escape characters or Punycode, <code>ListHostedZonesByName</code>
    /// alphabetizes the domain name using the escaped or Punycoded value, which is the format
    /// that Amazon Route 53 saves in its database. For example, to create a hosted zone for
    /// exämple.com, you specify ex\344mple.com for the domain name. <code>ListHostedZonesByName</code>
    /// alphabetizes it as:
    /// </para>
    ///  
    /// <para>
    ///  <code>com.ex\344mple.</code> 
    /// </para>
    ///  
    /// <para>
    /// The labels are reversed and alphabetized using the escaped value. For more information
    /// about valid domain name formats, including internationalized domain names, see <a
    /// href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DomainNameFormat.html">DNS
    /// Domain Name Format</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Route 53 returns up to 100 items in each response. If you have a lot of hosted
    /// zones, use the <code>MaxItems</code> parameter to list them in groups of up to 100.
    /// The response includes values that help navigate from one group of <code>MaxItems</code>
    /// hosted zones to the next:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>DNSName</code> and <code>HostedZoneId</code> elements in the response contain
    /// the values, if any, specified for the <code>dnsname</code> and <code>hostedzoneid</code>
    /// parameters in the request that produced the current response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>MaxItems</code> element in the response contains the value, if any, that
    /// you specified for the <code>maxitems</code> parameter in the request that produced
    /// the current response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the value of <code>IsTruncated</code> in the response is true, there are more hosted
    /// zones associated with the current AWS account. 
    /// </para>
    ///  
    /// <para>
    /// If <code>IsTruncated</code> is false, this response includes the last hosted zone
    /// that is associated with the current account. The <code>NextDNSName</code> element
    /// and <code>NextHostedZoneId</code> elements are omitted from the response.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>NextDNSName</code> and <code>NextHostedZoneId</code> elements in the response
    /// contain the domain name and the hosted zone ID of the next hosted zone that is associated
    /// with the current AWS account. If you want to list more hosted zones, make another
    /// call to <code>ListHostedZonesByName</code>, and specify the value of <code>NextDNSName</code>
    /// and <code>NextHostedZoneId</code> in the <code>dnsname</code> and <code>hostedzoneid</code>
    /// parameters, respectively.
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
        /// (Optional) For your first request to <code>ListHostedZonesByName</code>, include the
        /// <code>dnsname</code> parameter only if you want to specify the name of the first hosted
        /// zone in the response. If you don't include the <code>dnsname</code> parameter, Amazon
        /// Route 53 returns all of the hosted zones that were created by the current AWS account,
        /// in ASCII order. For subsequent requests, include both <code>dnsname</code> and <code>hostedzoneid</code>
        /// parameters. For <code>dnsname</code>, specify the value of <code>NextDNSName</code>
        /// from the previous response.
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
        /// (Optional) For your first request to <code>ListHostedZonesByName</code>, do not include
        /// the <code>hostedzoneid</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you have more hosted zones than the value of <code>maxitems</code>, <code>ListHostedZonesByName</code>
        /// returns only the first <code>maxitems</code> hosted zones. To get the next group of
        /// <code>maxitems</code> hosted zones, submit another request to <code>ListHostedZonesByName</code>
        /// and include both <code>dnsname</code> and <code>hostedzoneid</code> parameters. For
        /// the value of <code>hostedzoneid</code>, specify the value of the <code>NextHostedZoneId</code>
        /// element from the previous response.
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
        /// The maximum number of hosted zones to be included in the response body for this request.
        /// If you have more than <code>maxitems</code> hosted zones, then the value of the <code>IsTruncated</code>
        /// element in the response is true, and the values of <code>NextDNSName</code> and <code>NextHostedZoneId</code>
        /// specify the first hosted zone in the next group of <code>maxitems</code> hosted zones.
        /// 
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