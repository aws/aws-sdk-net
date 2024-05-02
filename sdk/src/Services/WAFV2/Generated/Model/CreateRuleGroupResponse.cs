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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
    /// This is the response object from the CreateRuleGroup operation.
    /// </summary>
    public partial class CreateRuleGroupResponse : AmazonWebServiceResponse
    {
        private RuleGroupSummary _summary;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// High-level information about a <a>RuleGroup</a>, returned by operations like create
        /// and list. This provides information like the ID, that you can use to retrieve and
        /// manage a <c>RuleGroup</c>, and the ARN, that you provide to the <a>RuleGroupReferenceStatement</a>
        /// to use the rule group in a <a>Rule</a>.
        /// </para>
        /// </summary>
        public RuleGroupSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}