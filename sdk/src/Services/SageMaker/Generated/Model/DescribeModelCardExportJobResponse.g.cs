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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeModelCardExportJob operation.
    /// </summary>
    public partial class DescribeModelCardExportJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the model export job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExportArtifacts. 
        /// <para>
        /// The exported model card artifacts.
        /// </para>
        /// </summary>
        public ModelCardExportArtifacts ExportArtifacts { get; set; }

        /// <summary>
        /// Checks to see if the ExportArtifacts property is set.
        /// </summary>
        internal bool IsSetExportArtifacts() => this.ExportArtifacts != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if the model export job fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time that the model export job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModelCardExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ModelCardExportJobArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardExportJobArn property is set.
        /// </summary>
        internal bool IsSetModelCardExportJobArn() => this.ModelCardExportJobArn != null;

        /// <summary>
        /// Gets and sets the property ModelCardExportJobName. 
        /// <para>
        /// The name of the model card export job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardExportJobName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardExportJobName property is set.
        /// </summary>
        internal bool IsSetModelCardExportJobName() => this.ModelCardExportJobName != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model card that the model export job
        /// exports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card that the model export job exports.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The export output details for the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCardExportOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The completion status of the model card export job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InProgress</c>: The model card export job is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c>: The model card export job is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The model card export job failed. To see the reason for the failure,
        /// see the <c>FailureReason</c> field in the response to a <c>DescribeModelCardExportJob</c>
        /// call.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCardExportJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
