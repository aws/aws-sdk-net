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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the ListRuns operation. Retrieves a list of runs and
    /// returns each run's metadata and status. <para> Amazon Web Services HealthOmics stores
    /// a configurable number of runs, as determined by service limits, that are available
    /// to the console and API. If the <c>ListRuns</c> response doesn't include specific runs
    /// that you expected, you can find all run logs in the CloudWatch logs. For more information
    /// about viewing the run logs, see <a href="https://docs.aws.amazon.com/omics/latest/dev/monitoring-cloudwatch-logs.html">CloudWatch
    /// logs</a> in the <i>Amazon Web Services HealthOmics User Guide</i>. </para>
    /// </summary>
    public partial class ListRunsRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property BatchId. 
        /// <para>
        /// Filter by batch ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string BatchId { get; set; }

        /// <summary>
        /// Checks to see if the BatchId property is set.
        /// </summary>
        internal bool IsSetBatchId() => this.BatchId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of runs to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filter the list by run name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RunGroupId. 
        /// <para>
        /// Filter the list by run group ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 18)]
        public string RunGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RunGroupId property is set.
        /// </summary>
        internal bool IsSetRunGroupId() => this.RunGroupId != null;

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StartingToken { get; set; }

        /// <summary>
        /// Checks to see if the StartingToken property is set.
        /// </summary>
        internal bool IsSetStartingToken() => this.StartingToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public RunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
