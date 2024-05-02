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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// The user ID and user fields to update, used with the <a>BatchUpdateUser</a> action.
    /// </summary>
    public partial class UpdateUserRequestItem
    {
        private AlexaForBusinessMetadata _alexaForBusinessMetadata;
        private License _licenseType;
        private string _userId;
        private UserType _userType;

        /// <summary>
        /// Gets and sets the property AlexaForBusinessMetadata. 
        /// <para>
        /// The Alexa for Business metadata.
        /// </para>
        /// </summary>
        public AlexaForBusinessMetadata AlexaForBusinessMetadata
        {
            get { return this._alexaForBusinessMetadata; }
            set { this._alexaForBusinessMetadata = value; }
        }

        // Check to see if AlexaForBusinessMetadata property is set
        internal bool IsSetAlexaForBusinessMetadata()
        {
            return this._alexaForBusinessMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The user license type.
        /// </para>
        /// </summary>
        public License LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserType. 
        /// <para>
        /// The user type.
        /// </para>
        /// </summary>
        public UserType UserType
        {
            get { return this._userType; }
            set { this._userType = value; }
        }

        // Check to see if UserType property is set
        internal bool IsSetUserType()
        {
            return this._userType != null;
        }

    }
}