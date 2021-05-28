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
    /// Container for the parameters to the UpdateLocationNfs operation.
    /// Updates some of the parameters of a previously created location for Network File System
    /// (NFS) access. For information about creating an NFS location, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Creating
    /// a location for NFS</a>.
    /// </summary>
    public partial class UpdateLocationNfsRequest : AmazonDataSyncRequest
    {
        private string _locationArn;
        private NfsMountOptions _mountOptions;
        private OnPremConfig _onPremConfig;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the NFS location to update.
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
        /// </summary>
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
        /// To transfer all the data in the folder that you specified, DataSync must have permissions
        /// to read all the data. To ensure this, either configure the NFS export with <code>no_root_squash</code>,
        /// or ensure that the files you want DataSync to access have permissions that allow read
        /// access for all users. Doing either option enables the agent to read the files. For
        /// the agent to access directories, you must additionally enable all execute access.
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

    }
}