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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A <code>SignupResponse</code> object that contains a summary of a newly created account.
    /// </summary>
    public partial class SignupResponse
    {
        private string _accountName;
        private string _directoryType;
        private bool? _iamUser;
        private string _userLoginName;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The name of your Amazon QuickSight account.
        /// </para>
        /// </summary>
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }

        // Check to see if AccountName property is set
        internal bool IsSetAccountName()
        {
            return this._accountName != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The type of Active Directory that is being used to authenticate the Amazon QuickSight
        /// account. Valid values are <code>SIMPLE_AD</code>, <code>AD_CONNECTOR</code>, and <code>MICROSOFT_AD</code>.
        /// </para>
        /// </summary>
        public string DirectoryType
        {
            get { return this._directoryType; }
            set { this._directoryType = value; }
        }

        // Check to see if DirectoryType property is set
        internal bool IsSetDirectoryType()
        {
            return this._directoryType != null;
        }

        /// <summary>
        /// Gets and sets the property IAMUser. 
        /// <para>
        /// A Boolean that is <code>TRUE</code> if the Amazon QuickSight uses IAM as an authentication
        /// method.
        /// </para>
        /// </summary>
        public bool IAMUser
        {
            get { return this._iamUser.GetValueOrDefault(); }
            set { this._iamUser = value; }
        }

        // Check to see if IAMUser property is set
        internal bool IsSetIAMUser()
        {
            return this._iamUser.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserLoginName. 
        /// <para>
        /// The user login name for your Amazon QuickSight account.
        /// </para>
        /// </summary>
        public string UserLoginName
        {
            get { return this._userLoginName; }
            set { this._userLoginName = value; }
        }

        // Check to see if UserLoginName property is set
        internal bool IsSetUserLoginName()
        {
            return this._userLoginName != null;
        }

    }
}