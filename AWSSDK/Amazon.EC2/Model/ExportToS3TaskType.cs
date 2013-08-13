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
    ///<summary>
    /// Information about the destination Amazon S3 bucket for a VM export task.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ExportToS3TaskType
    {
        private string diskImageFormatField;
        private string containerFormatField;
        private string s3BucketField;
        private string s3PrefixField;
        private string s3KeyField;

        /// <summary>
        /// The format for the exported image.
        /// </summary>
        /// <remarks>Valid Values: vmdk | vhd</remarks>
        [XmlElementAttribute(ElementName = "DiskImageFormat")]
        public string DiskImageFormat
        {
            get { return this.diskImageFormatField; }
            set { this.diskImageFormatField = value; }
        }

        /// <summary>
        /// Sets the format for the exported image.
        /// Default: vmdk if TargetEnvironment = vmware, otherwise vhd
        /// </summary>
        /// <param name="diskImageFormat">Disk image format; valid Values: vmdk | vhd</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExportToS3TaskType WithDiskImageFormat(string diskImageFormat)
        {
            this.diskImageFormatField = diskImageFormat;
            return this;
        }

        /// <summary>
        /// Checks if the DiskImageFormat property is set.
        /// </summary>
        /// <returns>True if the DiskImageFormat property is set</returns>
        public bool IsSetDiskImageFormat()
        {
            return !string.IsNullOrEmpty(this.diskImageFormatField);
        }

        /// <summary>
        /// The container format used to combine disk images with metadata (such as OVF).
        /// If absent, only the disk image will be exported.
        /// Default: ova if TargetEnvironment = vmare, otherwise blank.
        /// </summary>
        /// <remarks>Valid Values: ova</remarks>
        [XmlElementAttribute(ElementName = "ContainerFormat")]
        public string ContainerFormat
        {
            get { return this.containerFormatField; }
            set { this.containerFormatField = value; }
        }

        /// <summary>
        /// Sets the container format used to combine disk images with metadata (such as OVF).
        /// </summary>
        /// <param name="containerFormat">Container format; valid values: ova</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExportToS3TaskType WithContainerFormat(string containerFormat)
        {
            this.containerFormatField = containerFormat;
            return this;
        }

        /// <summary>
        /// Checks if the ContainerFormat property is set
        /// </summary>
        /// <returns>True if the ContainerFormat property is set</returns>
        public bool IsSetContainerFormat()
        {
            return !string.IsNullOrEmpty(this.containerFormatField);
        }

        /// <summary>
        /// The Amazon S3 bucket for the destination image.
        /// </summary>
        /// <remarks>The bucket must exist and grant write permissions to AWS account vm-import-export@amazon.com.</remarks>
        [XmlElementAttribute(ElementName = "S3Bucket")]
        public string S3Bucket
        {
            get { return this.s3BucketField; }
            set { this.s3BucketField = value; }
        }

        /// <summary>
        /// Sets the Amazon S3 bucket for the destination image. The bucket must exist and grant write permissions to AWS account vm-import-export@amazon.com.
        /// </summary>
        /// <param name="s3Bucket">S3 bucket name</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExportToS3TaskType WithS3Bucket(string s3Bucket)
        {
            this.s3BucketField = s3Bucket;
            return this;
        }

        /// <summary>
        /// Checks if the S3Bucket property is set.
        /// </summary>
        /// <returns>True if the S3Bucket property is set</returns>
        public bool IsSetS3Bucket()
        {
            return !string.IsNullOrEmpty(this.s3BucketField);
        }

        /// <summary>
        /// The key prefix used when writing the image to a single object in the bucket.
        /// </summary>
        /// <remarks>This property is used when the ExportToS3TaskType instance is used as input to
        /// the CreateInstanceExportTask operation. The resulting S3 object key will be set as
        /// 'S3Prefix + exportTaskId + ‘.’ +diskImageFormat'.
        /// </remarks>
        [XmlElementAttribute(ElementName = "S3Prefix")]
        public string S3Prefix
        {
            get { return this.s3PrefixField; }
            set { this.s3PrefixField = value; }
        }

        /// <summary>
        /// Sets the key prefix to use when writing the image to S3 for a CreateInstanceExportTask operation.
        /// </summary>
        /// <param name="s3Prefix">Key prefix; full key will be set as S3Prefix + exportTaskId + ‘.’ +diskImageFormat.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ExportToS3TaskType WithS3Prefix(string s3Prefix)
        {
            this.s3PrefixField = s3Prefix;
            return this;
        }

        /// <summary>
        /// Checks if the S3Prefix property is set.
        /// </summary>
        /// <returns>True if the S3Prefix property is set.</returns>
        public bool IsSetS3Prefix()
        {
            return !string.IsNullOrEmpty(this.s3PrefixField);
        }

        /// <summary>
        /// The full S3 key that was used when writing the exported instance to S3.
        /// </summary>
        /// <remarks>
        /// This property is only set on return from the CreateInstanceExportTask operation.
        /// The S3 object key is in the form 'S3Prefix + exportTaskId + ‘.’ +diskImageFormat'.
        /// </remarks>
        [XmlElementAttribute(ElementName = "S3Key")]
        public string S3Key
        {
            get { return this.s3KeyField; }
            set { this.s3KeyField = value; }
        }

        /// <summary>
        /// Checks if the S3Key property is set.
        /// </summary>
        /// <returns>True if the S3Key property is set.</returns>
        public bool IsSetS3Key()
        {
            return !string.IsNullOrEmpty(this.s3KeyField);
        }
    }
}
