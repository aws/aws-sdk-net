/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutOrganizationConfigRule operation.
    /// 
    /// </summary>
    public partial class PutOrganizationConfigRuleRequest : AmazonConfigServiceRequest
    {
        private List<string> _excludedAccounts = new List<string>();
        private string _organizationConfigRuleName;
        private OrganizationCustomRuleMetadata _organizationCustomRuleMetadata;
        private OrganizationManagedRuleMetadata _organizationManagedRuleMetadata;

        /// <summary>
        /// Gets and sets the property ExcludedAccounts.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ExcludedAccounts
        {
            get { return this._excludedAccounts; }
            set { this._excludedAccounts = value; }
        }

        // Check to see if ExcludedAccounts property is set
        internal bool IsSetExcludedAccounts()
        {
            return this._excludedAccounts != null && this._excludedAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string OrganizationConfigRuleName
        {
            get { return this._organizationConfigRuleName; }
            set { this._organizationConfigRuleName = value; }
        }

        // Check to see if OrganizationConfigRuleName property is set
        internal bool IsSetOrganizationConfigRuleName()
        {
            return this._organizationConfigRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationCustomRuleMetadata.
        /// </summary>
        public OrganizationCustomRuleMetadata OrganizationCustomRuleMetadata
        {
            get { return this._organizationCustomRuleMetadata; }
            set { this._organizationCustomRuleMetadata = value; }
        }

        // Check to see if OrganizationCustomRuleMetadata property is set
        internal bool IsSetOrganizationCustomRuleMetadata()
        {
            return this._organizationCustomRuleMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationManagedRuleMetadata.
        /// </summary>
        public OrganizationManagedRuleMetadata OrganizationManagedRuleMetadata
        {
            get { return this._organizationManagedRuleMetadata; }
            set { this._organizationManagedRuleMetadata = value; }
        }

        // Check to see if OrganizationManagedRuleMetadata property is set
        internal bool IsSetOrganizationManagedRuleMetadata()
        {
            return this._organizationManagedRuleMetadata != null;
        }

    }
}