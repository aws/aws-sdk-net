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
    /// Provides information about the import job that created a segment. An import job is
    /// a job that creates a user segment by importing endpoint definitions.
    /// </summary>
    public partial class SegmentImportResource
    {
        /// <summary>
        /// Gets and sets the property ChannelCounts. 
        /// <para>
        /// The number of channel types in the endpoint definitions that were imported to create
        /// the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ChannelCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the ChannelCounts property is set.
        /// </summary>
        internal bool IsSetChannelCounts() => this.ChannelCounts != null && (this.ChannelCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// (Deprecated) Your AWS account ID, which you assigned to an external ID key in an IAM
        /// trust policy. Amazon Pinpoint previously used this value to assume an IAM role when
        /// importing endpoint definitions, but we removed this requirement. We don't recommend
        /// use of external IDs for IAM roles that are assumed by Amazon Pinpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the files that were imported to create the segment. Valid values are:
        /// CSV, for comma-separated values format; and, JSON, for newline-delimited JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorized Amazon Pinpoint to access the Amazon S3 location to import endpoint
        /// definitions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The URL of the Amazon Simple Storage Service (Amazon S3) bucket that the endpoint
        /// definitions were imported from to create the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3Url { get; set; }

        /// <summary>
        /// Checks to see if the S3Url property is set.
        /// </summary>
        internal bool IsSetS3Url() => this.S3Url != null;

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The number of endpoint definitions that were imported successfully to create the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Size { get; set; }

        /// <summary>
        /// Checks to see if the Size property is set.
        /// </summary>
        internal bool IsSetSize() => this.Size.HasValue;
    }
}
