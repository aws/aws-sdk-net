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
    /// Container for the parameters to the ChangeResourceRecordSets operation.
    /// Use this action to create or change your authoritative DNS information. To use this
    /// action, send a <code>POST</code> request to the <code>2013-04-01/hostedzone/<i>hosted
    /// Zone ID</i>/rrset</code> resource. The request body must include an XML document with
    /// a <code>ChangeResourceRecordSetsRequest</code> element.
    /// 
    ///  
    /// <para>
    /// Changes are a list of change items and are considered transactional. For more information
    /// on transactional changes, also known as change batches, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/RRSchanges.html#RRSchanges_API">Creating,
    /// Changing, and Deleting Resource Record Sets Using the Route 53 API</a> in the <i>Amazon
    /// Route 53 Developer Guide</i>.
    /// </para>
    ///  <important>Due to the nature of transactional changes, you cannot delete the same
    /// resource record set more than once in a single change batch. If you attempt to delete
    /// the same change batch more than once, Route 53 returns an <code>InvalidChangeBatch</code>
    /// error.</important> 
    /// <para>
    /// In response to a <code>ChangeResourceRecordSets</code> request, your DNS data is changed
    /// on all Route 53 DNS servers. Initially, the status of a change is <code>PENDING</code>.
    /// This means the change has not yet propagated to all the authoritative Route 53 DNS
    /// servers. When the change is propagated to all hosts, the change returns a status of
    /// <code>INSYNC</code>.
    /// </para>
    ///  
    /// <para>
    /// Note the following limitations on a <code>ChangeResourceRecordSets</code> request:
    /// </para>
    ///  
    /// <para>
    /// - A request cannot contain more than 100 Change elements.
    /// </para>
    ///  
    /// <para>
    /// - A request cannot contain more than 1000 ResourceRecord elements.
    /// </para>
    ///  
    /// <para>
    /// The sum of the number of characters (including spaces) in all <code>Value</code> elements
    /// in a request cannot exceed 32,000 characters.
    /// </para>
    /// </summary>
    public partial class ChangeResourceRecordSetsRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private ChangeBatch _changeBatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeResourceRecordSetsRequest() { }

        /// <summary>
        /// Instantiates ChangeResourceRecordSetsRequest with the parameterized properties
        /// </summary>
        /// <param name="hostedZoneId"> The ID of the hosted zone that contains the resource record sets that you want to change.</param>
        /// <param name="changeBatch">A complex type that contains an optional comment and the <code>Changes</code> element.</param>
        public ChangeResourceRecordSetsRequest(string hostedZoneId, ChangeBatch changeBatch)
        {
            _hostedZoneId = hostedZoneId;
            _changeBatch = changeBatch;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        ///  The ID of the hosted zone that contains the resource record sets that you want to
        /// change.
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
        /// Gets and sets the property ChangeBatch. 
        /// <para>
        /// A complex type that contains an optional comment and the <code>Changes</code> element.
        /// </para>
        /// </summary>
        public ChangeBatch ChangeBatch
        {
            get { return this._changeBatch; }
            set { this._changeBatch = value; }
        }

        // Check to see if ChangeBatch property is set
        internal bool IsSetChangeBatch()
        {
            return this._changeBatch != null;
        }

    }
}