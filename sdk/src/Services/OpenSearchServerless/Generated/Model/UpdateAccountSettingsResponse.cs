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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// This is the response object from the UpdateAccountSettings operation.
    /// </summary>
    public partial class UpdateAccountSettingsResponse : AmazonWebServiceResponse
    {
        private AccountSettingsDetail _accountSettingsDetail;

        /// <summary>
        /// Gets and sets the property AccountSettingsDetail. 
        /// <para>
        /// OpenSearch Serverless-related settings for the current Amazon Web Services account.
        /// 
        /// </para>
        /// </summary>
        public AccountSettingsDetail AccountSettingsDetail
        {
            get { return this._accountSettingsDetail; }
            set { this._accountSettingsDetail = value; }
        }

        // Check to see if AccountSettingsDetail property is set
        internal bool IsSetAccountSettingsDetail()
        {
            return this._accountSettingsDetail != null;
        }

    }
}