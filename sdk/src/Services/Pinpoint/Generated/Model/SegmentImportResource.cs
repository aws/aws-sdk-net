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
    /// Segment import definition.
    /// </summary>
    public partial class SegmentImportResource
    {
        private Dictionary<string, int> _channelCounts = new Dictionary<string, int>();
        private string _externalId;
        private Format _format;
        private string _roleArn;
        private string _s3Url;
        private int? _size;

        /// <summary>
        /// Gets and sets the property ChannelCounts. Channel type counts
        /// </summary>
        public Dictionary<string, int> ChannelCounts
        {
            get { return this._channelCounts; }
            set { this._channelCounts = value; }
        }

        // Check to see if ChannelCounts property is set
        internal bool IsSetChannelCounts()
        {
            return this._channelCounts != null && this._channelCounts.Count > 0; 
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
        /// Gets and sets the property Format. The format of the endpoint files that were imported
        /// to create this segment.Valid values: CSV, JSON
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
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of an IAM role
        /// that grants Amazon Pinpoint access to the endpoints in Amazon S3.
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
        /// Gets and sets the property S3Url. A URL that points to the Amazon S3 location from
        /// which the endpoints for this segment were imported.
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
        /// Gets and sets the property Size. The number of endpoints that were successfully imported
        /// to create this segment.
        /// </summary>
        public int Size
        {
            get { return this._size.GetValueOrDefault(); }
            set { this._size = value; }
        }

        // Check to see if Size property is set
        internal bool IsSetSize()
        {
            return this._size.HasValue; 
        }

    }
}