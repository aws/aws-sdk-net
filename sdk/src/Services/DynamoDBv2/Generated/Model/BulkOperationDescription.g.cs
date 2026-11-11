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
    /// Contains detailed information about a bulk operation.
    /// </summary>
    public partial class BulkOperationDescription
    {
        /// <summary>
        /// Gets and sets the property BulkOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bulk operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string BulkOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the BulkOperationArn property is set.
        /// </summary>
        internal bool IsSetBulkOperationArn() => this.BulkOperationArn != null;

        /// <summary>
        /// Gets and sets the property BulkOperationStatus. 
        /// <para>
        /// The current status of the bulk operation can be one of the following values:
        /// </para>
        ///  <dl> <dt> IN_PROGRESS </dt> <dd> 
        /// <para>
        /// DynamoDB is processing the input.
        /// </para>
        ///  </dd> <dt> COMPLETED </dt> <dd> 
        /// <para>
        /// The bulk operation finished without parsing or validation errors. Condition-check
        /// failures do not cause the operation to complete with errors.
        /// </para>
        ///  </dd> <dt> COMPLETED_WITH_ERRORS </dt> <dd> 
        /// <para>
        /// The bulk operation finished, but DynamoDB couldn't process at least one input item
        /// because of a parsing or validation error. When you enable <c>ERROR</c> output, DynamoDB
        /// writes the details to the configured Amazon S3 output location.
        /// </para>
        ///  </dd> <dt> CANCELLING </dt> <dd> 
        /// <para>
        /// DynamoDB accepted a cancellation request and is stopping the operation.
        /// </para>
        ///  </dd> <dt> CANCELLED </dt> <dd> 
        /// <para>
        /// DynamoDB stopped the operation after a cancellation request.
        /// </para>
        ///  </dd> <dt> FAILED </dt> <dd> 
        /// <para>
        /// The bulk operation failed. DynamoDB might write some items before the operation reaches
        /// this status. See <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_BulkOperationDescription.html#DDB-Type-BulkOperationDescription-FailureCode">FailureCode</a>
        /// and <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_BulkOperationDescription.html#DDB-Type-BulkOperationDescription-FailureMessage">FailureMessage</a>
        /// for details.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public BulkOperationStatus BulkOperationStatus { get; set; }

        /// <summary>
        /// Checks to see if the BulkOperationStatus property is set.
        /// </summary>
        internal bool IsSetBulkOperationStatus() => this.BulkOperationStatus != null;

        /// <summary>
        /// Gets and sets the property BulkOperationUsage. 
        /// <para>
        /// Usage information for the table and its indexes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BulkOperationUsage> BulkOperationUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<BulkOperationUsage>() : null;

        /// <summary>
        /// Checks to see if the BulkOperationUsage property is set.
        /// </summary>
        internal bool IsSetBulkOperationUsage() => this.BulkOperationUsage != null && (this.BulkOperationUsage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token associated with the start request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when the operation reached a terminal status. DynamoDB omits this value while
        /// the operation remains in progress.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailedItemCount. 
        /// <para>
        /// The number of processed input items that failed because of parsing or validation errors.
        /// This count is included in <c>ProcessedItemCount</c>. Condition-check failures do not
        /// increase this count.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FailedItemCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedItemCount property is set.
        /// </summary>
        internal bool IsSetFailedItemCount() => this.FailedItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// A code that identifies why the bulk operation failed or was cancelled. DynamoDB returns
        /// this value only when <c>BulkOperationStatus</c> is <c>FAILED</c> or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A message that describes why the bulk operation failed or was cancelled. DynamoDB
        /// returns this value only when <c>BulkOperationStatus</c> is <c>FAILED</c> or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property InputS3Configuration. 
        /// <para>
        /// The Amazon S3 input configuration associated with the bulk operation.
        /// </para>
        /// </summary>
        public InputS3Configuration InputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the InputS3Configuration property is set.
        /// </summary>
        internal bool IsSetInputS3Configuration() => this.InputS3Configuration != null;

        /// <summary>
        /// Gets and sets the property MaxWriteRequestUnits. 
        /// <para>
        /// The maximum write request unit rate configured for the bulk operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1024)]
        public long? MaxWriteRequestUnits { get; set; }

        /// <summary>
        /// Checks to see if the MaxWriteRequestUnits property is set.
        /// </summary>
        internal bool IsSetMaxWriteRequestUnits() => this.MaxWriteRequestUnits.HasValue;

        /// <summary>
        /// Gets and sets the property OutputS3Configuration. 
        /// <para>
        /// The Amazon S3 output configuration associated with the bulk operation.
        /// </para>
        /// </summary>
        public OutputS3Configuration OutputS3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Configuration property is set.
        /// </summary>
        internal bool IsSetOutputS3Configuration() => this.OutputS3Configuration != null;

        /// <summary>
        /// Gets and sets the property PerformanceTier. 
        /// <para>
        /// The performance tier selected for the bulk operation. Valid values are <c>STANDARD</c>
        /// and <c>ACCELERATED</c>. If the start request omitted this value, DynamoDB uses <c>STANDARD</c>.
        /// </para>
        /// </summary>
        public BulkOperationPerformanceTier PerformanceTier { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceTier property is set.
        /// </summary>
        internal bool IsSetPerformanceTier() => this.PerformanceTier != null;

        /// <summary>
        /// Gets and sets the property ProcessedInputBytes. 
        /// <para>
        /// The number of bytes that DynamoDB has read from the Amazon S3 input objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ProcessedInputBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedInputBytes property is set.
        /// </summary>
        internal bool IsSetProcessedInputBytes() => this.ProcessedInputBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessedItemCount. 
        /// <para>
        /// The number of input items that DynamoDB has processed. This count includes successful
        /// writes, parsing or validation failures, and condition-check failures.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ProcessedItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedItemCount property is set.
        /// </summary>
        internal bool IsSetProcessedItemCount() => this.ProcessedItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time when DynamoDB accepted the start request.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableDetails. 
        /// <para>
        /// A list containing identifying information for the table targeted by the bulk operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BulkOperationTableDetail> TableDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<BulkOperationTableDetail>() : null;

        /// <summary>
        /// Checks to see if the TableDetails property is set.
        /// </summary>
        internal bool IsSetTableDetails() => this.TableDetails != null && (this.TableDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalInputBytes. 
        /// <para>
        /// The total size, in bytes, of the Amazon S3 input objects. DynamoDB omits this value
        /// until the initial input-size calculation completes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalInputBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalInputBytes property is set.
        /// </summary>
        internal bool IsSetTotalInputBytes() => this.TotalInputBytes.HasValue;
    }
}
