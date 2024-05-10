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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Information about the usage statistics, calculated by top accounts by feature.
    /// </summary>
    public partial class UsageTopAccountsResult
    {
        private List<UsageTopAccountResult> _accounts = AWSConfigs.InitializeCollections ? new List<UsageTopAccountResult>() : null;
        private UsageFeature _feature;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The accounts that contributed to the total usage cost.
        /// </para>
        /// </summary>
        public List<UsageTopAccountResult> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// Features by which you can generate the usage statistics.
        /// </para>
        ///  
        /// <para>
        ///  <c>RDS_LOGIN_EVENTS</c> is currently not supported with <c>topAccountsByFeature</c>.
        /// </para>
        /// </summary>
        public UsageFeature Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

    }
}