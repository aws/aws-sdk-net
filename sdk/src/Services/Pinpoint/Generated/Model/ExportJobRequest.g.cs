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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Specifies the settings for a job that exports endpoint definitions to an Amazon Simple
    /// Storage Service (Amazon S3) bucket.
    /// </summary>
    public partial class ExportJobRequest
    {
        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorizes Amazon Pinpoint to access the Amazon S3 location where you want to
        /// export endpoint definitions to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property S3UrlPrefix. 
        /// <para>
        /// The URL of the location in an Amazon Simple Storage Service (Amazon S3) bucket where
        /// you want to export endpoint definitions to. This location is typically a folder that
        /// contains multiple files. The URL should be in the following format: s3://<replaceable>bucket-name</replaceable>/<replaceable>folder-name</replaceable>/.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3UrlPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3UrlPrefix property is set.
        /// </summary>
        internal bool IsSetS3UrlPrefix() => this.S3UrlPrefix != null;

        /// <summary>
        /// Gets and sets the property SegmentId. 
        /// <para>
        /// The identifier for the segment to export endpoint definitions from. If you don't specify
        /// this value, Amazon Pinpoint exports definitions for all the endpoints that are associated
        /// with the application.
        /// </para>
        /// </summary>
        public string SegmentId { get; set; }

        /// <summary>
        /// Checks to see if the SegmentId property is set.
        /// </summary>
        internal bool IsSetSegmentId() => this.SegmentId != null;

        /// <summary>
        /// Gets and sets the property SegmentVersion. 
        /// <para>
        /// The version of the segment to export endpoint definitions from, if specified.
        /// </para>
        /// </summary>
        public int? SegmentVersion { get; set; }

        /// <summary>
        /// Checks to see if the SegmentVersion property is set.
        /// </summary>
        internal bool IsSetSegmentVersion() => this.SegmentVersion.HasValue;
    }
}
