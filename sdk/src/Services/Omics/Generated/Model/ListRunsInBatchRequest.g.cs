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
    /// Container for the parameters to the ListRunsInBatch operation. Returns a paginated
    /// list of individual workflow runs within a specific batch. Use this operation to map
    /// each <c>runSettingId</c> to its HealthOmics-generated <c>runId</c>, and to check the
    /// submission status of each run. Only one filter per call is supported.
    /// </summary>
    public partial class ListRunsInBatchRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property BatchId. 
        /// <para>
        /// The identifier portion of the run batch ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string BatchId { get; set; }

        /// <summary>
        /// Checks to see if the BatchId property is set.
        /// </summary>
        internal bool IsSetBatchId() => this.BatchId != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of runs to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// Filter runs by the HealthOmics-generated run ID.
        /// </para>
        /// </summary>
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunSettingId. 
        /// <para>
        /// Filter runs by the customer-provided run setting ID.
        /// </para>
        /// </summary>
        public string RunSettingId { get; set; }

        /// <summary>
        /// Checks to see if the RunSettingId property is set.
        /// </summary>
        internal bool IsSetRunSettingId() => this.RunSettingId != null;

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// A pagination token returned from a prior <c>ListRunsInBatch</c> call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string StartingToken { get; set; }

        /// <summary>
        /// Checks to see if the StartingToken property is set.
        /// </summary>
        internal bool IsSetStartingToken() => this.StartingToken != null;

        /// <summary>
        /// Gets and sets the property SubmissionStatus. 
        /// <para>
        /// Filter runs by submission status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public SubmissionStatus SubmissionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SubmissionStatus property is set.
        /// </summary>
        internal bool IsSetSubmissionStatus() => this.SubmissionStatus != null;
    }
}
