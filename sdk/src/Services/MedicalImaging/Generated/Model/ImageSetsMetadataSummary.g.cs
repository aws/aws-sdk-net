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
    /// Summary of the image set metadata.
    /// </summary>
    public partial class ImageSetsMetadataSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time an image set is created. Sample creation date is provided in <c>1985-04-12T23:20:50.52Z</c>
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DICOMTags. 
        /// <para>
        /// The DICOM tags associated with the image set.
        /// </para>
        /// </summary>
        public DICOMTags DICOMTags { get; set; }

        /// <summary>
        /// Checks to see if the DICOMTags property is set.
        /// </summary>
        internal bool IsSetDICOMTags() => this.DICOMTags != null;

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
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// The flag to determine whether the image set is primary or not.
        /// </para>
        /// </summary>
        public bool? IsPrimary { get; set; }

        /// <summary>
        /// Checks to see if the IsPrimary property is set.
        /// </summary>
        internal bool IsSetIsPrimary() => this.IsPrimary.HasValue;

        /// <summary>
        /// Gets and sets the property LastAccessedAt. 
        /// <para>
        /// When the image set was last accessed.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedAt property is set.
        /// </summary>
        internal bool IsSetLastAccessedAt() => this.LastAccessedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StorageTier. 
        /// <para>
        /// The image set's storage tier.
        /// </para>
        /// </summary>
        public StorageTier StorageTier { get; set; }

        /// <summary>
        /// Checks to see if the StorageTier property is set.
        /// </summary>
        internal bool IsSetStorageTier() => this.StorageTier != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time an image set was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The image set version.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
