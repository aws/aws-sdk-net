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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceRecordSets operation.
    /// Lists the resource record sets in a specified hosted zone.
    /// 
    ///  
    /// <para>
    ///  <code>ListResourceRecordSets</code> returns up to 100 resource record sets at a time
    /// in ASCII order, beginning at a position specified by the <code>name</code> and <code>type</code>
    /// elements.
    /// </para>
    ///  
    /// <para>
    ///  <b>Sort order</b> 
    /// </para>
    ///  
    /// <para>
    ///  <code>ListResourceRecordSets</code> sorts results first by DNS name with the labels
    /// reversed, for example:
    /// </para>
    ///  
    /// <para>
    ///  <code>com.example.www.</code> 
    /// </para>
    ///  
    /// <para>
    /// Note the trailing dot, which can change the sort order when the record name contains
    /// characters that appear before <code>.</code> (decimal 46) in the ASCII table. These
    /// characters include the following: <code>! " # $ % &amp; ' ( ) * + , -</code> 
    /// </para>
    ///  
    /// <para>
    /// When multiple records have the same DNS name, <code>ListResourceRecordSets</code>
    /// sorts results by the record type.
    /// </para>
    ///  
    /// <para>
    ///  <b>Specifying where to start listing records</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use the name and type elements to specify the resource record set that the
    /// list begins with:
    /// </para>
    ///  <dl> <dt>If you do not specify Name or Type</dt> <dd> 
    /// <para>
    /// The results begin with the first resource record set that the hosted zone contains.
    /// </para>
    ///  </dd> <dt>If you specify Name but not Type</dt> <dd> 
    /// <para>
    /// The results begin with the first resource record set in the list whose name is greater
    /// than or equal to <code>Name</code>.
    /// </para>
    ///  </dd> <dt>If you specify Type but not Name</dt> <dd> 
    /// <para>
    /// Amazon Route 53 returns the <code>InvalidInput</code> error.
    /// </para>
    ///  </dd> <dt>If you specify both Name and Type</dt> <dd> 
    /// <para>
    /// The results begin with the first resource record set in the list whose name is greater
    /// than or equal to <code>Name</code>, and whose type is greater than or equal to <code>Type</code>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    ///  <b>Resource record sets that are PENDING</b> 
    /// </para>
    ///  
    /// <para>
    /// This action returns the most current version of the records. This includes records
    /// that are <code>PENDING</code>, and that are not yet available on all Route 53 DNS
    /// servers.
    /// </para>
    ///  
    /// <para>
    ///  <b>Changing resource record sets</b> 
    /// </para>
    ///  
    /// <para>
    /// To ensure that you get an accurate listing of the resource record sets for a hosted
    /// zone at a point in time, do not submit a <code>ChangeResourceRecordSets</code> request
    /// while you're paging through the results of a <code>ListResourceRecordSets</code> request.
    /// If you do, some pages may display results without the latest changes while other pages
    /// display results with the latest changes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Displaying the next page of results</b> 
    /// </para>
    ///  
    /// <para>
    /// If a <code>ListResourceRecordSets</code> command returns more than one page of results,
    /// the value of <code>IsTruncated</code> is <code>true</code>. To display the next page
    /// of results, get the values of <code>NextRecordName</code>, <code>NextRecordType</code>,
    /// and <code>NextRecordIdentifier</code> (if any) from the response. Then submit another
    /// <code>ListResourceRecordSets</code> request, and specify those values for <code>StartRecordName</code>,
    /// <code>StartRecordType</code>, and <code>StartRecordIdentifier</code>.
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
        /// <param name="hostedZoneId">The ID of the hosted zone that contains the resource record sets that you want to list.</param>
        public ListResourceRecordSetsRequest(string hostedZoneId)
        {
            _hostedZoneId = hostedZoneId;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that contains the resource record sets that you want to
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        /// The first name in the lexicographic ordering of resource record sets that you want
        /// to list. If the specified record name doesn't exist, the results begin with the first
        /// resource record set that has a name greater than the value of <code>name</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// <code>CAA</code> | <code>CNAME</code> | <code>MX</code> | <code>NAPTR</code> | <code>NS</code>
        /// | <code>PTR</code> | <code>SOA</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Values for weighted, latency, geolocation, and failover resource record sets: <code>A</code>
        /// | <code>AAAA</code> | <code>CAA</code> | <code>CNAME</code> | <code>MX</code> | <code>NAPTR</code>
        /// | <code>PTR</code> | <code>SPF</code> | <code>SRV</code> | <code>TXT</code> 
        /// </para>
        ///  
        /// <para>
        /// Values for alias resource record sets: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>API Gateway custom regional API or edge-optimized API</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CloudFront distribution</b>: A or AAAA
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Beanstalk environment that has a regionalized subdomain</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Elastic Load Balancing load balancer</b>: A | AAAA
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>S3 bucket</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>VPC interface VPC endpoint</b>: A
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Another resource record set in this hosted zone:</b> The type of the resource
        /// record set that the alias references.
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
        ///  <i>Resource record sets that have a routing policy other than simple:</i> If results
        /// were truncated for a given DNS name and type, specify the value of <code>NextRecordIdentifier</code>
        /// from the previous response to get the next resource record set that has the current
        /// DNS name and type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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