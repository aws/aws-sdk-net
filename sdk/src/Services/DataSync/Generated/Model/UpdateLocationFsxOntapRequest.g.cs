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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateLocationFsxOntap operation. Modifies the
    /// following configuration parameters of the Amazon FSx for NetApp ONTAP transfer location
    /// that you're using with DataSync. <para> For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html">Configuring
    /// DataSync transfers with FSx for ONTAP</a>. </para>
    /// </summary>
    public partial class UpdateLocationFsxOntapRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the FSx for ONTAP transfer location that
        /// you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string LocationArn { get; set; }

        /// <summary>
        /// Checks to see if the LocationArn property is set.
        /// </summary>
        internal bool IsSetLocationArn() => this.LocationArn != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// Specifies the data transfer protocol that DataSync uses to access your Amazon FSx
        /// file system.
        /// </para>
        /// </summary>
        public FsxUpdateProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

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
        [AWSProperty(Min = 0, Max = 255)]
        public string Subdirectory { get; set; }

        /// <summary>
        /// Checks to see if the Subdirectory property is set.
        /// </summary>
        internal bool IsSetSubdirectory() => this.Subdirectory != null;
    }
}
