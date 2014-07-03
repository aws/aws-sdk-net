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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetUser operation.
    /// Retrieves information about the specified user, including the user's path, unique
    /// ID, and            ARN.
    /// 
    ///         
    /// <para>
    /// If you do not specify a user name, IAM determines the user name implicitly based on
    /// the AWS            access key ID signing the request.
    /// </para>
    /// </summary>
    public partial class GetUserRequest : AmazonIdentityManagementServiceRequest
    {
        private string _userName;


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user to get information about.
        /// </para>
        ///         
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to the user making
        /// the            request.
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

    }
}