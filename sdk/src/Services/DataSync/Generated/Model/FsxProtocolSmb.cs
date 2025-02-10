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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies the Server Message Block (SMB) protocol configuration that DataSync uses
    /// to access your Amazon FSx for NetApp ONTAP file system's storage virtual machine (SVM).
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">Providing
    /// DataSync access to FSx for ONTAP file systems</a>.
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
        /// Specifies the name of the Windows domain that your storage virtual machine (SVM) belongs
        /// to.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple domains in your environment, configuring this setting makes sure
        /// that DataSync connects to the right SVM.
        /// </para>
        ///  
        /// <para>
        /// If you have multiple Active Directory domains in your environment, configuring this
        /// parameter makes sure that DataSync connects to the right SVM.
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
        /// Specifies a user that can mount and access the files, folders, and metadata in your
        /// SVM.
        /// </para>
        ///  
        /// <para>
        /// For information about choosing a user with the right level of access for your transfer,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-smb">Using
        /// the SMB protocol</a>.
        /// </para>
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