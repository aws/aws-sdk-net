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
    /// Container for the parameters to the CreateLocationNfs operation.
    /// Defines a file system on a Network File System (NFS) server that can be read from
    /// or written to.
    /// </summary>
    public partial class CreateLocationNfsRequest : AmazonDataSyncRequest
    {
        private NfsMountOptions _mountOptions;
        private OnPremConfig _onPremConfig;
        private string _serverHostname;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property MountOptions. 
        /// <para>
        /// The NFS mount options that DataSync can use to mount your NFS share.
        /// </para>
        /// </summary>
        public NfsMountOptions MountOptions
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
        /// Gets and sets the property OnPremConfig. 
        /// <para>
        /// Contains a list of Amazon Resource Names (ARNs) of agents that are used to connect
        /// to an NFS server. 
        /// </para>
        ///  
        /// <para>
        /// If you are copying data to or from your AWS Snowcone device, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#nfs-on-snowcone">NFS
        /// Server on AWS Snowcone</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnPremConfig OnPremConfig
        {
            get { return this._onPremConfig; }
            set { this._onPremConfig = value; }
        }

        // Check to see if OnPremConfig property is set
        internal bool IsSetOnPremConfig()
        {
            return this._onPremConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ServerHostname. 
        /// <para>
        /// The name of the NFS server. This value is the IP address or Domain Name Service (DNS)
        /// name of the NFS server. An agent that is installed on-premises uses this host name
        /// to mount the NFS server in a network. 
        /// </para>
        ///  
        /// <para>
        /// If you are copying data to or from your AWS Snowcone device, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#nfs-on-snowcone">NFS
        /// Server on AWS Snowcone</a> for more information.
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
        /// The subdirectory in the NFS file system that is used to read data from the NFS source
        /// location or write data to the NFS destination. The NFS path should be a path that's
        /// exported by the NFS server, or a subdirectory of that path. The path should be such
        /// that it can be mounted by other NFS clients in your network. 
        /// </para>
        ///  
        /// <para>
        /// To see all the paths exported by your NFS server, run "<code>showmount -e nfs-server-name</code>"
        /// from an NFS client that has access to your server. You can specify any directory that
        /// appears in the results, and any subdirectory of that directory. Ensure that the NFS
        /// export is accessible without Kerberos authentication. 
        /// </para>
        ///  
        /// <para>
        /// To transfer all the data in the folder you specified, DataSync needs to have permissions
        /// to read all the data. To ensure this, either configure the NFS export with <code>no_root_squash,</code>
        /// or ensure that the permissions for all of the files that you want DataSync allow read
        /// access for all users. Doing either enables the agent to read the files. For the agent
        /// to access directories, you must additionally enable all execute access.
        /// </para>
        ///  
        /// <para>
        /// If you are copying data to or from your AWS Snowcone device, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#nfs-on-snowcone">NFS
        /// Server on AWS Snowcone</a> for more information.
        /// </para>
        ///  
        /// <para>
        /// For information about NFS export configuration, see 18.7. The /etc/exports Configuration
        /// File in the Red Hat Enterprise Linux documentation.
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

    }
}