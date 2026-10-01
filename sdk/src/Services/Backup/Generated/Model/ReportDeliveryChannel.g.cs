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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains information from your report plan about where to deliver your reports, specifically
    /// your Amazon S3 bucket name, S3 key prefix, and the formats of your reports.
    /// </summary>
    public partial class ReportDeliveryChannel
    {
        /// <summary>
        /// Gets and sets the property Formats. 
        /// <para>
        /// The format of your reports: <c>CSV</c>, <c>JSON</c>, or both. If not specified, the
        /// default format is <c>CSV</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Formats { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Formats property is set.
        /// </summary>
        internal bool IsSetFormats() => this.Formats != null && (this.Formats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The unique name of the S3 bucket that receives your reports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// The prefix for where Backup Audit Manager delivers your reports to Amazon S3. The
        /// prefix is this part of the following path: s3://your-bucket-name/<c>prefix</c>/Backup/us-west-2/year/month/day/report-name.
        /// If not specified, there is no prefix.
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;
    }
}
