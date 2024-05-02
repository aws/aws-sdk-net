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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Remediation option for the rule specified in the <c>ViolationTarget</c>.
    /// </summary>
    public partial class SecurityGroupRemediationAction
    {
        private string _description;
        private bool? _isDefaultAction;
        private RemediationActionType _remediationActionType;
        private SecurityGroupRuleDescription _remediationResult;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Brief description of the action that will be performed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property IsDefaultAction. 
        /// <para>
        /// Indicates if the current action is the default action.
        /// </para>
        /// </summary>
        public bool? IsDefaultAction
        {
            get { return this._isDefaultAction; }
            set { this._isDefaultAction = value; }
        }

        // Check to see if IsDefaultAction property is set
        internal bool IsSetIsDefaultAction()
        {
            return this._isDefaultAction.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemediationActionType. 
        /// <para>
        /// The remediation action that will be performed.
        /// </para>
        /// </summary>
        public RemediationActionType RemediationActionType
        {
            get { return this._remediationActionType; }
            set { this._remediationActionType = value; }
        }

        // Check to see if RemediationActionType property is set
        internal bool IsSetRemediationActionType()
        {
            return this._remediationActionType != null;
        }

        /// <summary>
        /// Gets and sets the property RemediationResult. 
        /// <para>
        /// The final state of the rule specified in the <c>ViolationTarget</c> after it is remediated.
        /// </para>
        /// </summary>
        public SecurityGroupRuleDescription RemediationResult
        {
            get { return this._remediationResult; }
            set { this._remediationResult = value; }
        }

        // Check to see if RemediationResult property is set
        internal bool IsSetRemediationResult()
        {
            return this._remediationResult != null;
        }

    }
}