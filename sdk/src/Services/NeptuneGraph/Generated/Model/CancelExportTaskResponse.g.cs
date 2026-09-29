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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the CancelExportTask operation.
    /// </summary>
    public partial class CancelExportTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon S3 URI of the cancelled export task where data will be exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the cancelled export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property GraphId. 
        /// <para>
        /// The source graph identifier of the cancelled export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphId { get; set; }

        /// <summary>
        /// Checks to see if the GraphId property is set.
        /// </summary>
        internal bool IsSetGraphId() => this.GraphId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The KMS key identifier of the cancelled export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the cancelled export task.
        /// </para>
        /// </summary>
        public ParquetType ParquetType { get; set; }

        /// <summary>
        /// Checks to see if the ParquetType property is set.
        /// </summary>
        internal bool IsSetParquetType() => this.ParquetType != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that will allow the exporting of data to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the export task. The status is <c>CANCELLING</c> when the export
        /// task is cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the export task has this status value.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
