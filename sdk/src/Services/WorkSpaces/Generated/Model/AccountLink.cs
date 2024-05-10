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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Information about about the account link.
    /// </summary>
    public partial class AccountLink
    {
        private string _accountLinkId;
        private AccountLinkStatusEnum _accountLinkStatus;
        private string _sourceAccountId;
        private string _targetAccountId;

        /// <summary>
        /// Gets and sets the property AccountLinkId. 
        /// <para>
        /// The identifier of the account link.
        /// </para>
        /// </summary>
        public string AccountLinkId
        {
            get { return this._accountLinkId; }
            set { this._accountLinkId = value; }
        }

        // Check to see if AccountLinkId property is set
        internal bool IsSetAccountLinkId()
        {
            return this._accountLinkId != null;
        }

        /// <summary>
        /// Gets and sets the property AccountLinkStatus. 
        /// <para>
        /// The status of the account link.
        /// </para>
        /// </summary>
        public AccountLinkStatusEnum AccountLinkStatus
        {
            get { return this._accountLinkStatus; }
            set { this._accountLinkStatus = value; }
        }

        // Check to see if AccountLinkStatus property is set
        internal bool IsSetAccountLinkStatus()
        {
            return this._accountLinkStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// The identifier of the source account.
        /// </para>
        /// </summary>
        public string SourceAccountId
        {
            get { return this._sourceAccountId; }
            set { this._sourceAccountId = value; }
        }

        // Check to see if SourceAccountId property is set
        internal bool IsSetSourceAccountId()
        {
            return this._sourceAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The identifier of the target account.
        /// </para>
        /// </summary>
        public string TargetAccountId
        {
            get { return this._targetAccountId; }
            set { this._targetAccountId = value; }
        }

        // Check to see if TargetAccountId property is set
        internal bool IsSetTargetAccountId()
        {
            return this._targetAccountId != null;
        }

    }
}