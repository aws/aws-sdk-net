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
    /// Container for the parameters to the ListAuditFindings operation. Lists the findings
    /// (results) of a Device Defender audit or of the audits performed during a specified
    /// time period. (Findings are retained for 90 days.) <para> Requires permission to access
    /// the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditFindings</a>
    /// action. </para>
    /// </summary>
    public partial class ListAuditFindingsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CheckName. 
        /// <para>
        /// A filter to limit results to the findings for the specified audit check.
        /// </para>
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// Checks to see if the CheckName property is set.
        /// </summary>
        internal bool IsSetCheckName() => this.CheckName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A filter to limit results to those found before the specified time. You must specify
        /// either the startTime and endTime or the taskId, but not both.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ListSuppressedFindings. 
        /// <para>
        ///  Boolean flag indicating whether only the suppressed findings or the unsuppressed
        /// findings should be listed. If this parameter isn't provided, the response will list
        /// both suppressed and unsuppressed findings. 
        /// </para>
        /// </summary>
        public bool? ListSuppressedFindings { get; set; }

        /// <summary>
        /// Checks to see if the ListSuppressedFindings property is set.
        /// </summary>
        internal bool IsSetListSuppressedFindings() => this.ListSuppressedFindings.HasValue;

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
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Information identifying the noncompliant resource.
        /// </para>
        /// </summary>
        public ResourceIdentifier ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A filter to limit results to those found after the specified time. You must specify
        /// either the startTime and endTime or the taskId, but not both.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// A filter to limit results to the audit with the specified ID. You must specify either
        /// the taskId or the startTime and endTime, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
