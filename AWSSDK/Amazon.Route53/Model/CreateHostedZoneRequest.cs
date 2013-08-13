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
    /// Container for the parameters to the CreateHostedZone operation.
    /// <para> This action creates a new hosted zone.</para> <para>To create a new hosted zone, send a <c>POST</c> request to the
    /// <c>2012-12-12/hostedzone</c> resource. The request body must include an XML document with a <c>CreateHostedZoneRequest</c> element. The
    /// response returns the <c>CreateHostedZoneResponse</c> element that contains metadata about the hosted zone.</para> <para>Route 53
    /// automatically creates a default SOA record and four NS records for the zone. The NS records in the hosted zone are the name servers you give
    /// your registrar to delegate your domain to. For more information about SOA and NS records, see NS and SOA Records that Route 53 Creates for a
    /// Hosted Zone in the <i>Amazon Route 53 Developer Guide</i> .</para> <para>When you create a zone, its initial status is <c>PENDING</c> . This
    /// means that it is not yet available on all DNS servers. The status of the zone changes to <c>INSYNC</c> when the NS and SOA records are
    /// available on all Route 53 DNS servers. </para>
    /// </summary>
    /// <seealso cref="Amazon.Route53.AmazonRoute53.CreateHostedZone"/>
    public class CreateHostedZoneRequest : AmazonWebServiceRequest
    {
        private string name;
        private string callerReference;
        private HostedZoneConfig hostedZoneConfig;

        /// <summary>
        /// The name of the domain. This must be a fully-specified domain, for example, www.example.com. The trailing dot is optional; Route 53 assumes
        /// that the domain name is fully qualified. This means that Route 53 treats www.example.com (without a trailing dot) and www.example.com. (with
        /// a trailing dot) as identical. This is the name you have registered with your DNS registrar. You should ask your registrar to change the
        /// authoritative name servers for your domain to the set of <c>NameServers</c> elements returned in <c>DelegationSet</c>.
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
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHostedZoneRequest WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A unique string that identifies the request and that allows failed <c>CreateHostedZone</c> requests to be retried without the risk of
        /// executing the operation twice. You must use a unique <c>CallerReference</c> string every time you create a hosted zone.
        /// <c>CallerReference</c> can be any unique string; you might choose to use a string that identifies your project, such as
        /// <c>DNSMigration_01</c>. Valid characters are any Unicode code points that are legal in an XML 1.0 document. The UTF-8 encoding of the value
        /// must be less than 128 bytes.
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
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">The value to set for the CallerReference property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHostedZoneRequest WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }
            

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this.callerReference != null;
        }

        /// <summary>
        /// A complex type that contains an optional comment about your hosted zone.
        ///  
        /// </summary>
        public HostedZoneConfig HostedZoneConfig
        {
            get { return this.hostedZoneConfig; }
            set { this.hostedZoneConfig = value; }
        }

        /// <summary>
        /// Sets the HostedZoneConfig property
        /// </summary>
        /// <param name="hostedZoneConfig">The value to set for the HostedZoneConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHostedZoneRequest WithHostedZoneConfig(HostedZoneConfig hostedZoneConfig)
        {
            this.hostedZoneConfig = hostedZoneConfig;
            return this;
        }
            

        // Check to see if HostedZoneConfig property is set
        internal bool IsSetHostedZoneConfig()
        {
            return this.hostedZoneConfig != null;
        }
    }
}
    
