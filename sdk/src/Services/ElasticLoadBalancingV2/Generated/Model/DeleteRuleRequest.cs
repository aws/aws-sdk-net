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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRule operation.
    /// Deletes the specified rule.
    /// 
    ///  
    /// <para>
    /// You can't delete the default rule.
    /// </para>
    /// </summary>
    public partial class DeleteRuleRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _ruleArn;

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

    }
}