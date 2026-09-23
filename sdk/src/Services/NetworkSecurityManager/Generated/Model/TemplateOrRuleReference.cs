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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// A reference to either a template or a rule in a create or update request. Set exactly
    /// one of <c>templateIdentifier</c> or <c>ruleIdentifier</c>.
    /// </summary>
    public partial class TemplateOrRuleReference
    {
        private string _ruleIdentifier;
        private string _templateIdentifier;

        /// <summary>
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// The identifier of the rule. This is the rule's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1010)]
        public string RuleIdentifier
        {
            get { return this._ruleIdentifier; }
            set { this._ruleIdentifier = value; }
        }

        // Check to see if RuleIdentifier property is set
        internal bool IsSetRuleIdentifier()
        {
            return this._ruleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateIdentifier. 
        /// <para>
        /// The identifier of the template. This is the template's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1010)]
        public string TemplateIdentifier
        {
            get { return this._templateIdentifier; }
            set { this._templateIdentifier = value; }
        }

        // Check to see if TemplateIdentifier property is set
        internal bool IsSetTemplateIdentifier()
        {
            return this._templateIdentifier != null;
        }

    }
}