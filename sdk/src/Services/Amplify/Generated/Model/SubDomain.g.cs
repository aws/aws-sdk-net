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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The subdomain for the domain association.
    /// </summary>
    public partial class SubDomain
    {
        /// <summary>
        /// Gets and sets the property DnsRecord. 
        /// <para>
        ///  The DNS record for the subdomain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// Checks to see if the DnsRecord property is set.
        /// </summary>
        internal bool IsSetDnsRecord() => this.DnsRecord != null;

        /// <summary>
        /// Gets and sets the property SubDomainSetting. 
        /// <para>
        ///  Describes the settings for the subdomain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubDomainSetting SubDomainSetting { get; set; }

        /// <summary>
        /// Checks to see if the SubDomainSetting property is set.
        /// </summary>
        internal bool IsSetSubDomainSetting() => this.SubDomainSetting != null;

        /// <summary>
        /// Gets and sets the property Verified. 
        /// <para>
        ///  The verified status of the subdomain 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Verified { get; set; }

        /// <summary>
        /// Checks to see if the Verified property is set.
        /// </summary>
        internal bool IsSetVerified() => this.Verified.HasValue;
    }
}
