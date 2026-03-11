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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCentralizationRuleForOrganization operation.
    /// Updates an existing centralization rule that applies across an Amazon Web Services
    /// Organization. This operation can only be called by the organization's management account
    /// or a delegated administrator account.
    /// </summary>
    public partial class UpdateCentralizationRuleForOrganizationRequest : AmazonObservabilityAdminRequest
    {
        private CentralizationRule _rule;
        private string _ruleIdentifier;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The configuration details for the organization-wide centralization rule, including
        /// the source configuration and the destination configuration to centralize telemetry
        /// data across the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CentralizationRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// The identifier (name or ARN) of the organization centralization rule to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
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

    }
}