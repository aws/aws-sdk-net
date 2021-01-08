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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ExportImage operation.
    /// Exports an Amazon Machine Image (AMI) to a VM file. For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport_image.html">Exporting
    /// a VM Directory from an Amazon Machine Image (AMI)</a> in the <i>VM Import/Export User
    /// Guide</i>.
    /// </summary>
    public partial class ExportImageRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private DiskImageFormat _diskImageFormat;
        private string _imageId;
        private string _roleName;
        private ExportTaskS3LocationRequest _s3ExportLocation;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Token to enable idempotency for export image requests.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the image being exported. The maximum length is 255 characters.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DiskImageFormat. 
        /// <para>
        /// The disk image format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiskImageFormat DiskImageFormat
        {
            get { return this._diskImageFormat; }
            set { this._diskImageFormat = value; }
        }

        // Check to see if DiskImageFormat property is set
        internal bool IsSetDiskImageFormat()
        {
            return this._diskImageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that grants VM Import/Export permission to export images to your
        /// Amazon S3 bucket. If this parameter is not specified, the default role is named 'vmimport'.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property S3ExportLocation. 
        /// <para>
        /// Information about the destination Amazon S3 bucket. The bucket must exist and grant
        /// WRITE and READ_ACP permissions to the AWS account vm-import-export@amazon.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportTaskS3LocationRequest S3ExportLocation
        {
            get { return this._s3ExportLocation; }
            set { this._s3ExportLocation = value; }
        }

        // Check to see if S3ExportLocation property is set
        internal bool IsSetS3ExportLocation()
        {
            return this._s3ExportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the image being exported.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}