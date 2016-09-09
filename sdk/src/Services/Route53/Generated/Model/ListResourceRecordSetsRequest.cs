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
    /// Container for the parameters to the ListResourceRecordSets operation.
    /// 
    /// </summary>
    public partial class ListResourceRecordSetsRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _startRecordName;
        private RRType _startRecordType;
        private string _startRecordIdentifier;
        private string _maxItems;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListResourceRecordSetsRequest() { }

        /// <summary>
        /// Instantiates ListResourceRecordSetsRequest with the parameterized properties
        /// </summary>
        /// <param name="hostedZoneId">The ID of the hosted zone that contains the resource record sets that you want to get.</param>
        public ListResourceRecordSetsRequest(string hostedZoneId)
        {
            _hostedZoneId = hostedZoneId;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the resource record sets that you want to
        /// get.
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
        /// Gets and sets the property StartRecordName. 
        /// <para>
        /// The first name in the lexicographic ordering of domain names that you want the <code>ListResourceRecordSets</code>
        /// request to list.
        /// </para>
        /// </summary>
        public string StartRecordName
        {
            get { return this._startRecordName; }
            set { this._startRecordName = value; }
        }

        // Check to see if StartRecordName property is set
        internal bool IsSetStartRecordName()
        {
            return this._startRecordName != null;
        }

        /// <summary>
        /// Gets and sets the property StartRecordType. 
        /// <para>
        /// The type of resource record set to begin the record listing from.
        /// </para>
        ///  
        /// <para>
        /// Valid values for basic resource record sets: <code>A</code> | <code>AAAA</code> |
        /// <code>CNAME</code> | <code>MX</code> | <code>NAPTR</code> | <code>NS</code> | <code>PTR</code>
        /// | <code>SOA</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code> 
        /// </para>
        ///  
        /// <para>
        /// Values for weighted, latency, geo, and failover resource record sets: <code>A</code>
        /// | <code>AAAA</code> | <code>CNAME</code> | <code>MX</code> | <code>NAPTR</code> |
        /// <code>PTR</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code> 
        /// </para>
        ///  
        /// <para>
        /// Values for alias resource record sets: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CloudFront distribution</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Beanstalk environment that has a regionalized subdomain</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ELB load balancer</b>: A | AAAA
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon S3 bucket</b>: A
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Constraint: Specifying <code>type</code> without specifying <code>name</code> returns
        /// an <code>InvalidInput</code> error.
        /// </para>
        /// </summary>
        public RRType StartRecordType
        {
            get { return this._startRecordType; }
            set { this._startRecordType = value; }
        }

        // Check to see if StartRecordType property is set
        internal bool IsSetStartRecordType()
        {
            return this._startRecordType != null;
        }

        /// <summary>
        /// Gets and sets the property StartRecordIdentifier. 
        /// <para>
        ///  <i>Weighted resource record sets only:</i> If results were truncated for a given
        /// DNS name and type, specify the value of <code>NextRecordIdentifier</code> from the
        /// previous response to get the next resource record set that has the current DNS name
        /// and type.
        /// </para>
        /// </summary>
        public string StartRecordIdentifier
        {
            get { return this._startRecordIdentifier; }
            set { this._startRecordIdentifier = value; }
        }

        // Check to see if StartRecordIdentifier property is set
        internal bool IsSetStartRecordIdentifier()
        {
            return this._startRecordIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// (Optional) The maximum number of resource records sets to include in the response
        /// body for this request. If the response includes more than <code>maxitems</code> resource
        /// record sets, the value of the <code>IsTruncated</code> element in the response is
        /// <code>true</code>, and the values of the <code>NextRecordName</code> and <code>NextRecordType</code>
        /// elements in the response identify the first resource record set in the next group
        /// of <code>maxitems</code> resource record sets.
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