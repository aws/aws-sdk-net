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
    /// Container for the parameters to the CreateCapacityManagerDataExport operation. Creates
    /// a new data export configuration for EC2 Capacity Manager. This allows you to automatically
    /// export capacity usage data to an S3 bucket on a scheduled basis. The exported data
    /// includes metrics for On-Demand, Spot, and Capacity Reservations usage across your
    /// organization.
    /// </summary>
    public partial class CreateCapacityManagerDataExportRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see Ensure Idempotency. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        ///  Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        ///  The file format for the exported data. Parquet format is recommended for large datasets
        /// and better compression. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputFormat OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        ///  The name of the S3 bucket where the capacity data export files will be delivered.
        /// The bucket must exist and you must have write permissions to it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3BucketPrefix. 
        /// <para>
        ///  The S3 key prefix for the exported data files. This allows you to organize exports
        /// in a specific folder structure within your bucket. If not specified, files are placed
        /// at the bucket root. 
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
        [AWSProperty(Required = true)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        ///  The tags to apply to the data export configuration. You can tag the export for organization
        /// and cost tracking purposes. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
