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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
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
namespace Amazon.Account.Model
{
    /// <summary>
    /// This is the response object from the GetGovCloudAccountInformation operation.
    /// </summary>
    public partial class GetGovCloudAccountInformationResponse : AmazonWebServiceResponse
    {
        private AwsAccountState _accountState;
        private string _govCloudAccountId;

        /// <summary>
        /// Gets and sets the property AccountState. 
        /// <para>
        /// The account state of the linked GovCloud account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AwsAccountState AccountState
        {
            get { return this._accountState; }
            set { this._accountState = value; }
        }

        // Check to see if AccountState property is set
        internal bool IsSetAccountState()
        {
            return this._accountState != null;
        }

        /// <summary>
        /// Gets and sets the property GovCloudAccountId. 
        /// <para>
        /// The 12-digit account ID number of the linked GovCloud account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GovCloudAccountId
        {
            get { return this._govCloudAccountId; }
            set { this._govCloudAccountId = value; }
        }

        // Check to see if GovCloudAccountId property is set
        internal bool IsSetGovCloudAccountId()
        {
            return this._govCloudAccountId != null;
        }

    }
}