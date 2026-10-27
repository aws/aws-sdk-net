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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement that inspects web traffic based on the Autonomous System Number (ASN)
    /// associated with the request's IP address.
    /// 
    ///  
    /// <para>
    /// For additional details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-asn-match.html">ASN
    /// match rule statement</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
    /// Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class AsnMatchStatement
    {
        /// <summary>
        /// Gets and sets the property AsnList. 
        /// <para>
        /// Contains one or more Autonomous System Numbers (ASNs). ASNs are unique identifiers
        /// assigned to large internet networks managed by organizations such as internet service
        /// providers, enterprises, universities, or government agencies. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<long> AsnList { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the AsnList property is set.
        /// </summary>
        internal bool IsSetAsnList() => this.AsnList != null && (this.AsnList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ForwardedIPConfig. 
        /// <para>
        /// The configuration for inspecting IP addresses to match against an ASN in an HTTP header
        /// that you specify, instead of using the IP address that's reported by the web request
        /// origin. Commonly, this is the X-Forwarded-For (XFF) header, but you can specify any
        /// header name. 
        /// </para>
        /// </summary>
        public ForwardedIPConfig ForwardedIPConfig { get; set; }

        /// <summary>
        /// Checks to see if the ForwardedIPConfig property is set.
        /// </summary>
        internal bool IsSetForwardedIPConfig() => this.ForwardedIPConfig != null;
    }
}
