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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the ResetUserPassword operation.
    /// Resets the password for any user in your AWS Managed Microsoft AD or Simple AD directory.
    /// </summary>
    public partial class ResetUserPasswordRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _newPassword;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the AWS Managed Microsoft AD or Simple AD directory in which the user
        /// resides.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NewPassword. 
        /// <para>
        /// The new password that will be reset.
        /// </para>
        /// </summary>
        public string NewPassword
        {
            get { return this._newPassword; }
            set { this._newPassword = value; }
        }

        // Check to see if NewPassword property is set
        internal bool IsSetNewPassword()
        {
            return this._newPassword != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username of the user whose password will be reset.
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