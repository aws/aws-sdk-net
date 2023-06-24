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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// This is the response object from the GetUserDetails operation.
    /// </summary>
    public partial class GetUserDetailsResponse : AmazonWebServiceResponse
    {
        private string _displayName;
        private EmailAddress _primaryEmail;
        private string _userId;
        private string _userName;
        private string _version;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name displayed for the user in Amazon CodeCatalyst.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryEmail. 
        /// <para>
        /// The email address provided by the user when they signed up.
        /// </para>
        /// </summary>
        public EmailAddress PrimaryEmail
        {
            get { return this._primaryEmail; }
            set { this._primaryEmail = value; }
        }

        // Check to see if PrimaryEmail property is set
        internal bool IsSetPrimaryEmail()
        {
            return this._primaryEmail != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The system-generated unique ID of the user.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user as displayed in Amazon CodeCatalyst.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Version.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}