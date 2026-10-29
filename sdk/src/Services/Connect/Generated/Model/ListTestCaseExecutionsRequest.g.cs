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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the ListTestCaseExecutions operation. Lists all test
    /// case executions and allows filtering by test case id, test case name, start time,
    /// end time or status of the execution for the specified Amazon Connect instance.
    /// </summary>
    public partial class ListTestCaseExecutionsRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Filter executions that started before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Filter executions that started after this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter executions by status.
        /// </para>
        /// </summary>
        public TestCaseExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestCaseId. 
        /// <para>
        /// Filter executions by test case identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TestCaseId { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseId property is set.
        /// </summary>
        internal bool IsSetTestCaseId() => this.TestCaseId != null;

        /// <summary>
        /// Gets and sets the property TestCaseName. 
        /// <para>
        /// Filter executions by test case name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseName property is set.
        /// </summary>
        internal bool IsSetTestCaseName() => this.TestCaseName != null;
    }
}
