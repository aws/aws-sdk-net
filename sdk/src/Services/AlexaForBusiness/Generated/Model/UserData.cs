/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Information related to a user.
    /// </summary>
    public partial class UserData
    {
        private string _email;
        private string _enrollmentId;
        private EnrollmentStatus _enrollmentStatus;
        private string _firstName;
        private string _lastName;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of a user.
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
        /// Gets and sets the property EnrollmentId. 
        /// <para>
        /// The enrollment ARN of a user.
        /// </para>
        /// </summary>
        public string EnrollmentId
        {
            get { return this._enrollmentId; }
            set { this._enrollmentId = value; }
        }

        // Check to see if EnrollmentId property is set
        internal bool IsSetEnrollmentId()
        {
            return this._enrollmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EnrollmentStatus. 
        /// <para>
        /// The enrollment status of a user.
        /// </para>
        /// </summary>
        public EnrollmentStatus EnrollmentStatus
        {
            get { return this._enrollmentStatus; }
            set { this._enrollmentStatus = value; }
        }

        // Check to see if EnrollmentStatus property is set
        internal bool IsSetEnrollmentStatus()
        {
            return this._enrollmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of a user.
        /// </para>
        /// </summary>
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
        /// The last name of a user.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of a user.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

    }
}