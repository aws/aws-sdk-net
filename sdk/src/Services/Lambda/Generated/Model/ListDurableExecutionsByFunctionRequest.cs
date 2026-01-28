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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
    /// Container for the parameters to the ListDurableExecutionsByFunction operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/lambda/latest/dg/durable-functions.html">durable
    /// executions</a> for a specified Lambda function. You can filter the results by execution
    /// name, status, and start time range. This API supports pagination for large result
    /// sets.
    /// </summary>
    public partial class ListDurableExecutionsByFunctionRequest : AmazonLambdaRequest
    {
        private string _durableExecutionName;
        private string _functionName;
        private string _marker;
        private int? _maxItems;
        private string _qualifier;
        private bool? _reverseOrder;
        private DateTime? _startedAfter;
        private DateTime? _startedBefore;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DurableExecutionName. 
        /// <para>
        /// Filter executions by name. Only executions with names that contain this string are
        /// returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DurableExecutionName
        {
            get { return this._durableExecutionName; }
            set { this._durableExecutionName = value; }
        }

        // Check to see if DurableExecutionName property is set
        internal bool IsSetDurableExecutionName()
        {
            return this._durableExecutionName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function. You can specify a function name, a partial
        /// ARN, or a full ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Pagination token from a previous request to continue retrieving results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Maximum number of executions to return (1-1000). Default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The function version or alias. If not specified, lists executions for the $LATEST
        /// version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReverseOrder. 
        /// <para>
        /// Set to true to return results in reverse chronological order (newest first). Default
        /// is false.
        /// </para>
        /// </summary>
        public bool? ReverseOrder
        {
            get { return this._reverseOrder; }
            set { this._reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this._reverseOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAfter. 
        /// <para>
        /// Filter executions that started after this timestamp (ISO 8601 format).
        /// </para>
        /// </summary>
        public DateTime? StartedAfter
        {
            get { return this._startedAfter; }
            set { this._startedAfter = value; }
        }

        // Check to see if StartedAfter property is set
        internal bool IsSetStartedAfter()
        {
            return this._startedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedBefore. 
        /// <para>
        /// Filter executions that started before this timestamp (ISO 8601 format).
        /// </para>
        /// </summary>
        public DateTime? StartedBefore
        {
            get { return this._startedBefore; }
            set { this._startedBefore = value; }
        }

        // Check to see if StartedBefore property is set
        internal bool IsSetStartedBefore()
        {
            return this._startedBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// Filter executions by status. Valid values: RUNNING, SUCCEEDED, FAILED, TIMED_OUT,
        /// STOPPED.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}