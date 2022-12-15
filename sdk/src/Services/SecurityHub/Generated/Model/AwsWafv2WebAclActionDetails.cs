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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the action that Amazon CloudFront or WAF takes when a web request matches
    /// the conditions in the rule.
    /// </summary>
    public partial class AwsWafv2WebAclActionDetails
    {
        private AwsWafv2ActionAllowDetails _allow;
        private AwsWafv2ActionBlockDetails _block;

        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        ///  Specifies that WAF should allow requests by default. 
        /// </para>
        /// </summary>
        public AwsWafv2ActionAllowDetails Allow
        {
            get { return this._allow; }
            set { this._allow = value; }
        }

        // Check to see if Allow property is set
        internal bool IsSetAllow()
        {
            return this._allow != null;
        }

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        ///  Specifies that WAF should block requests by default. 
        /// </para>
        /// </summary>
        public AwsWafv2ActionBlockDetails Block
        {
            get { return this._block; }
            set { this._block = value; }
        }

        // Check to see if Block property is set
        internal bool IsSetBlock()
        {
            return this._block != null;
        }

    }
}