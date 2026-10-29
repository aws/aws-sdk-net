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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditMitigationActionsTasks operation. Gets
    /// a list of audit mitigation action tasks that match the specified filters. <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditMitigationActionsTasks</a>
    /// action. </para>
    /// </summary>
    public partial class ListAuditMitigationActionsTasksRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AuditTaskId. 
        /// <para>
        /// Specify this filter to limit results to tasks that were applied to results for a specific
        /// audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string AuditTaskId { get; set; }

        /// <summary>
        /// Checks to see if the AuditTaskId property is set.
        /// </summary>
        internal bool IsSetAuditTaskId() => this.AuditTaskId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Specify this filter to limit results to tasks that were completed or canceled on or
        /// before a specific date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// Specify this filter to limit results to tasks that were applied to a specific audit
        /// finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
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
        /// Specify this filter to limit results to tasks that began on or after a specific date
        /// and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Specify this filter to limit results to tasks that are in a specific state.
        /// </para>
        /// </summary>
        public AuditMitigationActionsTaskStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
