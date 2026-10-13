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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Provides a summary of the properties of a solution update. For a complete listing,
    /// call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeSolution.html">DescribeSolution</a>
    /// API.
    /// </summary>
    public partial class SolutionUpdateSummary
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the solution update was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a solution update fails, the reason behind the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix time) that the solution update was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property PerformAutoTraining. 
        /// <para>
        /// Whether the solution automatically creates solution versions.
        /// </para>
        /// </summary>
        public bool? PerformAutoTraining { get; set; }

        /// <summary>
        /// Checks to see if the PerformAutoTraining property is set.
        /// </summary>
        internal bool IsSetPerformAutoTraining() => this.PerformAutoTraining.HasValue;

        /// <summary>
        /// Gets and sets the property PerformIncrementalUpdate. 
        /// <para>
        /// A Boolean value that indicates whether incremental training updates are performed
        /// on the model. When enabled, this allows the model to learn from new data more frequently
        /// without requiring full retraining, which enables near real-time personalization. This
        /// parameter is supported only for solutions that use the semantic-similarity recipe.
        /// </para>
        /// </summary>
        public bool? PerformIncrementalUpdate { get; set; }

        /// <summary>
        /// Checks to see if the PerformIncrementalUpdate property is set.
        /// </summary>
        internal bool IsSetPerformIncrementalUpdate() => this.PerformIncrementalUpdate.HasValue;

        /// <summary>
        /// Gets and sets the property SolutionUpdateConfig. 
        /// <para>
        /// The configuration details of the solution.
        /// </para>
        /// </summary>
        public SolutionUpdateConfig SolutionUpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the SolutionUpdateConfig property is set.
        /// </summary>
        internal bool IsSetSolutionUpdateConfig() => this.SolutionUpdateConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the solution update. A solution update can be in one of the following
        /// states:
        /// </para>
        ///  
        /// <para>
        /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
