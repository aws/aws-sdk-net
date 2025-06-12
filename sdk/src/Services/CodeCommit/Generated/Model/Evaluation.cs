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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about the approval rules applied to a pull request and whether
    /// conditions have been met.
    /// </summary>
    public partial class Evaluation
    {
        private List<string> _approvalRulesNotSatisfied = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _approvalRulesSatisfied = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _approved;
        private bool? _overridden;

        /// <summary>
        /// Gets and sets the property ApprovalRulesNotSatisfied. 
        /// <para>
        /// The names of the approval rules that have not had their conditions met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApprovalRulesNotSatisfied
        {
            get { return this._approvalRulesNotSatisfied; }
            set { this._approvalRulesNotSatisfied = value; }
        }

        // Check to see if ApprovalRulesNotSatisfied property is set
        internal bool IsSetApprovalRulesNotSatisfied()
        {
            return this._approvalRulesNotSatisfied != null && (this._approvalRulesNotSatisfied.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApprovalRulesSatisfied. 
        /// <para>
        /// The names of the approval rules that have had their conditions met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApprovalRulesSatisfied
        {
            get { return this._approvalRulesSatisfied; }
            set { this._approvalRulesSatisfied = value; }
        }

        // Check to see if ApprovalRulesSatisfied property is set
        internal bool IsSetApprovalRulesSatisfied()
        {
            return this._approvalRulesSatisfied != null && (this._approvalRulesSatisfied.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Approved. 
        /// <para>
        /// Whether the state of the pull request is approved.
        /// </para>
        /// </summary>
        public bool? Approved
        {
            get { return this._approved; }
            set { this._approved = value; }
        }

        // Check to see if Approved property is set
        internal bool IsSetApproved()
        {
            return this._approved.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Overridden. 
        /// <para>
        /// Whether the approval rule requirements for the pull request have been overridden and
        /// no longer need to be met.
        /// </para>
        /// </summary>
        public bool? Overridden
        {
            get { return this._overridden; }
            set { this._overridden = value; }
        }

        // Check to see if Overridden property is set
        internal bool IsSetOverridden()
        {
            return this._overridden.HasValue; 
        }

    }
}