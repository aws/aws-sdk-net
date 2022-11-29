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
    /// Automatically delete Security Lake in the specified Regions to stop ingesting security
    /// data. When you delete Amazon Security Lake from your account, Security Lake is disabled
    /// in all Regions. Also, this API automatically performs the off-boarding steps to off-board
    /// the account from Security Lake . This includes ingesting security data from sources,
    /// storing data, and making data accessible to subscribers. Security Lake also deletes
    /// all the existing settings and resources that it stores or maintains for your account
    /// in the current Region, including security log and event data. For more information,
    /// see the Amazon Security Lake User Guide.
    /// </summary>
    public partial class DeleteDatalakeAutoEnableRequest : AmazonSecurityLakeRequest
    {
        private List<AutoEnableNewRegionConfiguration> _removeFromConfigurationForNewAccounts = new List<AutoEnableNewRegionConfiguration>();

        /// <summary>
        /// Gets and sets the property RemoveFromConfigurationForNewAccounts. 
        /// <para>
        /// Delete Amazon Security Lake with the specified configurations settings to stop ingesting
        /// security data for new accounts in Security Lake. 
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