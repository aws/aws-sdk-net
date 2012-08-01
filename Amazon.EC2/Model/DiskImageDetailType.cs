/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Details about the format of the image.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DiskImageDetailType
    {    
        private string formatField;
        private Decimal? bytesField;
        private string importManifestUrlField;

        /// <summary>
        /// Gets and sets the Format property.
        /// File format of the disk image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Format")]
        public string Format
        {
            get { return this.formatField; }
            set { this.formatField = value; }
        }

        /// <summary>
        /// Sets the Format property
        /// </summary>
        /// <param name="format">File format of the disk image.</param>
        /// <returns>this instance</returns>
        public DiskImageDetailType WithFormat(string format)
        {
            this.formatField = format;
            return this;
        }

        /// <summary>
        /// Checks if Format property is set
        /// </summary>
        /// <returns>true if Format property is set</returns>
        public bool IsSetFormat()
        {
            return this.formatField != null;
        }

        /// <summary>
        /// Gets and sets the Bytes property.
        /// Number of bytes in the disk image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Bytes")]
        public Decimal Bytes
        {
            get { return this.bytesField.GetValueOrDefault(); }
            set { this.bytesField = value; }
        }

        /// <summary>
        /// Sets the Bytes property
        /// </summary>
        /// <param name="bytes">Number of bytes in the disk image.</param>
        /// <returns>this instance</returns>
        public DiskImageDetailType WithBytes(Decimal bytes)
        {
            this.bytesField = bytes;
            return this;
        }

        /// <summary>
        /// Checks if Bytes property is set
        /// </summary>
        /// <returns>true if Bytes property is set</returns>
        public bool IsSetBytes()
        {
            return this.bytesField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ImportManifestUrl property.
        /// The manifest for the disk image, stored in Amazon S3 and presented here as an Amazon S3 pre-signed URL. For information about 
        /// creating a pre-signed URL for an Amazon S3 object, read the "Query String Request Authentication Alternative" section of the 
        /// Authenticating REST Requests topic in the Amazon Simple Storage Service Developer Guide.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImportManifestUrl")]
        public string ImportManifestUrl
        {
            get { return this.importManifestUrlField; }
            set { this.importManifestUrlField = value; }
        }

        /// <summary>
        /// Sets the ImportManifestUrl property
        /// </summary>
        /// <param name="importManifestUrl">The manifest for the disk image, stored in Amazon S3 and presented here as an Amazon S3 pre-signed URL. For information about 
        /// creating a pre-signed URL for an Amazon S3 object, read the "Query String Request Authentication Alternative" section of the 
        /// Authenticating REST Requests topic in the Amazon Simple Storage Service Developer Guide.</param>
        /// <returns>this instance</returns>
        public DiskImageDetailType WithImportManifestUrl(string importManifestUrl)
        {
            this.importManifestUrlField = importManifestUrl;
            return this;
        }

        /// <summary>
        /// Checks if ImportManifestUrl property is set
        /// </summary>
        /// <returns>true if ImportManifestUrl property is set</returns>
        public bool IsSetImportManifestUrl()
        {
            return this.importManifestUrlField != null;
        }

    }
}
