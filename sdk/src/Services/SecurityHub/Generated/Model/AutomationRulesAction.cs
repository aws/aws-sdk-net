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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// One or more actions that Security Hub takes when a finding matches the defined criteria
    /// of a rule.
    /// </summary>
    public partial class AutomationRulesAction
    {
        private AutomationRulesFindingFieldsUpdate _findingFieldsUpdate;
        private AutomationRulesActionType _type;

        /// <summary>
        /// Gets and sets the property FindingFieldsUpdate. 
        /// <para>
        ///  Specifies that the automation rule action is an update to a finding field. 
        /// </para>
        /// </summary>
        public AutomationRulesFindingFieldsUpdate FindingFieldsUpdate
        {
            get { return this._findingFieldsUpdate; }
            set { this._findingFieldsUpdate = value; }
        }

        // Check to see if FindingFieldsUpdate property is set
        internal bool IsSetFindingFieldsUpdate()
        {
            return this._findingFieldsUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Specifies the type of action that Security Hub takes when a finding matches the defined
        /// criteria of a rule. 
        /// </para>
        /// </summary>
        public AutomationRulesActionType Type
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