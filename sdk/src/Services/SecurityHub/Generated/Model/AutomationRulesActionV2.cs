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
    /// Allows you to configure automated responses.
    /// </summary>
    public partial class AutomationRulesActionV2
    {
        private ExternalIntegrationConfiguration _externalIntegrationConfiguration;
        private AutomationRulesFindingFieldsUpdateV2 _findingFieldsUpdate;
        private AutomationRulesActionTypeV2 _type;

        /// <summary>
        /// Gets and sets the property ExternalIntegrationConfiguration. 
        /// <para>
        /// The settings for integrating automation rule actions with external systems or service.
        /// </para>
        /// </summary>
        public ExternalIntegrationConfiguration ExternalIntegrationConfiguration
        {
            get { return this._externalIntegrationConfiguration; }
            set { this._externalIntegrationConfiguration = value; }
        }

        // Check to see if ExternalIntegrationConfiguration property is set
        internal bool IsSetExternalIntegrationConfiguration()
        {
            return this._externalIntegrationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property FindingFieldsUpdate. 
        /// <para>
        /// The changes to be applied to fields in a security finding when an automation rule
        /// is triggered.
        /// </para>
        /// </summary>
        public AutomationRulesFindingFieldsUpdateV2 FindingFieldsUpdate
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
        /// The category of action to be executed by the automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomationRulesActionTypeV2 Type
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