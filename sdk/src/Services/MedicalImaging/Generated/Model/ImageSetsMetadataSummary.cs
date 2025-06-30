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
    /// Summary of the image set metadata.
    /// </summary>
    public partial class ImageSetsMetadataSummary
    {
        private DateTime? _createdAt;
        private DICOMTags _dicomTags;
        private string _imageSetId;
        private bool? _isPrimary;
        private DateTime? _updatedAt;
        private int? _version;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time an image set is created. Sample creation date is provided in <c>1985-04-12T23:20:50.52Z</c>
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DICOMTags. 
        /// <para>
        /// The DICOM tags associated with the image set.
        /// </para>
        /// </summary>
        public DICOMTags DICOMTags
        {
            get { return this._dicomTags; }
            set { this._dicomTags = value; }
        }

        // Check to see if DICOMTags property is set
        internal bool IsSetDICOMTags()
        {
            return this._dicomTags != null;
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
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// The flag to determine whether the image set is primary or not.
        /// </para>
        /// </summary>
        public bool? IsPrimary
        {
            get { return this._isPrimary; }
            set { this._isPrimary = value; }
        }

        // Check to see if IsPrimary property is set
        internal bool IsSetIsPrimary()
        {
            return this._isPrimary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time an image set was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The image set version.
        /// </para>
        /// </summary>
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}