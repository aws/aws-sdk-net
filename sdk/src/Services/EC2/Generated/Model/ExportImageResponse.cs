/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// This is the response object from the ExportImage operation.
    /// </summary>
    public partial class ExportImageResponse : AmazonWebServiceResponse
    {
        private string _description;
        private DiskImageFormat _diskImageFormat;
        private string _exportImageTaskId;
        private string _imageId;
        private string _progress;
        private string _roleName;
        private ExportTaskS3Location _s3ExportLocation;
        private string _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the image being exported.
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
        /// The disk image format for the exported image.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExportImageTaskId. 
        /// <para>
        /// The ID of the export image task.
        /// </para>
        /// </summary>
        public string ExportImageTaskId
        {
            get { return this._exportImageTaskId; }
            set { this._exportImageTaskId = value; }
        }

        // Check to see if ExportImageTaskId property is set
        internal bool IsSetExportImageTaskId()
        {
            return this._exportImageTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Progress. 
        /// <para>
        /// The percent complete of the export image task.
        /// </para>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role that grants VM Import/Export permission to export images to your
        /// S3 bucket.
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
        /// Information about the destination S3 bucket.
        /// </para>
        /// </summary>
        public ExportTaskS3Location S3ExportLocation
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the export image task. The possible values are <code>active</code>,
        /// <code>completed</code>, <code>deleting</code>, and <code>deleted</code>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the export image task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}