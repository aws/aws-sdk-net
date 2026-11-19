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
    /// Describes the status of an instance, including system status, instance status, attached
    /// EBS status, application status, and performance status.
    /// </summary>
    public partial class InstanceStatus
    {
        /// <summary>
        /// Gets and sets the property ApplicationStatus. 
        /// <para>
        /// Reports the application-level health status for the instance.
        /// </para>
        /// </summary>
        public ApplicationStatusSummary ApplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatus property is set.
        /// </summary>
        internal bool IsSetApplicationStatus() => this.ApplicationStatus != null;

        /// <summary>
        /// Gets and sets the property AttachedEbsStatus. 
        /// <para>
        /// Reports impaired functionality that stems from an attached Amazon EBS volume that
        /// is unreachable and unable to complete I/O operations.
        /// </para>
        /// </summary>
        public EbsStatusSummary AttachedEbsStatus { get; set; }

        /// <summary>
        /// Checks to see if the AttachedEbsStatus property is set.
        /// </summary>
        internal bool IsSetAttachedEbsStatus() => this.AttachedEbsStatus != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the instance.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the instance.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Any scheduled events associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceStatusEvent> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceStatusEvent>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceState. 
        /// <para>
        /// The intended state of the instance. <a>DescribeInstanceStatus</a> requires that an
        /// instance be in the <c>running</c> state.
        /// </para>
        /// </summary>
        public InstanceState InstanceState { get; set; }

        /// <summary>
        /// Checks to see if the InstanceState property is set.
        /// </summary>
        internal bool IsSetInstanceState() => this.InstanceState != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the instance.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property PerformanceStatus. 
        /// <para>
        /// Reports the performance-related health status for the instance. This information is
        /// returned only when performance status checks are enabled for the instance.
        /// </para>
        /// </summary>
        public PerformanceStatusSummary PerformanceStatus { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceStatus property is set.
        /// </summary>
        internal bool IsSetPerformanceStatus() => this.PerformanceStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Reports impaired functionality that stems from issues internal to the instance, such
        /// as impaired reachability.
        /// </para>
        /// </summary>
        public InstanceStatusSummary Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemStatus. 
        /// <para>
        /// Reports impaired functionality that stems from issues related to the systems that
        /// support an instance, such as hardware failures and network connectivity problems.
        /// </para>
        /// </summary>
        public InstanceStatusSummary SystemStatus { get; set; }

        /// <summary>
        /// Checks to see if the SystemStatus property is set.
        /// </summary>
        internal bool IsSetSystemStatus() => this.SystemStatus != null;
    }
}
