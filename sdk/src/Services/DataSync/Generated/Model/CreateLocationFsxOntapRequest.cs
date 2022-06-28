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
    /// Container for the parameters to the CreateLocationFsxOntap operation.
    /// Creates an endpoint for an Amazon FSx for NetApp ONTAP file system that DataSync can
    /// access for a transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html">Creating
    /// a location for FSx for ONTAP</a>.
    /// </summary>
    public partial class CreateLocationFsxOntapRequest : AmazonDataSyncRequest
    {
        private FsxProtocol _protocol;
        private List<string> _securityGroupArns = new List<string>();
        private string _storageVirtualMachineArn;
        private string _subdirectory;
        private List<TagListEntry> _tags = new List<TagListEntry>();

        /// <summary>
        /// Gets and sets the property Protocol.
        /// </summary>
        [AWSProperty(Required=true)]
        public FsxProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// Specifies the security groups that DataSync can use to access your FSx for ONTAP file
        /// system. You must configure the security groups to allow outbound traffic on the following
        /// ports (depending on the protocol that you're using):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Network File System (NFS)</b>: TCP port 2049
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Server Message Block (SMB)</b>: TCP port 445
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your file system's security groups must also allow inbound traffic on the same port.
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
        /// Gets and sets the property StorageVirtualMachineArn. 
        /// <para>
        /// Specifies the ARN of the storage virtual machine (SVM) on your file system where you're
        /// copying data to or from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=162)]
        public string StorageVirtualMachineArn
        {
            get { return this._storageVirtualMachineArn; }
            set { this._storageVirtualMachineArn = value; }
        }

        // Check to see if StorageVirtualMachineArn property is set
        internal bool IsSetStorageVirtualMachineArn()
        {
            return this._storageVirtualMachineArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies the junction path (also known as a mount point) in the SVM volume where
        /// you're copying data to or from (for example, <code>/vol1</code>).
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't specify a junction path in the SVM's root volume. For more information, see
        /// <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-svms.html">Managing
        /// FSx for ONTAP storage virtual machines</a> in the <i>Amazon FSx for NetApp ONTAP User
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Specifies labels that help you categorize, filter, and search for your Amazon Web
        /// Services resources. We recommend creating at least a name tag for your location.
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