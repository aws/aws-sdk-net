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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the GetFleet operation.
    /// </summary>
    public partial class GetFleetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoScalingStatus. The Auto Scaling status of the fleet.
        /// Either <c>GROWING</c>, <c>STEADY</c>, or <c>SHRINKING</c>.
        /// </summary>
        public AutoScalingStatus AutoScalingStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingStatus property is set.
        /// </summary>
        internal bool IsSetAutoScalingStatus() => this.AutoScalingStatus != null;

        /// <summary>
        /// Gets and sets the property Capabilities. Outlines what the fleet is capable of for
        /// minimums, maximums, and naming, in addition to attribute names and values.
        /// </summary>
        public FleetCapabilities Capabilities { get; set; }

        /// <summary>
        /// Checks to see if the Capabilities property is set.
        /// </summary>
        internal bool IsSetCapabilities() => this.Capabilities != null;

        /// <summary>
        /// Gets and sets the property Configuration. The configuration setting for the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public FleetConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the resource was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. The user or system that created this resource.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the farm in the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. The fleet ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property HostConfiguration. The script that runs as a worker is
        /// starting up that you can use to provide additional configuration for workers in your
        /// fleet.
        /// </summary>
        public HostConfiguration HostConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HostConfiguration property is set.
        /// </summary>
        internal bool IsSetHostConfiguration() => this.HostConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. The maximum number of workers specified
        /// in the fleet.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinWorkerCount. The minimum number of workers specified
        /// in the fleet.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public int? MinWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MinWorkerCount property is set.
        /// </summary>
        internal bool IsSetMinWorkerCount() => this.MinWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role ARN.
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. The status of the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public FleetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. A message that communicates a suspended
        /// status of the fleet.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetWorkerCount. The number of target workers in the
        /// fleet.
        /// </summary>
        public int? TargetWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetWorkerCount property is set.
        /// </summary>
        internal bool IsSetTargetWorkerCount() => this.TargetWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The date and time the resource was updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user or system that updated this resource.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property WorkerCount. The number of workers in the fleet.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? WorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the WorkerCount property is set.
        /// </summary>
        internal bool IsSetWorkerCount() => this.WorkerCount.HasValue;
    }
}
