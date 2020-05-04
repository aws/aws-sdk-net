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
    /// Container for the parameters to the CreateLocationEfs operation.
    /// Creates an endpoint for an Amazon EFS file system.
    /// </summary>
    public partial class CreateLocationEfsRequest : AmazonDataSyncRequest
    {
        private Ec2Config _ec2Config;
        private string _efsFilesystemArn;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property Ec2Config. 
        /// <para>
        /// The subnet and security group that the Amazon EFS file system uses. The security group
        /// that you provide needs to be able to communicate with the security group on the mount
        /// target in the subnet specified.
        /// </para>
        ///  
        /// <para>
        /// The exact relationship between security group M (of the mount target) and security
        /// group S (which you provide for DataSync to use at this stage) is as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Security group M (which you associate with the mount target) must allow inbound access
        /// for the Transmission Control Protocol (TCP) on the NFS port (2049) from security group
        /// S. You can enable inbound connections either by IP address (CIDR range) or security
        /// group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Security group S (provided to DataSync to access EFS) should have a rule that enables
        /// outbound connections to the NFS port on one of the file system’s mount targets. You
        /// can enable outbound connections either by IP address (CIDR range) or security group.
        /// </para>
        ///  
        /// <para>
        /// For information about security groups and mount targets, see Security Groups for Amazon
        /// EC2 Instances and Mount Targets in the <i>Amazon EFS User Guide.</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Ec2Config Ec2Config
        {
            get { return this._ec2Config; }
            set { this._ec2Config = value; }
        }

        // Check to see if Ec2Config property is set
        internal bool IsSetEc2Config()
        {
            return this._ec2Config != null;
        }

        /// <summary>
        /// Gets and sets the property EfsFilesystemArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Amazon EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string EfsFilesystemArn
        {
            get { return this._efsFilesystemArn; }
            set { this._efsFilesystemArn = value; }
        }

        // Check to see if EfsFilesystemArn property is set
        internal bool IsSetEfsFilesystemArn()
        {
            return this._efsFilesystemArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// A subdirectory in the location’s path. This subdirectory in the EFS file system is
        /// used to read data from the EFS source location or write data to the EFS destination.
        /// By default, AWS DataSync uses the root directory.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>Subdirectory</code> must be specified with forward slashes. For example <code>/path/to/folder</code>.
        /// </para>
        ///  </note>
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

    }
}