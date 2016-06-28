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
    /// List the resource record sets in a specified hosted zone. Send a GET request to the
    /// <code>2013-04-01/hostedzone/<i>hosted zone ID</i>/rrset</code> resource.
    /// 
    ///  
    /// <para>
    /// <code>ListResourceRecordSets</code> returns up to 100 resource record sets at a time
    /// in ASCII order, beginning at a position specified by the name and type elements. The
    /// action sorts results first by DNS name with the labels reversed, for example:
    /// </para>
    ///  
    /// <para>
    /// <code>com.example.www.</code>
    /// </para>
    ///  
    /// <para>
    /// Note the trailing dot, which can change the sort order in some circumstances. When
    /// multiple records have the same DNS name, the action sorts results by the record type.
    /// </para>
    ///  
    /// <para>
    /// You can use the name and type elements to adjust the beginning position of the list
    /// of resource record sets returned:
    /// </para>
    ///  <ul> <li><b>If you do not specify <code>Name</code> or <code>Type</code></b>: The
    /// results begin with the first resource record set that the hosted zone contains.</li>
    /// <li><b>If you specify <code>Name</code> but not <code>Type</code></b>: The results
    /// begin with the first resource record set in the list whose name is greater than or
    /// equal to Name.</li> <li><b>If you specify <code>Type</code> but not <code>Name</code></b>:
    /// Amazon Route 53 returns the <code>InvalidInput</code> error.</li> <li><b>If you specify
    /// both <code>Name</code> and <code>Type</code></b>: The results begin with the first
    /// resource record set in the list whose name is greater than or equal to <code>Name</code>,
    /// and whose type is greater than or equal to <code>Type</code>.</li> </ul> 
    /// <para>
    /// This action returns the most current version of the records. This includes records
    /// that are <code>PENDING</code>, and that are not yet available on all Amazon Route
    /// 53 DNS servers.
    /// </para>
    ///  
    /// <para>
    /// To ensure that you get an accurate listing of the resource record sets for a hosted
    /// zone at a point in time, do not submit a <code>ChangeResourceRecordSets</code> request
    /// while you are paging through the results of a <code>ListResourceRecordSets</code>
    /// request. If you do, some pages may display results without the latest changes while
    /// other pages display results with the latest changes.
    /// </para>
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
        /// The DNS type at which to begin the listing of resource record sets. 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>A</code> | <code>AAAA</code> | <code>CNAME</code> | <code>MX</code>
        /// | <code>NS</code> | <code>PTR</code> | <code>SOA</code> | <code>SPF</code> | <code>SRV</code>
        /// | <code>TXT</code>
        /// </para>
        ///  
        /// <para>
        /// Values for Weighted Resource Record Sets: <code>A</code> | <code>AAAA</code> | <code>CNAME</code>
        /// | <code>TXT</code>
        /// </para>
        ///  
        /// <para>
        /// Values for Regional Resource Record Sets: <code>A</code> | <code>AAAA</code> | <code>CNAME</code>
        /// | <code>TXT</code>
        /// </para>
        ///  
        /// <para>
        /// Values for Alias Resource Record Sets: <code>A</code> | <code>AAAA</code>
        /// </para>
        ///  
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
        /// <i>Weighted resource record sets only:</i> If results were truncated for a given DNS
        /// name and type, specify the value of <code>NextRecordIdentifier</code> from the previous
        /// response to get the next resource record set that has the current DNS name and type.
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
        /// The maximum number of records you want in the response body.
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