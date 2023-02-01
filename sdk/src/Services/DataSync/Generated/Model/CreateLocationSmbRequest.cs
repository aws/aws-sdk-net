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
    /// Container for the parameters to the CreateLocationSmb operation.
    /// Defines a file system on a Server Message Block (SMB) server that can be read from
    /// or written to.
    /// </summary>
    public partial class CreateLocationSmbRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = new List<string>();
        private string _domain;
        private SmbMountOptions _mountOptions;
        private string _password;
        private string _serverHostname;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();
        private string _user;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB)
        /// location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && this._agentArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the Windows domain that the SMB server belongs to.
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
        /// <para>
        /// The mount options used by DataSync to access the SMB server.
        /// </para>
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
        /// The password of the user who can mount the share, has the permissions to access files
        /// and folders in the SMB share.
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
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// The name of the SMB server. This value is the IP address or Domain Name Service (DNS)
        /// name of the SMB server. An agent that is installed on-premises uses this hostname
        /// to mount the SMB server in a network.
        /// </para>
        ///  <note> 
        /// <para>
        /// This name must either be DNS-compliant or must be an IP version 4 (IPv4) address.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string ServerHostname
        {
            get { return this._serverHostname; }
            set { this._serverHostname = value; }
        }

        // Check to see if ServerHostname property is set
        internal bool IsSetServerHostname()
        {
            return this._serverHostname != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// The subdirectory in the SMB file system that is used to read data from the SMB source
        /// location or write data to the SMB destination. The SMB path should be a path that's
        /// exported by the SMB server, or a subdirectory of that path. The path should be such
        /// that it can be mounted by other SMB clients in your network.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>Subdirectory</code> must be specified with forward slashes. For example, <code>/path/to/folder</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To transfer all the data in the folder you specified, DataSync needs to have permissions
        /// to mount the SMB share, as well as to access all the data in that share. To ensure
        /// this, either ensure that the user/password specified belongs to the user who can mount
        /// the share, and who has the appropriate permissions for all of the files and directories
        /// that you want DataSync to access, or use credentials of a member of the Backup Operators
        /// group to mount the share. Doing either enables the agent to access the data. For the
        /// agent to access directories, you must additionally enable all execute access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
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
        /// The key-value pair that represents the tag that you want to add to the location. The
        /// value can be an empty string. We recommend using tags to name your resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// The user who can mount the share, has the permissions to access files and folders
        /// in the SMB share.
        /// </para>
        ///  
        /// <para>
        /// For information about choosing a user name that ensures sufficient permissions to
        /// files, folders, and metadata, see the <a href="create-smb-location.html#SMBuser">User
        /// setting</a> for SMB locations.
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