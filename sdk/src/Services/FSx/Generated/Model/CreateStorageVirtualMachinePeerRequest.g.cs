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
    /// Container for the parameters to the CreateStorageVirtualMachinePeer operation. Creates
    /// a storage virtual machine (SVM) peer relationship between an SVM on an Amazon FSx
    /// for NetApp ONTAP file system and another SVM. <para> The <c>CreateStorageVirtualMachinePeer</c>
    /// operation returns while the SVM peer's lifecycle state is still <c>CREATING</c>. You
    /// can check the SVM peer creation status by calling the DescribeStorageVirtualMachinePeers
    /// operation. </para>
    /// </summary>
    public partial class CreateStorageVirtualMachinePeerRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// Specifies the applications that the SVM peer relationship authorizes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
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
        /// Gets and sets the property PeerClusterName. 
        /// <para>
        /// Specifies the name of the peer cluster that the peer SVM is on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 44)]
        public string PeerClusterName { get; set; }

        /// <summary>
        /// Checks to see if the PeerClusterName property is set.
        /// </summary>
        internal bool IsSetPeerClusterName() => this.PeerClusterName != null;

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
        /// Gets and sets the property PeerSvmName. 
        /// <para>
        /// Specifies the name of the SVM to peer with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 47)]
        public string PeerSvmName { get; set; }

        /// <summary>
        /// Checks to see if the PeerSvmName property is set.
        /// </summary>
        internal bool IsSetPeerSvmName() => this.PeerSvmName != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// Specifies the ID of the SVM on which to create the SVM peer relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
