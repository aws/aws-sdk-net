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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOrganizationConfigRule operation.
    /// Deletes the specified organization config rule and all of its evaluation results from
    /// all member accounts in that organization. 
    /// 
    ///  
    /// <para>
    /// Only a master account and a delegated administrator account can delete an organization
    /// config rule. When calling this API with a delegated administrator, you must ensure
    /// AWS Organizations <code>ListDelegatedAdministrator</code> permissions are added.
    /// </para>
    ///  
    /// <para>
    /// AWS Config sets the state of a rule to DELETE_IN_PROGRESS until the deletion is complete.
    /// You cannot update a rule while it is in this state.
    /// </para>
    /// </summary>
    public partial class DeleteOrganizationConfigRuleRequest : AmazonConfigServiceRequest
    {
        private string _organizationConfigRuleName;

        /// <summary>
        /// Gets and sets the property OrganizationConfigRuleName. 
        /// <para>
        /// The name of organization config rule that you want to delete.
        /// </para>
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

    }
}