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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the action that Amazon CloudFront or WAF takes when a web request matches
    /// the conditions in the rule.
    /// </summary>
    public partial class AwsWafv2WebAclActionDetails
    {
        /// <summary>
        /// Gets and sets the property Allow. 
        /// <para>
        ///  Specifies that WAF should allow requests by default. 
        /// </para>
        /// </summary>
        public AwsWafv2ActionAllowDetails Allow { get; set; }

        /// <summary>
        /// Checks to see if the Allow property is set.
        /// </summary>
        internal bool IsSetAllow() => this.Allow != null;

        /// <summary>
        /// Gets and sets the property Block. 
        /// <para>
        ///  Specifies that WAF should block requests by default. 
        /// </para>
        /// </summary>
        public AwsWafv2ActionBlockDetails Block { get; set; }

        /// <summary>
        /// Checks to see if the Block property is set.
        /// </summary>
        internal bool IsSetBlock() => this.Block != null;
    }
}
