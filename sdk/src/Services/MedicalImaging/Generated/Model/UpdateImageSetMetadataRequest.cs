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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImageSetMetadata operation.
    /// Update image set metadata attributes.
    /// </summary>
    public partial class UpdateImageSetMetadataRequest : AmazonMedicalImagingRequest
    {
        private string _datastoreId;
        private bool? _force;
        private string _imageSetId;
        private string _latestVersionId;
        private MetadataUpdates _updateImageSetMetadataUpdates;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Setting this flag will force the <c>UpdateImageSetMetadata</c> operation for the following
        /// attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Tag.StudyInstanceUID</c>, <c>Tag.SeriesInstanceUID</c>, <c>Tag.SOPInstanceUID</c>,
        /// and <c>Tag.StudyID</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Adding, removing, or updating private tags for an individual SOP Instance
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageSetId
        {
            get { return this._imageSetId; }
            set { this._imageSetId = value; }
        }

        // Check to see if ImageSetId property is set
        internal bool IsSetImageSetId()
        {
            return this._imageSetId != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersionId. 
        /// <para>
        /// The latest image set version identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LatestVersionId
        {
            get { return this._latestVersionId; }
            set { this._latestVersionId = value; }
        }

        // Check to see if LatestVersionId property is set
        internal bool IsSetLatestVersionId()
        {
            return this._latestVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateImageSetMetadataUpdates. 
        /// <para>
        /// Update image set metadata updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataUpdates UpdateImageSetMetadataUpdates
        {
            get { return this._updateImageSetMetadataUpdates; }
            set { this._updateImageSetMetadataUpdates = value; }
        }

        // Check to see if UpdateImageSetMetadataUpdates property is set
        internal bool IsSetUpdateImageSetMetadataUpdates()
        {
            return this._updateImageSetMetadataUpdates != null;
        }

    }
}