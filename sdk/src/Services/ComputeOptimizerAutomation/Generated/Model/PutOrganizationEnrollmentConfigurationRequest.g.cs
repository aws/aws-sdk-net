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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationEnrollmentConfiguration operation.
    /// Creates or updates an organization enrollment configuration. The organization enrollment
    /// configuration sets the organization rule mode on the specified account, organizational
    /// unit (OU), or organization root and enables Automation for affected member accounts
    /// that have opted in to Compute Optimizer, including accounts that join later. Changes
    /// on an OU or the organization root can take up to 5 minutes. Organization enrollment
    /// configurations take precedence over settings made by <c>AssociateAccounts</c> and
    /// <c>DisassociateAccounts</c>. You must specify at least one configuration in the request.
    /// <note> <para> Only the management account or a delegated administrator can perform
    /// this action. </para> <para> Organization enrollment configurations can't be created
    /// for the management account. </para> </note>
    /// </summary>
    public partial class PutOrganizationEnrollmentConfigurationRequest : AmazonComputeOptimizerAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier to ensure idempotency of the request. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property OrganizationRuleMode. 
        /// <para>
        ///  The organization rule mode to set on the target. An organization enrollment configuration
        /// with either <c>AnyAllowed</c> or <c>NoneAllowed</c> enables Automation for affected
        /// member accounts. <c>AnyAllowed</c> permits organization rules to apply to those accounts,
        /// while <c>NoneAllowed</c> doesn't. 
        /// </para>
        /// </summary>
        public OrganizationRuleMode OrganizationRuleMode { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRuleMode property is set.
        /// </summary>
        internal bool IsSetOrganizationRuleMode() => this.OrganizationRuleMode != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  The account, organizational unit (OU), or organization root on which to create or
        /// update the organization enrollment configuration. You can't specify the management
        /// account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
