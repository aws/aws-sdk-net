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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Detailed information about an assessment.
    /// </summary>
    public partial class DataCollectionDetails
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        ///  The time the assessment completes. 
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        ///  The number of failed servers in the assessment. 
        /// </para>
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property InProgress. 
        /// <para>
        ///  The number of servers with the assessment status <c>IN_PROGESS</c>. 
        /// </para>
        /// </summary>
        public int? InProgress { get; set; }

        /// <summary>
        /// Checks to see if the InProgress property is set.
        /// </summary>
        internal bool IsSetInProgress() => this.InProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        ///  The total number of servers in the assessment. 
        /// </para>
        /// </summary>
        public int? Servers { get; set; }

        /// <summary>
        /// Checks to see if the Servers property is set.
        /// </summary>
        internal bool IsSetServers() => this.Servers.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of assessment. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the assessment. 
        /// </para>
        /// </summary>
        public AssessmentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        ///  The number of successful servers in the assessment. 
        /// </para>
        /// </summary>
        public int? Success { get; set; }

        /// <summary>
        /// Checks to see if the Success property is set.
        /// </summary>
        internal bool IsSetSuccess() => this.Success.HasValue;
    }
}
