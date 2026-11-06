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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetHostedZoneLimit operation. Gets the specified
    /// limit for a specified hosted zone, for example, the maximum number of records that
    /// you can create in the hosted zone. <para> For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
    /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
    /// a case</a>. </para>
    /// </summary>
    public partial class GetHostedZoneLimitRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The limit that you want to get. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MAX_RRSETS_BY_ZONE</b>: The maximum number of records that you can create in the
        /// specified hosted zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_VPCS_ASSOCIATED_BY_ZONE</b>: The maximum number of Amazon VPCs that you can
        /// associate with the specified private hosted zone.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public HostedZoneLimitType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone that you want to get a limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;
    }
}
