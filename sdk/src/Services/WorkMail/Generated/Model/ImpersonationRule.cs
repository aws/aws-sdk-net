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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The rules for the given impersonation role.
    /// </summary>
    public partial class ImpersonationRule
    {
        private string _description;
        private AccessEffect _effect;
        private string _impersonationRuleId;
        private string _name;
        private List<string> _notTargetUsers = new List<string>();
        private List<string> _targetUsers = new List<string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The rule description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the rule when it matches the input. Allowed effect values are <code>ALLOW</code>
        /// or <code>DENY</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property ImpersonationRuleId. 
        /// <para>
        /// The identifier of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ImpersonationRuleId
        {
            get { return this._impersonationRuleId; }
            set { this._impersonationRuleId = value; }
        }

        // Check to see if ImpersonationRuleId property is set
        internal bool IsSetImpersonationRuleId()
        {
            return this._impersonationRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The rule name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotTargetUsers. 
        /// <para>
        /// A list of user IDs that don't match the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> NotTargetUsers
        {
            get { return this._notTargetUsers; }
            set { this._notTargetUsers = value; }
        }

        // Check to see if NotTargetUsers property is set
        internal bool IsSetNotTargetUsers()
        {
            return this._notTargetUsers != null && this._notTargetUsers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetUsers. 
        /// <para>
        /// A list of user IDs that match the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> TargetUsers
        {
            get { return this._targetUsers; }
            set { this._targetUsers = value; }
        }

        // Check to see if TargetUsers property is set
        internal bool IsSetTargetUsers()
        {
            return this._targetUsers != null && this._targetUsers.Count > 0; 
        }

    }
}