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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatalakeAutoEnable operation.
    /// Automatically enables Amazon Security Lake for new member accounts in your organization.
    /// Security Lake is not automatically enabled for any existing member accounts in your
    /// organization.
    /// </summary>
    public partial class CreateDatalakeAutoEnableRequest : AmazonSecurityLakeRequest
    {
        private List<AutoEnableNewRegionConfiguration> _configurationForNewAccounts = new List<AutoEnableNewRegionConfiguration>();

        /// <summary>
        /// Gets and sets the property ConfigurationForNewAccounts. 
        /// <para>
        /// Enable Security Lake with the specified configuration settings to begin collecting
        /// security data for new accounts in your organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutoEnableNewRegionConfiguration> ConfigurationForNewAccounts
        {
            get { return this._configurationForNewAccounts; }
            set { this._configurationForNewAccounts = value; }
        }

        // Check to see if ConfigurationForNewAccounts property is set
        internal bool IsSetConfigurationForNewAccounts()
        {
            return this._configurationForNewAccounts != null && this._configurationForNewAccounts.Count > 0; 
        }

    }
}