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
    /// Container for the parameters to the UpdateLocationSmb operation.
    /// Updates some of the parameters of a previously created location for Server Message
    /// Block (SMB) file system access. For information about creating an SMB location, see
    /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Creating
    /// a location for SMB</a>.
    /// </summary>
    public partial class UpdateLocationSmbRequest : AmazonDataSyncRequest
    {
        private List<string> _agentArns = new List<string>();
        private string _domain;
        private string _locationArn;
        private SmbMountOptions _mountOptions;
        private string _password;
        private string _subdirectory;
        private string _user;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of agents to use for a Simple Message Block (SMB)
        /// location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
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
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SMB location to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
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
        /// The password of the user who can mount the share has the permissions to access files
        /// and folders in the SMB share.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=104)]
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
        /// To transfer all the data in the folder that you specified, DataSync must have permissions
        /// to mount the SMB share and to access all the data in that share. To ensure this, do
        /// either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Ensure that the user/password specified belongs to the user who can mount the share
        /// and who has the appropriate permissions for all of the files and directories that
        /// you want DataSync to access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use credentials of a member of the Backup Operators group to mount the share. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Doing either of these options enables the agent to access the data. For the agent
        /// to access directories, you must also enable all execute access.
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
        /// Gets and sets the property User. 
        /// <para>
        /// The user who can mount the share has the permissions to access files and folders in
        /// the SMB share.
        /// </para>
        /// </summary>
        [AWSProperty(Max=104)]
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