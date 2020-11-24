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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOrganizationConfiguration operation.
    /// Used to update the configuration related to Organizations. Can only be called from
    /// a Security Hub administrator account.
    /// </summary>
    public partial class UpdateOrganizationConfigurationRequest : AmazonSecurityHubRequest
    {
        private bool? _autoEnable;

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Whether to automatically enable Security Hub for new accounts in the organization.
        /// </para>
        ///  
        /// <para>
        /// By default, this is <code>false</code>, and new accounts are not added automatically.
        /// </para>
        ///  
        /// <para>
        /// To automatically enable Security Hub for new accounts, set this to <code>true</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AutoEnable
        {
            get { return this._autoEnable.GetValueOrDefault(); }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable.HasValue; 
        }

    }
}