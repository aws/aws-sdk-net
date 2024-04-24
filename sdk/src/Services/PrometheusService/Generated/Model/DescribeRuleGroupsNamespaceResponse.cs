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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Represents the output of a <c>DescribeRuleGroupsNamespace</c> operation.
    /// </summary>
    public partial class DescribeRuleGroupsNamespaceResponse : AmazonWebServiceResponse
    {
        private RuleGroupsNamespaceDescription _ruleGroupsNamespace;

        /// <summary>
        /// Gets and sets the property RuleGroupsNamespace. 
        /// <para>
        /// The information about the rule groups namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleGroupsNamespaceDescription RuleGroupsNamespace
        {
            get { return this._ruleGroupsNamespace; }
            set { this._ruleGroupsNamespace = value; }
        }

        // Check to see if RuleGroupsNamespace property is set
        internal bool IsSetRuleGroupsNamespace()
        {
            return this._ruleGroupsNamespace != null;
        }

    }
}