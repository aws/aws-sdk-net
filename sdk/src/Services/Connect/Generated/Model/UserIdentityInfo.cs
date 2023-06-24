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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about the identity of a user.
    /// </summary>
    public partial class UserIdentityInfo
    {
        private string _email;
        private string _firstName;
        private string _lastName;
        private string _mobile;
        private string _secondaryEmail;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address. If you are using SAML for identity management and include this
        /// parameter, an error is returned.
        /// </para>
        /// </summary>
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name. This is required if you are using Amazon Connect or SAML for identity
        /// management.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name. This is required if you are using Amazon Connect or SAML for identity
        /// management.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property Mobile. 
        /// <para>
        /// The user's mobile number.
        /// </para>
        /// </summary>
        public string Mobile
        {
            get { return this._mobile; }
            set { this._mobile = value; }
        }

        // Check to see if Mobile property is set
        internal bool IsSetMobile()
        {
            return this._mobile != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryEmail. 
        /// <para>
        /// The user's secondary email address. If you provide a secondary email, the user receives
        /// email notifications - other than password reset notifications - to this email address
        /// instead of to their primary email address.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <code>(?=^.{0,265}$)[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,63}</code>
        /// 
        /// </para>
        /// </summary>
        public string SecondaryEmail
        {
            get { return this._secondaryEmail; }
            set { this._secondaryEmail = value; }
        }

        // Check to see if SecondaryEmail property is set
        internal bool IsSetSecondaryEmail()
        {
            return this._secondaryEmail != null;
        }

    }
}