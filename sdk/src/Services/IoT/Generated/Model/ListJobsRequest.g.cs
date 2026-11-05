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
    /// Container for the parameters to the ListJobs operation. Lists jobs. <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListJobs</a>
    /// action. </para>
    /// </summary>
    public partial class ListJobsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The namespace used to indicate that a job is a customer-managed job.
        /// </para>
        ///  
        /// <para>
        /// When you specify a value for this parameter, Amazon Web Services IoT Core sends jobs
        /// notifications to MQTT topics that contain the value in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>namespaceId</c> feature is only supported by IoT Greengrass at this time. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/setting-up.html">Setting
        /// up IoT Greengrass core devices.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceId property is set.
        /// </summary>
        internal bool IsSetNamespaceId() => this.NamespaceId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional filter that lets you search for jobs that have the specified status.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a thing when the thing is added to a target group, even after the
        /// job was completed by all things originally in the group. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you use continuous jobs instead of snapshot jobs for dynamic thing
        /// group targets. By using continuous jobs, devices that join the group receive the job
        /// execution even after the job has been created.
        /// </para>
        ///  </note>
        /// </summary>
        public TargetSelection TargetSelection { get; set; }

        /// <summary>
        /// Checks to see if the TargetSelection property is set.
        /// </summary>
        internal bool IsSetTargetSelection() => this.TargetSelection != null;

        /// <summary>
        /// Gets and sets the property ThingGroupId. 
        /// <para>
        /// A filter that limits the returned jobs to those for the specified group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupId property is set.
        /// </summary>
        internal bool IsSetThingGroupId() => this.ThingGroupId != null;

        /// <summary>
        /// Gets and sets the property ThingGroupName. 
        /// <para>
        /// A filter that limits the returned jobs to those for the specified group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ThingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ThingGroupName property is set.
        /// </summary>
        internal bool IsSetThingGroupName() => this.ThingGroupName != null;
    }
}
