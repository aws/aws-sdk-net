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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RunScheduledInstances operation. Launches the
    /// specified Scheduled Instances. <para> Before you can launch a Scheduled Instance,
    /// you must purchase it and obtain an identifier using <a>PurchaseScheduledInstances</a>.
    /// </para> <para> You must launch a Scheduled Instance during its scheduled time period.
    /// You can't stop or reboot a Scheduled Instance, but you can terminate it as needed.
    /// If you terminate a Scheduled Instance before the current scheduled time period ends,
    /// you can launch it again after a few minutes. </para>
    /// </summary>
    public partial class RunScheduledInstancesRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that ensures the idempotency of the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchSpecification. 
        /// <para>
        /// The launch specification. You must match the instance type, Availability Zone, network,
        /// and platform of the schedule that you purchased.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ScheduledInstancesLaunchSpecification LaunchSpecification { get; set; }

        /// <summary>
        /// Checks to see if the LaunchSpecification property is set.
        /// </summary>
        internal bool IsSetLaunchSpecification() => this.LaunchSpecification != null;

        /// <summary>
        /// Gets and sets the property ScheduledInstanceId. 
        /// <para>
        /// The Scheduled Instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScheduledInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledInstanceId property is set.
        /// </summary>
        internal bool IsSetScheduledInstanceId() => this.ScheduledInstanceId != null;
    }
}
