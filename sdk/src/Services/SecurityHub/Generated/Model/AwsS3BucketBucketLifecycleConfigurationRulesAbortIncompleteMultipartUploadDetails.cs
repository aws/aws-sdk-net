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
    /// Information about what Amazon S3 does when a multipart upload is incomplete.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetails
    {
        private int? _daysAfterInitiation;

        /// <summary>
        /// Gets and sets the property DaysAfterInitiation. 
        /// <para>
        /// The number of days after which Amazon S3 cancels an incomplete multipart upload.
        /// </para>
        /// </summary>
        public int? DaysAfterInitiation
        {
            get { return this._daysAfterInitiation; }
            set { this._daysAfterInitiation = value; }
        }

        // Check to see if DaysAfterInitiation property is set
        internal bool IsSetDaysAfterInitiation()
        {
            return this._daysAfterInitiation.HasValue; 
        }

    }
}