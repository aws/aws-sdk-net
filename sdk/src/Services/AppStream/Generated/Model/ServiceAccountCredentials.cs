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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the credentials for the service account used by the fleet or image builder
    /// to connect to the directory.
    /// </summary>
    public partial class ServiceAccountCredentials
    {
        private string _accountName;
        private string _accountPassword;

        /// <summary>
        /// Gets and sets the property AccountName. 
        /// <para>
        /// The user name of the account. This account must have the following privileges: create
        /// computer objects, join computers to the domain, and change/reset the password on descendant
        /// computer objects for the organizational units specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
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
        /// Gets and sets the property AccountPassword. 
        /// <para>
        /// The password for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=127)]
        public string AccountPassword
        {
            get { return this._accountPassword; }
            set { this._accountPassword = value; }
        }

        // Check to see if AccountPassword property is set
        internal bool IsSetAccountPassword()
        {
            return this._accountPassword != null;
        }

    }
}