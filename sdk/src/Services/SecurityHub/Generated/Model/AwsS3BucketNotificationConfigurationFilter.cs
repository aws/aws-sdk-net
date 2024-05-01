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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Filtering information for the notifications. The filtering is based on Amazon S3 key
    /// names.
    /// </summary>
    public partial class AwsS3BucketNotificationConfigurationFilter
    {
        private AwsS3BucketNotificationConfigurationS3KeyFilter _s3KeyFilter;

        /// <summary>
        /// Gets and sets the property S3KeyFilter. 
        /// <para>
        /// Details for an Amazon S3 filter.
        /// </para>
        /// </summary>
        public AwsS3BucketNotificationConfigurationS3KeyFilter S3KeyFilter
        {
            get { return this._s3KeyFilter; }
            set { this._s3KeyFilter = value; }
        }

        // Check to see if S3KeyFilter property is set
        internal bool IsSetS3KeyFilter()
        {
            return this._s3KeyFilter != null;
        }

    }
}