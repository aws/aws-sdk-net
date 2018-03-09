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
    public partial class ExportJobResource
    {
        private string _roleArn;
        private string _s3UrlPrefix;
        private string _segmentId;

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of an IAM role
        /// that grants Amazon Pinpoint access to the Amazon S3 location that endpoints will be
        /// exported to.
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
        /// Gets and sets the property S3UrlPrefix. A URL that points to the location within an
        /// Amazon S3 bucket that will receive the export. The location is typically a folder
        /// with multiple files.The URL should follow this format: s3://bucket-name/folder-name/Amazon
        /// Pinpoint will export endpoints to this location.
        /// </summary>
        public string S3UrlPrefix
        {
            get { return this._s3UrlPrefix; }
            set { this._s3UrlPrefix = value; }
        }

        // Check to see if S3UrlPrefix property is set
        internal bool IsSetS3UrlPrefix()
        {
            return this._s3UrlPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentId. The ID of the segment to export endpoints from.
        /// If not present, all endpoints are exported.
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

    }
}