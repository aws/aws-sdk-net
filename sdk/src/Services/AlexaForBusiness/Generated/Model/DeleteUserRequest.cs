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
    /// Container for the parameters to the DeleteUser operation.
    /// Deletes a specified user by user ARN and enrollment ARN.
    /// </summary>
    public partial class DeleteUserRequest : AmazonAlexaForBusinessRequest
    {
        private string _enrollmentId;
        private string _userArn;

        /// <summary>
        /// Gets and sets the property EnrollmentId. 
        /// <para>
        /// The ARN of the user's enrollment in the organization. Required.
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
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The ARN of the user to delete in the organization. Required.
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