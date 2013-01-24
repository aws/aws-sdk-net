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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para> <i>Alias resource record sets only:</i> Information about the domain to which you are redirecting traffic.</para>
    /// <para><b>NOTE:</b>Currently, Route 53 supports aliases only for Elastic Load Balancing.</para> <para>For more information and an example,
    /// see Creating Alias Resource Record Sets for Elastic Load Balancing in the <i>Amazon Route 53 Developer Guide</i> </para> <para>. </para>
    /// </summary>
    public class AliasTarget  
    {
        
        private string hostedZoneId;
        private string dNSName;

        /// <summary>
        /// <i>Alias resource record sets only:</i> The value of the hosted zone ID, CanonicalHostedZoneNameId, for the LoadBalancer. <note>Currently,
        /// Route 53 supports alias resource record sets only for Elastic Load Balancing.</note> For more information, an example, and several ways to
        /// get the hosted zone ID for the LoadBalancer, see <a
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
        public AliasTarget WithHostedZoneId(string hostedZoneId)
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
        /// <i>Alias resource record sets only:</i> The external DNS name associated with the LoadBalancer. <note>Currently, Route 53 supports alias
        /// resource record sets only for Elastic Load Balancing.</note> For more information, an example, and several ways to get the hosted zone ID
        /// for the LoadBalancer, see <a href="http://docs.amazonwebservices.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating Alias
        /// Resource Record Sets for Elastic Load Balancing</a> in the <i>Amazon Route 53 Developer Guide</i>.
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
        public string DNSName
        {
            get { return this.dNSName; }
            set { this.dNSName = value; }
        }

        /// <summary>
        /// Sets the DNSName property
        /// </summary>
        /// <param name="dNSName">The value to set for the DNSName property </param>
        /// <returns>this instance</returns>
        public AliasTarget WithDNSName(string dNSName)
        {
            this.dNSName = dNSName;
            return this;
        }
            

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this.dNSName != null;       
        }
    }
}
