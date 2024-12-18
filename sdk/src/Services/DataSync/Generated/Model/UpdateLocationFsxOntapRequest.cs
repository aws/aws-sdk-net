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
    /// Container for the parameters to the UpdateLocationFsxOntap operation.
    /// Modifies the following configuration parameters of the Amazon FSx for NetApp ONTAP
    /// transfer location that you're using with DataSync.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html">Configuring
    /// DataSync transfers with FSx for ONTAP</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLocationFsxOntapRequest : AmazonDataSyncRequest
    {
        private string _locationArn;
        private FsxUpdateProtocol _protocol;
        private string _subdirectory;

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the FSx for ONTAP transfer location that
        /// you're updating.
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Specifies the data transfer protocol that DataSync uses to access your Amazon FSx
        /// file system.
        /// </para>
        /// </summary>
        public FsxUpdateProtocol Protocol
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
        /// Gets and sets the property Subdirectory. 
        /// <para>
        /// Specifies a path to the file share in the storage virtual machine (SVM) where you
        /// want to transfer data to or from.
        /// </para>
        ///  
        /// <para>
        /// You can specify a junction path (also known as a mount point), qtree path (for NFS
        /// file shares), or share name (for SMB file shares). For example, your mount path might
        /// be <c>/vol1</c>, <c>/vol1/tree1</c>, or <c>/share1</c>.
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

    }
}