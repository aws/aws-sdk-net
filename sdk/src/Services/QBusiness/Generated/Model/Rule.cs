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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Guardrail rules for an Amazon Q Business application. Amazon Q Business supports only
    /// one rule at a time.
    /// </summary>
    public partial class Rule
    {
        private UsersAndGroups _excludedUsersAndGroups;
        private UsersAndGroups _includedUsersAndGroups;
        private RuleConfiguration _ruleConfiguration;
        private RuleType _ruleType;

        /// <summary>
        /// Gets and sets the property ExcludedUsersAndGroups. 
        /// <para>
        /// Users and groups to be excluded from a rule.
        /// </para>
        /// </summary>
        public UsersAndGroups ExcludedUsersAndGroups
        {
            get { return this._excludedUsersAndGroups; }
            set { this._excludedUsersAndGroups = value; }
        }

        // Check to see if ExcludedUsersAndGroups property is set
        internal bool IsSetExcludedUsersAndGroups()
        {
            return this._excludedUsersAndGroups != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedUsersAndGroups. 
        /// <para>
        /// Users and groups to be included in a rule.
        /// </para>
        /// </summary>
        public UsersAndGroups IncludedUsersAndGroups
        {
            get { return this._includedUsersAndGroups; }
            set { this._includedUsersAndGroups = value; }
        }

        // Check to see if IncludedUsersAndGroups property is set
        internal bool IsSetIncludedUsersAndGroups()
        {
            return this._includedUsersAndGroups != null;
        }

        /// <summary>
        /// Gets and sets the property RuleConfiguration. 
        /// <para>
        /// The configuration information for a rule.
        /// </para>
        /// </summary>
        public RuleConfiguration RuleConfiguration
        {
            get { return this._ruleConfiguration; }
            set { this._ruleConfiguration = value; }
        }

        // Check to see if RuleConfiguration property is set
        internal bool IsSetRuleConfiguration()
        {
            return this._ruleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleType RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

    }
}