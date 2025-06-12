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
    /// Provides information about the import job that created a segment. An import job is
    /// a job that creates a user segment by importing endpoint definitions.
    /// </summary>
    public partial class SegmentImportResource
    {
        private Dictionary<string, int> _channelCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private string _externalId;
        private Format _format;
        private string _roleArn;
        private string _s3Url;
        private int? _size;

        /// <summary>
        /// Gets and sets the property ChannelCounts. 
        /// <para>
        /// The number of channel types in the endpoint definitions that were imported to create
        /// the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ChannelCounts
        {
            get { return this._channelCounts; }
            set { this._channelCounts = value; }
        }

        // Check to see if ChannelCounts property is set
        internal bool IsSetChannelCounts()
        {
            return this._channelCounts != null && (this._channelCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        [AWSProperty(Required=true)]
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
        /// The format of the files that were imported to create the segment. Valid values are:
        /// CSV, for comma-separated values format; and, JSON, for newline-delimited JSON format.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that authorized Amazon Pinpoint to access the Amazon S3 location to import endpoint
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
        /// The URL of the Amazon Simple Storage Service (Amazon S3) bucket that the endpoint
        /// definitions were imported from to create the segment.
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
        /// Gets and sets the property Size. 
        /// <para>
        /// The number of endpoint definitions that were imported successfully to create the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}