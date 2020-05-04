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
    /// Container for the parameters to the CreateLocationFsxWindows operation.
    /// Creates an endpoint for an Amazon FSx for Windows file system.
    /// </summary>
    public partial class CreateLocationFsxWindowsRequest : AmazonDataSyncRequest
    {
        private string _domain;
        private string _fsxFilesystemArn;
        private string _password;
        private List<string> _securityGroupArns = new List<string>();
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();
        private string _user;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the Windows domain that the FSx for Windows server belongs to.
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
        /// Gets and sets the property FsxFilesystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the FSx for Windows file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FsxFilesystemArn
        {
            get { return this._fsxFilesystemArn; }
            set { this._fsxFilesystemArn = value; }
        }

        // Check to see if FsxFilesystemArn property is set
        internal bool IsSetFsxFilesystemArn()
        {
            return this._fsxFilesystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password of the user who has the permissions to access files and folders in the
        /// FSx for Windows file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=104)]
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
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups that are to use to configure
        /// the FSx for Windows file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && this._securityGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the location’s path. This subdirectory in the Amazon FSx for Windows
        /// file system is used to read data from the Amazon FSx for Windows source location or
        /// write data to the FSx for Windows destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Subdirectory
        {
            get { return this._subdirectory; }
            set { this._subdirectory = value; }
        }

        // Check to see if Subdirectory property is set
        internal bool IsSetSubdirectory()
        {
            return this._subdirectory != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pair that represents a tag that you want to add to the resource. The
        /// value can be an empty string. This value helps you manage, filter, and search for
        /// your resources. We recommend that you create a name tag for your location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=55)]
        public List<TagListEntry> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user who has the permissions to access files and folders in the FSx for Windows
        /// file system.
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