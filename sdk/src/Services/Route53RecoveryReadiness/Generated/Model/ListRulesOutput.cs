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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Readiness rule information, including the resource type, rule ID, and rule description.
    /// </summary>
    public partial class ListRulesOutput
    {
        private string _resourceType;
        private string _ruleDescription;
        private string _ruleId;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type that the readiness rule applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RuleDescription. 
        /// <para>
        /// The description of a readiness rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RuleDescription
        {
            get { return this._ruleDescription; }
            set { this._ruleDescription = value; }
        }

        // Check to see if RuleDescription property is set
        internal bool IsSetRuleDescription()
        {
            return this._ruleDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The ID for the readiness rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

    }
}