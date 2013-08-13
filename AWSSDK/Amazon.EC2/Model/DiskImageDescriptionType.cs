/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

    [XmlRootAttribute(IsNullable = false)]
    public class DiskImageDescriptionType
    {    
        private string formatField;
        private Decimal? sizeField;
        private string importManifestUrlField;
        private string checksumField;

        /// <summary>
        /// Disk image format.
        /// </summary>
        [XmlElementAttribute(ElementName = "Format")]
        public string Format
        {
            get { return this.formatField; }
            set { this.formatField = value; }
        }

        /// <summary>
        /// Sets the disk image format.
        /// </summary>
        /// <param name="format">Disk image format.
        /// 
        /// Valid Values: VMDK | RAW</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DiskImageDescriptionType WithFormat(string format)
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
        /// Size of the disk image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public Decimal Size
        {
            get { return this.sizeField.GetValueOrDefault(); }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the size of the disk image.
        /// </summary>
        /// <param name="size">Size of the disk image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DiskImageDescriptionType WithSize(Decimal size)
        {
            this.sizeField = size;
            return this;
        }

        /// <summary>
        /// Checks if Size property is set
        /// </summary>
        /// <returns>true if Size property is set</returns>
        public bool IsSetSize()
        {
            return this.sizeField.HasValue;
        }

        /// <summary>
        /// A presigned URL for the import manifest stored in Amazon S3.
        /// </summary>
        /// <remarks>
        /// For information about creating a pre-signed URL for an Amazon S3 object,
        /// read the "Query String Request Authentication Alternative" section of the
        /// Authenticating REST Requests topic in the Amazon Simple Storage Service Developer Guide.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ImportManifestUrl")]
        public string ImportManifestUrl
        {
            get { return this.importManifestUrlField; }
            set { this.importManifestUrlField = value; }
        }

        /// <summary>
        /// Sets the presigned URL for the import manifest stored in Amazon S3.
        /// </summary>
        /// <param name="importManifestUrl">The manifest for the disk image, stored in Amazon S3 and presented here as an Amazon S3 pre-signed URL. For information about
        /// creating a pre-signed URL for an Amazon S3 object, read the "Query String Request Authentication Alternative" section of the
        /// Authenticating REST Requests topic in the Amazon Simple Storage Service Developer Guide.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DiskImageDescriptionType WithImportManifestUrl(string importManifestUrl)
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

        /// <summary>
        /// Checksum computed for the disk image.
        /// </summary>
        [XmlElementAttribute(ElementName = "Checksum")]
        public string Checksum
        {
            get { return this.checksumField; }
            set { this.checksumField = value; }
        }

        /// <summary>
        /// Sets the checksum computed for the disk image.
        /// </summary>
        /// <param name="checksum">Checksum computed for the disk image.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DiskImageDescriptionType WithChecksum(string checksum)
        {
            this.checksumField = checksum;
            return this;
        }

        /// <summary>
        /// Checks if Checksum property is set
        /// </summary>
        /// <returns>true if Checksum property is set</returns>
        public bool IsSetChecksum()
        {
            return this.checksumField != null;
        }

    }
}
