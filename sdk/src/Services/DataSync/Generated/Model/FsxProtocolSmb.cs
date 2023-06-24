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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the Server Message Block (SMB) protocol configuration that DataSync uses
    /// to access your Amazon FSx for NetApp ONTAP file system. For more information, see
    /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">Accessing
    /// FSx for ONTAP file systems</a>.
    /// </summary>
    public partial class FsxProtocolSmb
    {
        private string _domain;
        private SmbMountOptions _mountOptions;
        private string _password;
        private string _user;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// Specifies the fully qualified domain name (FQDN) of the Microsoft Active Directory
        /// that your storage virtual machine (SVM) belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=253)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property MountOptions.
        /// </summary>
        public SmbMountOptions MountOptions
        {
            get { return this._mountOptions; }
            set { this._mountOptions = value; }
        }

        // Check to see if MountOptions property is set
        internal bool IsSetMountOptions()
        {
            return this._mountOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the password of a user who has permission to access your SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=104)]
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
        /// Gets and sets the property User. 
        /// <para>
        /// Specifies a user name that can mount the location and access the files, folders, and
        /// metadata that you need in the SVM.
        /// </para>
        ///  
        /// <para>
        /// If you provide a user in your Active Directory, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you're using Directory Service for Microsoft Active Directory, the user must be
        /// a member of the Amazon Web Services Delegated FSx Administrators group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you're using a self-managed Active Directory, the user must be a member of either
        /// the Domain Admins group or a custom group that you specified for file system administration
        /// when you created your file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Make sure that the user has the permissions it needs to copy the data you want:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SE_TCB_NAME</code>: Required to set object ownership and file metadata. With
        /// this privilege, you also can copy NTFS discretionary access lists (DACLs).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SE_SECURITY_NAME</code>: May be needed to copy NTFS system access control lists
        /// (SACLs). This operation specifically requires the Windows privilege, which is granted
        /// to members of the Domain Admins group. If you configure your task to copy SACLs, make
        /// sure that the user has the required privileges. For information about copying SACLs,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-task.html#configure-ownership-and-permissions">Ownership
        /// and permissions-related options</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=104)]
        public string User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}