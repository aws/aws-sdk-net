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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information includes the Amazon Web Services account ID where the current document
    /// is shared and the version shared with that account.
    /// </summary>
    public partial class AccountSharingInfo
    {
        private string _accountId;
        private string _sharedDocumentVersion;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID where the current document is shared.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property SharedDocumentVersion. 
        /// <para>
        /// The version of the current document shared with the account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8)]
        public string SharedDocumentVersion
        {
            get { return this._sharedDocumentVersion; }
            set { this._sharedDocumentVersion = value; }
        }

        // Check to see if SharedDocumentVersion property is set
        internal bool IsSetSharedDocumentVersion()
        {
            return this._sharedDocumentVersion != null;
        }

    }
}