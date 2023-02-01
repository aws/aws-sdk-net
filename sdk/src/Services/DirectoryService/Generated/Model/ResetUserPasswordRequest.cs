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
    /// Container for the parameters to the ResetUserPassword operation.
    /// Resets the password for any user in your Managed Microsoft AD or Simple AD directory.
    /// 
    ///  
    /// <para>
    /// You can reset the password for any user in your directory with the following exceptions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For Simple AD, you cannot reset the password for any user that is a member of either
    /// the <b>Domain Admins</b> or <b>Enterprise Admins</b> group except for the administrator
    /// user.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Managed Microsoft AD, you can only reset the password for a user that is in an
    /// OU based off of the NetBIOS name that you typed when you created your directory. For
    /// example, you cannot reset the password for a user in the <b>Amazon Web Services Reserved</b>
    /// OU. For more information about the OU structure for an Managed Microsoft AD directory,
    /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_getting_started_what_gets_created.html">What
    /// Gets Created</a> in the <i>Directory Service Administration Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ResetUserPasswordRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private string _newPassword;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the Managed Microsoft AD or Simple AD directory in which the user resides.
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
        /// Gets and sets the property NewPassword. 
        /// <para>
        /// The new password that will be reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=127)]
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
        /// The user name of the user whose password will be reset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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