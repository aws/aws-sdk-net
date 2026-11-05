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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListDurableExecutionsByFunction operation. Returns
    /// a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// executions</a> for a specified Lambda function. You can filter the results by execution
    /// name, status, and start time range. This API supports pagination for large result
    /// sets.
    /// </summary>
    public partial class ListDurableExecutionsByFunctionRequest : AmazonLambdaRequest
    {
        /// <summary>
        /// Gets and sets the property DurableExecutionName. 
        /// <para>
        /// Filter executions by name. Only executions with names that matches this string are
        /// returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DurableExecutionName { get; set; }

        /// <summary>
        /// Checks to see if the DurableExecutionName property is set.
        /// </summary>
        internal bool IsSetDurableExecutionName() => this.DurableExecutionName != null;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function. You can specify a function name, a partial
        /// ARN, or a full ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Pagination token from a previous request to continue retrieving results.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Maximum number of executions to return (1-1000). Default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The function version to filter executions by. If you don't specify a qualifier, this
        /// operation returns executions across all versions of the Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// Set to true to return results in chronological order (oldest first). Default is false.
        /// </para>
        /// </summary>
        public bool? ReverseOrder { get; set; }

        /// <summary>
        /// Checks to see if the ReverseOrder property is set.
        /// </summary>
        internal bool IsSetReverseOrder() => this.ReverseOrder.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter executions that started after this timestamp (ISO 8601 format).
        /// </para>
        /// </summary>
        public DateTime? StartedAfter { get; set; }

        /// <summary>
        /// Checks to see if the StartedAfter property is set.
        /// </summary>
        internal bool IsSetStartedAfter() => this.StartedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter executions that started before this timestamp (ISO 8601 format).
        /// </para>
        /// </summary>
        public DateTime? StartedBefore { get; set; }

        /// <summary>
        /// Checks to see if the StartedBefore property is set.
        /// </summary>
        internal bool IsSetStartedBefore() => this.StartedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Filter executions by status. Valid values: RUNNING, SUCCEEDED, FAILED, TIMED_OUT,
        /// STOPPED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
