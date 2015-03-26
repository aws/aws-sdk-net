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
    /// A complex type that contains the response for the request.
    /// </summary>
    public partial class ListHostedZonesByNameResponse : AmazonWebServiceResponse
    {
        private List<HostedZone> _hostedZones = new List<HostedZone>();
        private string _dnsName;
        private string _hostedZoneId;
        private bool? _isTruncated;
        private string _nextDNSName;
        private string _nextHostedZoneId;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property HostedZones. 
        /// <para>
        /// A complex type that contains information about the hosted zones associated with the
        /// current AWS account.
        /// </para>
        /// </summary>
        public List<HostedZone> HostedZones
        {
            get { return this._hostedZones; }
            set { this._hostedZones = value; }
        }

        // Check to see if HostedZones property is set
        internal bool IsSetHostedZones()
        {
            return this._hostedZones != null && this._hostedZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// The <code>DNSName</code> value sent in the request.
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
        /// The <code>HostedZoneId</code> value sent in the request.
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag indicating whether there are more hosted zones to be listed. If your results
        /// were truncated, you can make a follow-up request for the next page of results by using
        /// the <code>NextDNSName</code> and <code>NextHostedZoneId</code> elements.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code>
        /// </para>
        /// </summary>
        public bool IsTruncated
        {
            get { return this._isTruncated.GetValueOrDefault(); }
            set { this._isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this._isTruncated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextDNSName. 
        /// <para>
        /// If <a>ListHostedZonesByNameResponse$IsTruncated</a> is <code>true</code>, there are
        /// more hosted zones associated with the current AWS account. To get the next page of
        /// results, make another request to <code>ListHostedZonesByName</code>. Specify the value
        /// of <a>ListHostedZonesByNameResponse$NextDNSName</a> in the <a>ListHostedZonesByNameRequest$DNSName</a>
        /// element and <a>ListHostedZonesByNameResponse$NextHostedZoneId</a> in the <a>ListHostedZonesByNameRequest$HostedZoneId</a>
        /// element.
        /// </para>
        /// </summary>
        public string NextDNSName
        {
            get { return this._nextDNSName; }
            set { this._nextDNSName = value; }
        }

        // Check to see if NextDNSName property is set
        internal bool IsSetNextDNSName()
        {
            return this._nextDNSName != null;
        }

        /// <summary>
        /// Gets and sets the property NextHostedZoneId. 
        /// <para>
        /// If <a>ListHostedZonesByNameResponse$IsTruncated</a> is <code>true</code>, there are
        /// more hosted zones associated with the current AWS account. To get the next page of
        /// results, make another request to <code>ListHostedZonesByName</code>. Specify the value
        /// of <a>ListHostedZonesByNameResponse$NextDNSName</a> in the <a>ListHostedZonesByNameRequest$DNSName</a>
        /// element and <a>ListHostedZonesByNameResponse$NextHostedZoneId</a> in the <a>ListHostedZonesByNameRequest$HostedZoneId</a>
        /// element.
        /// </para>
        /// </summary>
        public string NextHostedZoneId
        {
            get { return this._nextHostedZoneId; }
            set { this._nextHostedZoneId = value; }
        }

        // Check to see if NextHostedZoneId property is set
        internal bool IsSetNextHostedZoneId()
        {
            return this._nextHostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of hosted zones to be included in the response body. If the number
        /// of hosted zones associated with this AWS account exceeds <code>MaxItems</code>, the
        /// value of <a>ListHostedZonesByNameResponse$IsTruncated</a> in the response is <code>true</code>.
        /// Call <code>ListHostedZonesByName</code> again and specify the value of <a>ListHostedZonesByNameResponse$NextDNSName</a>
        /// and <a>ListHostedZonesByNameResponse$NextHostedZoneId</a> elements respectively to
        /// get the next page of results.
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