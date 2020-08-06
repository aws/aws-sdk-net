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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details of the rule violation in a security group when compared to the master security
    /// group of the AWS Firewall Manager policy.
    /// </summary>
    public partial class AwsVPCSecurityGroupViolation
    {
        private List<PartialMatch> _partialMatches = new List<PartialMatch>();
        private List<SecurityGroupRemediationAction> _possibleSecurityGroupRemediationActions = new List<SecurityGroupRemediationAction>();
        private string _violationTarget;
        private string _violationTargetDescription;

        /// <summary>
        /// Gets and sets the property PartialMatches. 
        /// <para>
        /// List of rules specified in the security group of the AWS Firewall Manager policy that
        /// partially match the <code>ViolationTarget</code> rule.
        /// </para>
        /// </summary>
        public List<PartialMatch> PartialMatches
        {
            get { return this._partialMatches; }
            set { this._partialMatches = value; }
        }

        // Check to see if PartialMatches property is set
        internal bool IsSetPartialMatches()
        {
            return this._partialMatches != null && this._partialMatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PossibleSecurityGroupRemediationActions. 
        /// <para>
        /// Remediation options for the rule specified in the <code>ViolationTarget</code>.
        /// </para>
        /// </summary>
        public List<SecurityGroupRemediationAction> PossibleSecurityGroupRemediationActions
        {
            get { return this._possibleSecurityGroupRemediationActions; }
            set { this._possibleSecurityGroupRemediationActions = value; }
        }

        // Check to see if PossibleSecurityGroupRemediationActions property is set
        internal bool IsSetPossibleSecurityGroupRemediationActions()
        {
            return this._possibleSecurityGroupRemediationActions != null && this._possibleSecurityGroupRemediationActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The security group rule that is being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTarget
        {
            get { return this._violationTarget; }
            set { this._violationTarget = value; }
        }

        // Check to see if ViolationTarget property is set
        internal bool IsSetViolationTarget()
        {
            return this._violationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationTargetDescription. 
        /// <para>
        /// A description of the security group that violates the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTargetDescription
        {
            get { return this._violationTargetDescription; }
            set { this._violationTargetDescription = value; }
        }

        // Check to see if ViolationTargetDescription property is set
        internal bool IsSetViolationTargetDescription()
        {
            return this._violationTargetDescription != null;
        }

    }
}