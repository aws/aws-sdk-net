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
    /// A complex type that contains the response information for the request.
    /// </summary>
    public partial class ListHostedZonesByNameResponse : AmazonWebServiceResponse
    {
        private List<HostedZone> _hostedZones = AWSConfigs.InitializeCollections ? new List<HostedZone>() : null;
        private string _dnsName;
        private string _hostedZoneId;
        private bool? _isTruncated;
        private string _nextDNSName;
        private string _nextHostedZoneId;
        private string _maxItems;

        /// <summary>
        /// Gets and sets the property HostedZones. 
        /// <para>
        /// A complex type that contains general information about the hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HostedZone> HostedZones
        {
            get { return this._hostedZones; }
            set { this._hostedZones = value; }
        }

        // Check to see if HostedZones property is set
        internal bool IsSetHostedZones()
        {
            return this._hostedZones != null && (this._hostedZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DNSName. 
        /// <para>
        /// For the second and subsequent calls to <c>ListHostedZonesByName</c>, <c>DNSName</c>
        /// is the value that you specified for the <c>dnsname</c> parameter in the request that
        /// produced the current response.
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
        /// The ID that Amazon Route 53 assigned to the hosted zone when you created it.
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
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether there are more hosted zones to be listed. If the response
        /// was truncated, you can get the next group of <c>maxitems</c> hosted zones by calling
        /// <c>ListHostedZonesByName</c> again and specifying the values of <c>NextDNSName</c>
        /// and <c>NextHostedZoneId</c> elements in the <c>dnsname</c> and <c>hostedzoneid</c>
        /// parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsTruncated
        {
            get { return this._isTruncated; }
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
        /// If <c>IsTruncated</c> is true, the value of <c>NextDNSName</c> is the name of the
        /// first hosted zone in the next group of <c>maxitems</c> hosted zones. Call <c>ListHostedZonesByName</c>
        /// again and specify the value of <c>NextDNSName</c> and <c>NextHostedZoneId</c> in the
        /// <c>dnsname</c> and <c>hostedzoneid</c> parameters, respectively.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// If <c>IsTruncated</c> is <c>true</c>, the value of <c>NextHostedZoneId</c> identifies
        /// the first hosted zone in the next group of <c>maxitems</c> hosted zones. Call <c>ListHostedZonesByName</c>
        /// again and specify the value of <c>NextDNSName</c> and <c>NextHostedZoneId</c> in the
        /// <c>dnsname</c> and <c>hostedzoneid</c> parameters, respectively.
        /// </para>
        ///  
        /// <para>
        /// This element is present only if <c>IsTruncated</c> is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
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
        /// The value that you specified for the <c>maxitems</c> parameter in the call to <c>ListHostedZonesByName</c>
        /// that produced the current response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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