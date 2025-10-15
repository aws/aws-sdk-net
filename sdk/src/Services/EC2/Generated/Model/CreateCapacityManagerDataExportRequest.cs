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
    /// Container for the parameters to the CreateCapacityManagerDataExport operation.
    /// Creates a new data export configuration for EC2 Capacity Manager. This allows you
    /// to automatically export capacity usage data to an S3 bucket on a scheduled basis.
    /// The exported data includes metrics for On-Demand, Spot, and Capacity Reservations
    /// usage across your organization.
    /// </summary>
    public partial class CreateCapacityManagerDataExportRequest : AmazonEC2Request
    {
        private string _clientToken;
        private OutputFormat _outputFormat;
        private string _s3BucketName;
        private string _s3BucketPrefix;
        private Schedule _schedule;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see Ensure Idempotency. 
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        ///  The file format for the exported data. Parquet format is recommended for large datasets
        /// and better compression. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The name of the S3 bucket where the capacity data export files will be delivered.
        /// The bucket must exist and you must have write permissions to it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The S3 key prefix for the exported data files. This allows you to organize exports
        /// in a specific folder structure within your bucket. If not specified, files are placed
        /// at the bucket root. 
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        ///  The tags to apply to the data export configuration. You can tag the export for organization
        /// and cost tracking purposes. 
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}