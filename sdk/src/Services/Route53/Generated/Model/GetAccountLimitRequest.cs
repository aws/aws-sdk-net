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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccountLimit operation.
    /// Gets the specified limit for the current account, for example, the maximum number
    /// of health checks that you can create using the account.
    /// 
    ///  
    /// <para>
    /// For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
    /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
    /// a case</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can also view account limits in Amazon Web Services Trusted Advisor. Sign in to
    /// the Amazon Web Services Management Console and open the Trusted Advisor console at
    /// <a href="https://console.aws.amazon.com/trustedadvisor">https://console.aws.amazon.com/trustedadvisor/</a>.
    /// Then choose <b>Service limits</b> in the navigation pane.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetAccountLimitRequest : AmazonRoute53Request
    {
        private AccountLimitType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The limit that you want to get. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>MAX_HEALTH_CHECKS_BY_OWNER</b>: The maximum number of health checks that you can
        /// create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_HOSTED_ZONES_BY_OWNER</b>: The maximum number of hosted zones that you can
        /// create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_REUSABLE_DELEGATION_SETS_BY_OWNER</b>: The maximum number of reusable delegation
        /// sets that you can create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_TRAFFIC_POLICIES_BY_OWNER</b>: The maximum number of traffic policies that
        /// you can create using the current account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>MAX_TRAFFIC_POLICY_INSTANCES_BY_OWNER</b>: The maximum number of traffic policy
        /// instances that you can create using the current account. (Traffic policy instances
        /// are referred to as traffic flow policy records in the Amazon Route 53 console.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountLimitType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}