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
    /// Container for the parameters to the ChangeResourceRecordSets operation.
    /// <para>Use this action to create or change your authoritative DNS information. To use this action, send a <c>POST</c> request to the
    /// <c>2012-12-12/hostedzone/hosted Zone ID/rrset</c> resource. The request body must include an XML document with a
    /// <c>ChangeResourceRecordSetsRequest</c> element.</para> <para>Changes are a list of change items and are considered transactional. For more
    /// information on transactional changes, also known as change batches, see Creating, Changing, and Deleting Resource Record Sets Using the
    /// Route 53 API in the <i>Amazon Route 53 Developer Guide</i> .</para> <para><b>IMPORTANT:</b>Due to the nature of transactional changes, you
    /// cannot delete the same resource record set more than once in a single change batch. If you attempt to delete the same change batch more than
    /// once, Route 53 returns an InvalidChangeBatch error.</para> <para>In response to a <c>ChangeResourceRecordSets</c> request, your DNS data is
    /// changed on all Route 53 DNS servers. Initially, the status of a change is <c>PENDING</c> . This means the change has not yet propagated to
    /// all the authoritative Route 53 DNS servers. When the change is propagated to all hosts, the change returns a status of <c>INSYNC</c>
    /// .</para> <para>Note the following limitations on a <c>ChangeResourceRecordSets</c> request:</para> <para>- A request cannot contain more
    /// than 100 Change elements.</para> <para>- A request cannot contain more than 1000 ResourceRecord elements.</para> <para>The sum of the number
    /// of characters (including spaces) in all <c>Value</c> elements in a request cannot exceed 32,000 characters.</para>
    /// </summary>
    /// <seealso cref="Amazon.Route53.AmazonRoute53.ChangeResourceRecordSets"/>
    public class ChangeResourceRecordSetsRequest : AmazonWebServiceRequest
    {
        private string hostedZoneId;
        private ChangeBatch changeBatch;

        /// <summary>
        /// <i>Alias resource record sets only:</i> The value of the hosted zone ID for the AWS resource. For more information, an example, and several
        /// ways to get the hosted zone ID for the LoadBalancer, see <a
        /// href="http://docs.amazonwebservices.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating Alias Resource Record Sets for
        /// Elastic Load Balancing</a> in the <i>Amazon Route 53 Developer Guide</i>.
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

        /// <summary>
        /// Sets the HostedZoneId property
        /// </summary>
        /// <param name="hostedZoneId">The value to set for the HostedZoneId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ChangeResourceRecordSetsRequest WithHostedZoneId(string hostedZoneId)
        {
            this.hostedZoneId = hostedZoneId;
            return this;
        }
            

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this.hostedZoneId != null;
        }

        /// <summary>
        /// A complex type that contains an optional comment and the <c>Changes</c> element.
        ///  
        /// </summary>
        public ChangeBatch ChangeBatch
        {
            get { return this.changeBatch; }
            set { this.changeBatch = value; }
        }

        /// <summary>
        /// Sets the ChangeBatch property
        /// </summary>
        /// <param name="changeBatch">The value to set for the ChangeBatch property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ChangeResourceRecordSetsRequest WithChangeBatch(ChangeBatch changeBatch)
        {
            this.changeBatch = changeBatch;
            return this;
        }
            

        // Check to see if ChangeBatch property is set
        internal bool IsSetChangeBatch()
        {
            return this.changeBatch != null;
        }
    }
}
    
