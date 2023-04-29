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
    /// Container for the parameters to the DeleteDatalakeAutoEnable operation.
    /// <code>DeleteDatalakeAutoEnable</code> removes automatic enablement of configuration
    /// settings for new member accounts (but keeps settings for the delegated administrator)
    /// from Amazon Security Lake. You must run this API using credentials of the delegated
    /// administrator. When you run this API, new member accounts that are added after the
    /// organization enables Security Lake won't contribute to the data lake.
    /// </summary>
    public partial class DeleteDatalakeAutoEnableRequest : AmazonSecurityLakeRequest
    {
        private List<AutoEnableNewRegionConfiguration> _removeFromConfigurationForNewAccounts = new List<AutoEnableNewRegionConfiguration>();

        /// <summary>
        /// Gets and sets the property RemoveFromConfigurationForNewAccounts. 
        /// <para>
        /// Remove automatic enablement of configuration settings for new member accounts in Security
        /// Lake. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutoEnableNewRegionConfiguration> RemoveFromConfigurationForNewAccounts
        {
            get { return this._removeFromConfigurationForNewAccounts; }
            set { this._removeFromConfigurationForNewAccounts = value; }
        }

        // Check to see if RemoveFromConfigurationForNewAccounts property is set
        internal bool IsSetRemoveFromConfigurationForNewAccounts()
        {
            return this._removeFromConfigurationForNewAccounts != null && this._removeFromConfigurationForNewAccounts.Count > 0; 
        }

    }
}