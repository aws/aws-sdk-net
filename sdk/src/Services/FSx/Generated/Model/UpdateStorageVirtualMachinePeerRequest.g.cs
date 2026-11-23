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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStorageVirtualMachinePeer operation. Updates
    /// an Amazon FSx for NetApp ONTAP storage virtual machine (SVM) peer relationship.
    /// </summary>
    public partial class UpdateStorageVirtualMachinePeerRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Specifies the applications that the SVM peer relationship authorizes. The applications
        /// that you specify replace the existing applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property PeerSvmAlias. 
        /// <para>
        /// Specifies the name that the local cluster uses to identify the peer SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 41)]
        public string PeerSvmAlias { get; set; }

        /// <summary>
        /// Checks to see if the PeerSvmAlias property is set.
        /// </summary>
        internal bool IsSetPeerSvmAlias() => this.PeerSvmAlias != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Specifies the state to set for the SVM peer relationship:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PEERED</c> – Accepts a pending peering request, or resumes a suspended SVM peer
        /// relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c> – Suspends the SVM peer relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> – Rejects a pending peering request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageVirtualMachinePeerUpdateState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachinePeerId. 
        /// <para>
        /// The ID of the SVM peer that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StorageVirtualMachinePeerId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachinePeerId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachinePeerId() => this.StorageVirtualMachinePeerId != null;
    }
}
