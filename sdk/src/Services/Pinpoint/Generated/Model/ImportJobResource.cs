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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the resource settings for a job that imports endpoint definitions
    /// from one or more files. The files can be stored in an Amazon Simple Storage Service
    /// (Amazon S3) bucket or uploaded directly from a computer by using the Amazon Pinpoint
    /// console.
    /// </summary>
    public partial class ImportJobResource
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
        /// Gets and sets the property DefineSegment. 
        /// <para>
        /// Specifies whether the import job creates a segment that contains the endpoints, when
        /// the endpoint definitions are imported.
        /// </para>
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
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// (Deprecated) Your AWS account ID, which you assigned to an external ID key in an IAM
        /// trust policy. Amazon Pinpoint previously used this value to assume an IAM role when
        /// importing endpoint definitions, but we removed this requirement. We don't recommend
        /// use of external IDs for IAM roles that are assumed by Amazon Pinpoint.
        /// </para>
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
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the files that contain the endpoint definitions to import. Valid values
        /// are: CSV, for comma-separated values format; and, JSON, for newline-delimited JSON
        /// format.
        /// </para>
        ///  
        /// <para>
        /// If the files are stored in an Amazon S3 location and that location contains multiple
        /// files that use different formats, Amazon Pinpoint imports data only from the files
        /// that use the specified format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RegisterEndpoints. 
        /// <para>
        /// Specifies whether the import job registers the endpoints with Amazon Pinpoint, when
        /// the endpoint definitions are imported.
        /// </para>
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorizes Amazon Pinpoint to access the Amazon S3 location to import endpoint
        /// definitions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The URL of the Amazon Simple Storage Service (Amazon S3) bucket that contains the
        /// endpoint definitions to import. This location can be a folder or a single file. If
        /// the location is a folder, Amazon Pinpoint imports endpoint definitions from the files
        /// in this location, including any subfolders that the folder contains.
        /// </para>
        ///  
        /// <para>
        /// The URL should be in the following format: s3://<replaceable>bucket-name</replaceable>/<replaceable>folder-name</replaceable>/<replaceable>file-name</replaceable>.
        /// The location can end with the key for an individual object or a prefix that qualifies
        /// multiple objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The identifier for the segment that the import job updates or adds endpoint definitions
        /// to, if the import job updates an existing segment.
        /// </para>
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
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The custom name for the segment that's created by the import job, if the value of
        /// the DefineSegment property is true.
        /// </para>
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