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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The source of accounts for the account pool. In the current release, it's either a
    /// static list of accounts provided by the customer or a custom Amazon Web Services Lambda
    /// handler.
    /// </summary>
    public partial class AccountSource
    {
        private List<AccountInfo> _accounts = AWSConfigs.InitializeCollections ? new List<AccountInfo>() : null;
        private CustomAccountPoolHandler _customAccountPoolHandler;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// The static list of accounts within an account pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<AccountInfo> Accounts
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
        /// Gets and sets the property CustomAccountPoolHandler. 
        /// <para>
        /// The custom Amazon Web Services Lambda handler within an account pool.
        /// </para>
        /// </summary>
        public CustomAccountPoolHandler CustomAccountPoolHandler
        {
            get { return this._customAccountPoolHandler; }
            set { this._customAccountPoolHandler = value; }
        }

        // Check to see if CustomAccountPoolHandler property is set
        internal bool IsSetCustomAccountPoolHandler()
        {
            return this._customAccountPoolHandler != null;
        }

    }
}