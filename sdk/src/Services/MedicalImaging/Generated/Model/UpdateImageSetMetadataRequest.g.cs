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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateImageSetMetadata operation. Update image
    /// set metadata attributes.
    /// </summary>
    public partial class UpdateImageSetMetadataRequest : AmazonMedicalImagingRequest
    {
        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

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
        public bool? Force { get; set; }

        /// <summary>
        /// Checks to see if the Force property is set.
        /// </summary>
        internal bool IsSetForce() => this.Force.HasValue;

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageSetId { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetId property is set.
        /// </summary>
        internal bool IsSetImageSetId() => this.ImageSetId != null;

        /// <summary>
        /// Gets and sets the property IncludeStudyImageSets. 
        /// <para>
        /// Flag to apply the metadata updates to all image sets in the same Study as the requested
        /// image set ID.
        /// </para>
        /// </summary>
        public bool? IncludeStudyImageSets { get; set; }

        /// <summary>
        /// Checks to see if the IncludeStudyImageSets property is set.
        /// </summary>
        internal bool IsSetIncludeStudyImageSets() => this.IncludeStudyImageSets.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersionId. 
        /// <para>
        /// The latest image set version identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionId property is set.
        /// </summary>
        internal bool IsSetLatestVersionId() => this.LatestVersionId != null;

        /// <summary>
        /// Gets and sets the property UpdateImageSetMetadataUpdates. 
        /// <para>
        /// Update image set metadata updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetadataUpdates UpdateImageSetMetadataUpdates { get; set; }

        /// <summary>
        /// Checks to see if the UpdateImageSetMetadataUpdates property is set.
        /// </summary>
        internal bool IsSetUpdateImageSetMetadataUpdates() => this.UpdateImageSetMetadataUpdates != null;
    }
}
