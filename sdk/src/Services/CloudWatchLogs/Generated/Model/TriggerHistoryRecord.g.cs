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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A record of a scheduled query execution, including execution status, timestamp, and
    /// destination processing results.
    /// </summary>
    public partial class TriggerHistoryRecord
    {
        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// Information about destination processing for this query execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledQueryDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduledQueryDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message if the query execution failed.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The execution status of the scheduled query run.
        /// </para>
        /// </summary>
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The unique identifier for this query execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string QueryId { get; set; }

        /// <summary>
        /// Checks to see if the QueryId property is set.
        /// </summary>
        internal bool IsSetQueryId() => this.QueryId != null;

        /// <summary>
        /// Gets and sets the property TriggeredTimestamp. 
        /// <para>
        /// The timestamp when the scheduled query execution was triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TriggeredTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TriggeredTimestamp property is set.
        /// </summary>
        internal bool IsSetTriggeredTimestamp() => this.TriggeredTimestamp.HasValue;
    }
}
