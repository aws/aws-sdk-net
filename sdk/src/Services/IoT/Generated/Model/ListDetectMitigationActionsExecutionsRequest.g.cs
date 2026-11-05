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
    /// Container for the parameters to the ListDetectMitigationActionsExecutions operation.
    /// <note> <para> The IoT Device Defender detect feature will no longer be available to
    /// new customers starting August 31, 2026. If you would like to use the detect feature,
    /// sign up prior to August 31, 2026. To learn about alternatives to IoT Device Defender
    /// detect, see IoT Device Defender detect feature availability change in the IoT Device
    /// Defender Developer Guide. There is no change to IoT Device Defender audit availability.
    /// </para> </note> <para> Lists mitigation actions executions for a Device Defender ML
    /// Detect Security Profile. </para> <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListDetectMitigationActionsExecutions</a>
    /// action. </para>
    /// </summary>
    public partial class ListDetectMitigationActionsExecutionsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end of the time period for which ML Detect mitigation actions executions are
        /// returned. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return at one time. The default is 25. 
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
        ///  The token for the next set of results. 
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
        ///  A filter to limit results to those found after the specified time. You must specify
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
        ///  The unique identifier of the task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        ///  The name of the thing whose mitigation actions are listed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingName { get; set; }

        /// <summary>
        /// Checks to see if the ThingName property is set.
        /// </summary>
        internal bool IsSetThingName() => this.ThingName != null;

        /// <summary>
        /// Gets and sets the property ViolationId. 
        /// <para>
        ///  The unique identifier of the violation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ViolationId { get; set; }

        /// <summary>
        /// Checks to see if the ViolationId property is set.
        /// </summary>
        internal bool IsSetViolationId() => this.ViolationId != null;
    }
}
