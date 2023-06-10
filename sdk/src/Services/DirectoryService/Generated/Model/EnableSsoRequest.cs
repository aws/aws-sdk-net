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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSso operation.
    /// Enables single sign-on for a directory. Single sign-on allows users in your directory
    /// to access certain Amazon Web Services services from a computer joined to the directory
    /// without having to enter their credentials separately.
    /// </summary>
    public partial class EnableSsoRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _password;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to enable single-sign on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of an alternate account to use to enable single-sign on. This is only
        /// used for AD Connector directories. For more information, see the <i>UserName</i> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of an alternate account to use to enable single-sign on. This is only
        /// used for AD Connector directories. This account must have privileges to add a service
        /// principal name.
        /// </para>
        ///  
        /// <para>
        /// If the AD Connector service account does not have privileges to add a service principal
        /// name, you can specify an alternate account with the <i>UserName</i> and <i>Password</i>
        /// parameters. These credentials are only used to enable single sign-on and are not stored
        /// by the service. The AD Connector service account is not changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}