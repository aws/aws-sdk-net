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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies connection options for DynamoDB ELT (Extract, Load, Transform) operations.
    /// This structure contains configuration parameters for connecting to and extracting
    /// data from DynamoDB tables using the ELT connector.
    /// </summary>
    public partial class DDBELTConnectionOptions
    {
        /// <summary>
        /// Gets and sets the property DynamodbExport. 
        /// <para>
        /// Specifies the export type for DynamoDB data extraction. This parameter determines
        /// how data is exported from the DynamoDB table during the ELT process.
        /// </para>
        /// </summary>
        public DdbExportType DynamodbExport { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbExport property is set.
        /// </summary>
        internal bool IsSetDynamodbExport() => this.DynamodbExport != null;

        /// <summary>
        /// Gets and sets the property DynamodbS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket used for intermediate storage during the DynamoDB
        /// ELT process. This bucket is used to temporarily store exported DynamoDB data before
        /// it is processed by the ELT job.
        /// </para>
        /// </summary>
        public string DynamodbS3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbS3Bucket property is set.
        /// </summary>
        internal bool IsSetDynamodbS3Bucket() => this.DynamodbS3Bucket != null;

        /// <summary>
        /// Gets and sets the property DynamodbS3BucketOwner. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the S3 bucket specified in <c>DynamodbS3Bucket</c>.
        /// This parameter is required when the S3 bucket is owned by a different Amazon Web Services
        /// account than the one running the ELT job, enabling cross-account access to the intermediate
        /// storage bucket.
        /// </para>
        /// </summary>
        public string DynamodbS3BucketOwner { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbS3BucketOwner property is set.
        /// </summary>
        internal bool IsSetDynamodbS3BucketOwner() => this.DynamodbS3BucketOwner != null;

        /// <summary>
        /// Gets and sets the property DynamodbS3Prefix. 
        /// <para>
        /// The S3 object key prefix for files stored in the intermediate S3 bucket during the
        /// DynamoDB ELT process. This prefix helps organize and identify the temporary files
        /// created during data extraction.
        /// </para>
        /// </summary>
        public string DynamodbS3Prefix { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbS3Prefix property is set.
        /// </summary>
        internal bool IsSetDynamodbS3Prefix() => this.DynamodbS3Prefix != null;

        /// <summary>
        /// Gets and sets the property DynamodbStsRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Security Token Service (STS)
        /// role to assume for accessing DynamoDB and S3 resources during the ELT operation. This
        /// role must have the necessary permissions to read from the DynamoDB table and write
        /// to the intermediate S3 bucket. 
        /// </para>
        /// </summary>
        public string DynamodbStsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbStsRoleArn property is set.
        /// </summary>
        internal bool IsSetDynamodbStsRoleArn() => this.DynamodbStsRoleArn != null;

        /// <summary>
        /// Gets and sets the property DynamodbTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DynamoDB table to extract data from. This parameter
        /// specifies the source table for the ELT operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DynamodbTableArn { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbTableArn property is set.
        /// </summary>
        internal bool IsSetDynamodbTableArn() => this.DynamodbTableArn != null;

        /// <summary>
        /// Gets and sets the property DynamodbUnnestDDBJson. 
        /// <para>
        /// A boolean value that specifies whether to unnest DynamoDB JSON format during data
        /// extraction. When set to <c>true</c>, the connector will flatten nested JSON structures
        /// from DynamoDB items. When set to <c>false</c>, the original DynamoDB JSON structure
        /// is preserved.
        /// </para>
        /// </summary>
        public bool? DynamodbUnnestDDBJson { get; set; }

        /// <summary>
        /// Checks to see if the DynamodbUnnestDDBJson property is set.
        /// </summary>
        internal bool IsSetDynamodbUnnestDDBJson() => this.DynamodbUnnestDDBJson.HasValue;
    }
}
