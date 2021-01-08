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
    /// Container for the parameters to the GetReusableDelegationSetLimit operation.
    /// Gets the maximum number of hosted zones that you can associate with the specified
    /// reusable delegation set.
    /// 
    ///  
    /// <para>
    /// For the default limit, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html">Limits</a>
    /// in the <i>Amazon Route 53 Developer Guide</i>. To request a higher limit, <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-route53">open
    /// a case</a>.
    /// </para>
    /// </summary>
    public partial class GetReusableDelegationSetLimitRequest : AmazonRoute53Request
    {
        private ReusableDelegationSetLimitType _type;
        private string _delegationSetId;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specify <code>MAX_ZONES_BY_REUSABLE_DELEGATION_SET</code> to get the maximum number
        /// of hosted zones that you can associate with the specified reusable delegation set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReusableDelegationSetLimitType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationSetId. 
        /// <para>
        /// The ID of the delegation set that you want to get the limit for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string DelegationSetId
        {
            get { return this._delegationSetId; }
            set { this._delegationSetId = value; }
        }

        // Check to see if DelegationSetId property is set
        internal bool IsSetDelegationSetId()
        {
            return this._delegationSetId != null;
        }

    }
}