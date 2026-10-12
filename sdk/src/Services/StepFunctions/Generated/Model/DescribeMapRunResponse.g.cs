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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// This is the response object from the DescribeMapRun operation.
    /// </summary>
    public partial class DescribeMapRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the execution in which the Map Run
        /// was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExecutionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionArn property is set.
        /// </summary>
        internal bool IsSetExecutionArn() => this.ExecutionArn != null;

        /// <summary>
        /// Gets and sets the property ExecutionCounts. 
        /// <para>
        /// A JSON object that contains information about the total number of child workflow executions
        /// for the Map Run, and the count of child workflow executions for each status, such
        /// as <c>failed</c> and <c>succeeded</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MapRunExecutionCounts ExecutionCounts { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionCounts property is set.
        /// </summary>
        internal bool IsSetExecutionCounts() => this.ExecutionCounts != null;

        /// <summary>
        /// Gets and sets the property ItemCounts. 
        /// <para>
        /// A JSON object that contains information about the total number of items, and the item
        /// count for each processing status, such as <c>pending</c> and <c>failed</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MapRunItemCounts ItemCounts { get; set; }

        /// <summary>
        /// Checks to see if the ItemCounts property is set.
        /// </summary>
        internal bool IsSetItemCounts() => this.ItemCounts != null;

        /// <summary>
        /// Gets and sets the property MapRunArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies a Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string MapRunArn { get; set; }

        /// <summary>
        /// Checks to see if the MapRunArn property is set.
        /// </summary>
        internal bool IsSetMapRunArn() => this.MapRunArn != null;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The maximum number of child workflow executions configured to run in parallel for
        /// the Map Run at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property RedriveCount. 
        /// <para>
        /// The number of times you've redriven a Map Run. If you have not yet redriven a Map
        /// Run, the <c>redriveCount</c> is 0. This count is only updated if you successfully
        /// redrive a Map Run.
        /// </para>
        /// </summary>
        public int? RedriveCount { get; set; }

        /// <summary>
        /// Checks to see if the RedriveCount property is set.
        /// </summary>
        internal bool IsSetRedriveCount() => this.RedriveCount.HasValue;

        /// <summary>
        /// Gets and sets the property RedriveDate. 
        /// <para>
        /// The date a Map Run was last redriven. If you have not yet redriven a Map Run, the
        /// <c>redriveDate</c> is null.
        /// </para>
        /// </summary>
        public DateTime? RedriveDate { get; set; }

        /// <summary>
        /// Checks to see if the RedriveDate property is set.
        /// </summary>
        internal bool IsSetRedriveDate() => this.RedriveDate.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date when the Map Run was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Map Run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MapRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StopDate. 
        /// <para>
        /// The date when the Map Run was stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// Checks to see if the StopDate property is set.
        /// </summary>
        internal bool IsSetStopDate() => this.StopDate.HasValue;

        /// <summary>
        /// Gets and sets the property ToleratedFailureCount. 
        /// <para>
        /// The maximum number of failed child workflow executions before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public long? ToleratedFailureCount { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailureCount property is set.
        /// </summary>
        internal bool IsSetToleratedFailureCount() => this.ToleratedFailureCount.HasValue;

        /// <summary>
        /// Gets and sets the property ToleratedFailurePercentage. 
        /// <para>
        /// The maximum percentage of failed child workflow executions before the Map Run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public float? ToleratedFailurePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ToleratedFailurePercentage property is set.
        /// </summary>
        internal bool IsSetToleratedFailurePercentage() => this.ToleratedFailurePercentage.HasValue;
    }
}
