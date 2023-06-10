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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// This is the response object from the ResetUserPassword operation.
    /// </summary>
    public partial class ResetUserPasswordResponse : AmazonWebServiceResponse
    {
        private string _temporaryPassword;
        private string _userId;

        /// <summary>
        /// Gets and sets the property TemporaryPassword. 
        /// <para>
        /// A randomly generated temporary password for the requested user account. This password
        /// expires in 7 days.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=20)]
        public string TemporaryPassword
        {
            get { return this._temporaryPassword; }
            set { this._temporaryPassword = value; }
        }

        // Check to see if TemporaryPassword property is set
        internal bool IsSetTemporaryPassword()
        {
            return this._temporaryPassword != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the user that a new password is generated for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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

    }
}