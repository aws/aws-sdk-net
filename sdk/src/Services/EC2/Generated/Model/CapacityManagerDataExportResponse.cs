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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _capacityManagerDataExportId;
        private DateTime? _createTime;
        private string _latestDeliveryS3LocationUri;
        private CapacityManagerDataExportStatus _latestDeliveryStatus;
        private string _latestDeliveryStatusMessage;
        private DateTime? _latestDeliveryTime;
        private OutputFormat _outputFormat;
        private string _s3BucketName;
        private string _s3BucketPrefix;
        private Schedule _schedule;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CapacityManagerDataExportId. 
        /// <para>
        ///  The unique identifier for the data export configuration. 
        /// </para>
        /// </summary>
        public string CapacityManagerDataExportId
        {
            get { return this._capacityManagerDataExportId; }
            set { this._capacityManagerDataExportId = value; }
        }

        // Check to see if CapacityManagerDataExportId property is set
        internal bool IsSetCapacityManagerDataExportId()
        {
            return this._capacityManagerDataExportId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        ///  The timestamp when the data export configuration was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryS3LocationUri. 
        /// <para>
        ///  The S3 URI of the most recently delivered export file. 
        /// </para>
        /// </summary>
        public string LatestDeliveryS3LocationUri
        {
            get { return this._latestDeliveryS3LocationUri; }
            set { this._latestDeliveryS3LocationUri = value; }
        }

        // Check to see if LatestDeliveryS3LocationUri property is set
        internal bool IsSetLatestDeliveryS3LocationUri()
        {
            return this._latestDeliveryS3LocationUri != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryStatus. 
        /// <para>
        ///  The status of the most recent export delivery. 
        /// </para>
        /// </summary>
        public CapacityManagerDataExportStatus LatestDeliveryStatus
        {
            get { return this._latestDeliveryStatus; }
            set { this._latestDeliveryStatus = value; }
        }

        // Check to see if LatestDeliveryStatus property is set
        internal bool IsSetLatestDeliveryStatus()
        {
            return this._latestDeliveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryStatusMessage. 
        /// <para>
        ///  A message describing the status of the most recent export delivery, including any
        /// error details if the delivery failed. 
        /// </para>
        /// </summary>
        public string LatestDeliveryStatusMessage
        {
            get { return this._latestDeliveryStatusMessage; }
            set { this._latestDeliveryStatusMessage = value; }
        }

        // Check to see if LatestDeliveryStatusMessage property is set
        internal bool IsSetLatestDeliveryStatusMessage()
        {
            return this._latestDeliveryStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeliveryTime. 
        /// <para>
        ///  The timestamp when the most recent export was delivered to S3. 
        /// </para>
        /// </summary>
        public DateTime? LatestDeliveryTime
        {
            get { return this._latestDeliveryTime; }
            set { this._latestDeliveryTime = value; }
        }

        // Check to see if LatestDeliveryTime property is set
        internal bool IsSetLatestDeliveryTime()
        {
            return this._latestDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        ///  The file format of the exported data. 
        /// </para>
        /// </summary>
        public OutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        ///  The name of the S3 bucket where export files are delivered. 
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketPrefix. 
        /// <para>
        ///  The S3 key prefix used for organizing export files within the bucket. 
        /// </para>
        /// </summary>
        public string S3BucketPrefix
        {
            get { return this._s3BucketPrefix; }
            set { this._s3BucketPrefix = value; }
        }

        // Check to see if S3BucketPrefix property is set
        internal bool IsSetS3BucketPrefix()
        {
            return this._s3BucketPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The frequency at which data exports are generated. 
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags associated with the data export configuration. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}