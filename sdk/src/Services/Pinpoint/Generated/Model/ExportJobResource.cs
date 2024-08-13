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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the resource settings for a job that exports endpoint definitions
    /// to a file. The file can be added directly to an Amazon Simple Storage Service (Amazon
    /// S3) bucket by using the Amazon Pinpoint API or downloaded directly to a computer by
    /// using the Amazon Pinpoint console.
    /// </summary>
    public partial class ExportJobResource
    {
        private string _roleArn;
        private string _s3UrlPrefix;
        private string _segmentId;
        private int? _segmentVersion;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorized Amazon Pinpoint to access the Amazon S3 location where the endpoint
        /// definitions were exported to.
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
        /// Gets and sets the property S3UrlPrefix. 
        /// <para>
        /// The URL of the location in an Amazon Simple Storage Service (Amazon S3) bucket where
        /// the endpoint definitions were exported to. This location is typically a folder that
        /// contains multiple files. The URL should be in the following format: s3://<replaceable>bucket-name</replaceable>/<replaceable>folder-name</replaceable>/.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The identifier for the segment that the endpoint definitions were exported from. If
        /// this value isn't present, Amazon Pinpoint exported definitions for all the endpoints
        /// that are associated with the application.
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
        /// Gets and sets the property SegmentVersion. 
        /// <para>
        /// The version of the segment that the endpoint definitions were exported from.
        /// </para>
        /// </summary>
        public int? SegmentVersion
        {
            get { return this._segmentVersion; }
            set { this._segmentVersion = value; }
        }

        // Check to see if SegmentVersion property is set
        internal bool IsSetSegmentVersion()
        {
            return this._segmentVersion.HasValue; 
        }

    }
}