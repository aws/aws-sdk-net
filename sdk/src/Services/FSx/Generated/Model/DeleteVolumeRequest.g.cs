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
    /// Container for the parameters to the DeleteVolume operation. Deletes an Amazon FSx
    /// for NetApp ONTAP or Amazon FSx for OpenZFS volume.
    /// </summary>
    public partial class DeleteVolumeRequest : AmazonFSxRequest
    {
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
        /// Gets and sets the property OntapConfiguration. 
        /// <para>
        /// For Amazon FSx for ONTAP volumes, specify whether to take a final backup of the volume
        /// and apply tags to the backup. To apply tags to the backup, you must have the <c>fsx:TagResource</c>
        /// permission.
        /// </para>
        /// </summary>
        public DeleteVolumeOntapConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// For Amazon FSx for OpenZFS volumes, specify whether to delete all child volumes and
        /// snapshots.
        /// </para>
        /// </summary>
        public DeleteVolumeOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that you are deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 23, Max = 23)]
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
