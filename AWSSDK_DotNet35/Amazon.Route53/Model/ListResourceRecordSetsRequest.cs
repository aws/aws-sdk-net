/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Imagine all the resource record sets in a zone listed out in front of you. Imagine them sorted lexicographically first by DNS name
    /// (with the labels reversed, like "com.amazon.www" for example), and secondarily, lexicographically by record type. This operation retrieves
    /// at most MaxItems resource record sets from this list, in order, starting at a position specified by the Name and Type arguments:</para>
    /// <ul>
    /// <li>If both Name and Type are omitted, this means start the results at the first RRSET in the HostedZone.</li>
    /// <li>If Name is specified but Type is omitted, this means start the results at the first RRSET in the list whose name is greater than or
    /// equal to Name. </li>
    /// <li>If both Name and Type are specified, this means start the results at the first RRSET in the list whose name is greater than or equal to
    /// Name and whose type is greater than or equal to Type.</li>
    /// <li>It is an error to specify the Type but not the Name.</li>
    /// 
    /// </ul>
    /// <para>Use ListResourceRecordSets to retrieve a single known record set by specifying the record set's name and type, and setting MaxItems =
    /// 1</para> <para>To retrieve all the records in a HostedZone, first pause any processes making calls to ChangeResourceRecordSets. Initially
    /// call ListResourceRecordSets without a Name and Type to get the first page of record sets. For subsequent calls, set Name and Type to the
    /// NextName and NextType values returned by the previous response. </para> <para>In the presence of concurrent ChangeResourceRecordSets calls,
    /// there is no consistency of results across calls to ListResourceRecordSets. The only way to get a consistent multi-page snapshot of all
    /// RRSETs in a zone is to stop making changes while pagination is in progress.</para> <para>However, the results from ListResourceRecordSets
    /// are consistent within a page. If MakeChange calls are taking place concurrently, the result of each one will either be completely visible in
    /// your results or not at all. You will not see partial changes, or changes that do not ultimately succeed. (This follows from the fact that
    /// MakeChange is atomic) </para> <para>The results from ListResourceRecordSets are strongly consistent with ChangeResourceRecordSets. To be
    /// precise, if a single process makes a call to ChangeResourceRecordSets and receives a successful response, the effects of that change will be
    /// visible in a subsequent call to ListResourceRecordSets by that process.</para>
    /// </summary>
    public partial class ListResourceRecordSetsRequest : AmazonWebServiceRequest
    {
        private string hostedZoneId;
        private string startRecordName;
        private RRType startRecordType;
        private string startRecordIdentifier;
        private string maxItems;

        /// <summary>
        /// The ID of the hosted zone that contains the resource record sets that you want to get.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this.hostedZoneId; }
            set { this.hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this.hostedZoneId != null;
        }

        /// <summary>
        /// The first name in the lexicographic ordering of domain names that you want the <c>ListResourceRecordSets</c> request to list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartRecordName
        {
            get { return this.startRecordName; }
            set { this.startRecordName = value; }
        }

        // Check to see if StartRecordName property is set
        internal bool IsSetStartRecordName()
        {
            return this.startRecordName != null;
        }

        /// <summary>
        /// The DNS type at which to begin the listing of resource record sets. Valid values: <c>A</c> | <c>AAAA</c> | <c>CNAME</c> | <c>MX</c> |
        /// <c>NS</c> | <c>PTR</c> | <c>SOA</c> | <c>SPF</c> | <c>SRV</c> | <c>TXT</c> Values for Weighted Resource Record Sets: <c>A</c> | <c>AAAA</c>
        /// | <c>CNAME</c> | <c>TXT</c> Values for Regional Resource Record Sets: <c>A</c> | <c>AAAA</c> | <c>CNAME</c> | <c>TXT</c> Values for Alias
        /// Resource Record Sets: <c>A</c> | <c>AAAA</c> Constraint: Specifying <c>type</c> without specifying <c>name</c> returns an
        /// <a>InvalidInput</a> error.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SOA, A, TXT, NS, CNAME, MX, PTR, SRV, SPF, AAAA</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RRType StartRecordType
        {
            get { return this.startRecordType; }
            set { this.startRecordType = value; }
        }

        // Check to see if StartRecordType property is set
        internal bool IsSetStartRecordType()
        {
            return this.startRecordType != null;
        }

        /// <summary>
        /// <i>Weighted resource record sets only:</i> If results were truncated for a given DNS name and type, specify the value of
        /// <c>ListResourceRecordSetsResponse$NextRecordIdentifier</c> from the previous response to get the next resource record set that has the
        /// current DNS name and type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string StartRecordIdentifier
        {
            get { return this.startRecordIdentifier; }
            set { this.startRecordIdentifier = value; }
        }

        // Check to see if StartRecordIdentifier property is set
        internal bool IsSetStartRecordIdentifier()
        {
            return this.startRecordIdentifier != null;
        }

        /// <summary>
        /// The maximum number of records you want in the response body.
        ///  
        /// </summary>
        public string MaxItems
        {
            get { return this.maxItems; }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems != null;
        }

    }
}
    
