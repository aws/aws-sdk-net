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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Summary information about the source file for the import.
    /// </summary>
    public partial class ImportSummary
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the Cloudwatch Log Group associated with this
        /// import task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CloudWatchLogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogGroupArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogGroupArn() => this.CloudWatchLogGroupArn != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The time at which this import task ended. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) corresponding to the import request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string ImportArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportArn property is set.
        /// </summary>
        internal bool IsSetImportArn() => this.ImportArn != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import operation. 
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  The format of the source data. Valid values are <c>CSV</c>, <c>DYNAMODB_JSON</c>
        /// or <c>ION</c>.
        /// </para>
        /// </summary>
        public InputFormat InputFormat { get; set; }

        /// <summary>
        /// Checks to see if the InputFormat property is set.
        /// </summary>
        internal bool IsSetInputFormat() => this.InputFormat != null;

        /// <summary>
        /// Gets and sets the property S3BucketSource. 
        /// <para>
        ///  The path and S3 bucket of the source file that is being imported. This includes the
        /// S3Bucket (required), S3KeyPrefix (optional) and S3BucketOwner (optional if the bucket
        /// is owned by the requester). 
        /// </para>
        /// </summary>
        public S3BucketSource S3BucketSource { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketSource property is set.
        /// </summary>
        internal bool IsSetS3BucketSource() => this.S3BucketSource != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The time at which this import task began. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the table being imported into. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;
    }
}
