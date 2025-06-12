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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
    /// This is the response object from the CopySnapshotAndUpdateVolume operation.
    /// </summary>
    public partial class CopySnapshotAndUpdateVolumeResponse : AmazonWebServiceResponse
    {
        private List<AdministrativeAction> _administrativeActions = AWSConfigs.InitializeCollections ? new List<AdministrativeAction>() : null;
        private VolumeLifecycle _lifecycle;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property AdministrativeActions. 
        /// <para>
        /// A list of administrative actions for the file system that are in process or waiting
        /// to be processed. Administrative actions describe changes to the Amazon FSx system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<AdministrativeAction> AdministrativeActions
        {
            get { return this._administrativeActions; }
            set { this._administrativeActions = value; }
        }

        // Check to see if AdministrativeActions property is set
        internal bool IsSetAdministrativeActions()
        {
            return this._administrativeActions != null && (this._administrativeActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle state of the destination volume. 
        /// </para>
        /// </summary>
        public VolumeLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that you copied the snapshot to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}