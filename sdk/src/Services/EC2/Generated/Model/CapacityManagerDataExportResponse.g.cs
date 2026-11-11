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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about a Capacity Manager data export configuration, including
    /// export settings, delivery status, and recent export activity.
    /// </summary>
    public partial class CapacityManagerDataExportResponse
    {
        /// <summary>
        /// Gets and sets the property CapacityManagerDataExportId. 
        /// <para>
        ///  The unique identifier for the data export configuration. 
        /// </para>
        /// </summary>
        public string CapacityManagerDataExportId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityManagerDataExportId property is set.
        /// </summary>
        internal bool IsSetCapacityManagerDataExportId() => this.CapacityManagerDataExportId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The timestamp when the data export configuration was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestDeliveryS3LocationUri. 
        /// <para>
        ///  The S3 URI of the most recently delivered export file. 
        /// </para>
        /// </summary>
        public string LatestDeliveryS3LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryS3LocationUri property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryS3LocationUri() => this.LatestDeliveryS3LocationUri != null;

        /// <summary>
        /// Gets and sets the property LatestDeliveryStatus. 
        /// <para>
        ///  The status of the most recent export delivery. 
        /// </para>
        /// </summary>
        public CapacityManagerDataExportStatus LatestDeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryStatus property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryStatus() => this.LatestDeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property LatestDeliveryStatusMessage. 
        /// <para>
        ///  A message describing the status of the most recent export delivery, including any
        /// error details if the delivery failed. 
        /// </para>
        /// </summary>
        public string LatestDeliveryStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryStatusMessage property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryStatusMessage() => this.LatestDeliveryStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LatestDeliveryTime. 
        /// <para>
        ///  The timestamp when the most recent export was delivered to S3. 
        /// </para>
        /// </summary>
        public DateTime? LatestDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLatestDeliveryTime() => this.LatestDeliveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        ///  The file format of the exported data. 
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        ///  The name of the S3 bucket where export files are delivered. 
        /// </para>
        /// </summary>
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3BucketPrefix. 
        /// <para>
        ///  The S3 key prefix used for organizing export files within the bucket. 
        /// </para>
        /// </summary>
        public string S3BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketPrefix property is set.
        /// </summary>
        internal bool IsSetS3BucketPrefix() => this.S3BucketPrefix != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The frequency at which data exports are generated. 
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the data export configuration. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
