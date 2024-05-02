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
    /// This is the response object from the DeleteVolume operation.
    /// </summary>
    public partial class DeleteVolumeResponse : AmazonWebServiceResponse
    {
        private VolumeLifecycle _lifecycle;
        private DeleteVolumeOntapResponse _ontapResponse;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle state of the volume being deleted. If the <c>DeleteVolume</c> operation
        /// is successful, this value is <c>DELETING</c>.
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
        /// Gets and sets the property OntapResponse. 
        /// <para>
        /// Returned after a <c>DeleteVolume</c> request, showing the status of the delete request.
        /// </para>
        /// </summary>
        public DeleteVolumeOntapResponse OntapResponse
        {
            get { return this._ontapResponse; }
            set { this._ontapResponse = value; }
        }

        // Check to see if OntapResponse property is set
        internal bool IsSetOntapResponse()
        {
            return this._ontapResponse != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that's being deleted.
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