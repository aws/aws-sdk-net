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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ImportJobRequest
    {
        private bool? _defineSegment;
        private string _externalId;
        private Format _format;
        private bool? _registerEndpoints;
        private string _roleArn;
        private string _s3Url;
        private string _segmentId;
        private string _segmentName;

        /// <summary>
        /// Gets and sets the property DefineSegment. Sets whether the endpoints create a segment
        /// when they are imported.
        /// </summary>
        public bool DefineSegment
        {
            get { return this._defineSegment.GetValueOrDefault(); }
            set { this._defineSegment = value; }
        }

        // Check to see if DefineSegment property is set
        internal bool IsSetDefineSegment()
        {
            return this._defineSegment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExternalId. DEPRECATED. Your AWS account ID, which you
        /// assigned to the ExternalID key in an IAM trust policy. Used by Amazon Pinpoint to
        /// assume an IAM role. This requirement is removed, and external IDs are not recommended
        /// for IAM roles assumed by Amazon Pinpoint.
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property Format. The format of the files that contain the endpoint
        /// definitions.Valid values: CSV, JSON
        /// </summary>
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property RegisterEndpoints. Sets whether the endpoints are registered
        /// with Amazon Pinpoint when they are imported.
        /// </summary>
        public bool RegisterEndpoints
        {
            get { return this._registerEndpoints.GetValueOrDefault(); }
            set { this._registerEndpoints = value; }
        }

        // Check to see if RegisterEndpoints property is set
        internal bool IsSetRegisterEndpoints()
        {
            return this._registerEndpoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of an IAM role
        /// that grants Amazon Pinpoint access to the Amazon S3 location that contains the endpoints
        /// to import.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Url. A URL that points to the location within an Amazon
        /// S3 bucket that contains the endpoints to import. The location can be a folder or a
        /// single file.The URL should follow this format: s3://bucket-name/folder-name/file-nameAmazon
        /// Pinpoint will import endpoints from this location and any subfolders it contains.
        /// </summary>
        public string S3Url
        {
            get { return this._s3Url; }
            set { this._s3Url = value; }
        }

        // Check to see if S3Url property is set
        internal bool IsSetS3Url()
        {
            return this._s3Url != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentId. The ID of the segment to update if the import
        /// job is meant to update an existing segment.
        /// </summary>
        public string SegmentId
        {
            get { return this._segmentId; }
            set { this._segmentId = value; }
        }

        // Check to see if SegmentId property is set
        internal bool IsSetSegmentId()
        {
            return this._segmentId != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentName. A custom name for the segment created by the
        /// import job. Use if DefineSegment is true.
        /// </summary>
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

    }
}