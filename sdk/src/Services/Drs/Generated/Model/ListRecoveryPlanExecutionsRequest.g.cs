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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecoveryPlanExecutions operation. Lists executions
    /// of Recovery Plans, optionally filtered by plan or status.
    /// </summary>
    public partial class ListRecoveryPlanExecutionsRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RecoveryPlanArn. 
        /// <para>
        /// Filter executions by Recovery Plan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RecoveryPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPlanArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPlanArn() => this.RecoveryPlanArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter executions by status.
        /// </para>
        /// </summary>
        public RecoveryPlanExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
