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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Details about a reserved capacity offering for a training plan offering.
    /// 
    ///  
    /// <para>
    /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
    /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
    /// </c>.
    /// </para>
    /// </summary>
    public partial class ReservedCapacityOffering
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone for the reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DurationHours. 
        /// <para>
        /// The number of whole hours in the total duration for this reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 87600)]
        public long? DurationHours { get; set; }

        /// <summary>
        /// Checks to see if the DurationHours property is set.
        /// </summary>
        internal bool IsSetDurationHours() => this.DurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property DurationMinutes. 
        /// <para>
        /// The additional minutes beyond whole hours in the total duration for this reserved
        /// capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 59)]
        public long? DurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationMinutes property is set.
        /// </summary>
        internal bool IsSetDurationMinutes() => this.DurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExtensionEndTime. 
        /// <para>
        /// The end time of the extension for the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? ExtensionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionEndTime property is set.
        /// </summary>
        internal bool IsSetExtensionEndTime() => this.ExtensionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExtensionStartTime. 
        /// <para>
        /// The start time of the extension for the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? ExtensionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ExtensionStartTime property is set.
        /// </summary>
        internal bool IsSetExtensionStartTime() => this.ExtensionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservedCapacityInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ReservedCapacityType. 
        /// <para>
        /// The type of reserved capacity offering.
        /// </para>
        /// </summary>
        public ReservedCapacityType ReservedCapacityType { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityType property is set.
        /// </summary>
        internal bool IsSetReservedCapacityType() => this.ReservedCapacityType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the reserved capacity offering.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers included in this reserved capacity offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? UltraServerCount { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerCount property is set.
        /// </summary>
        internal bool IsSetUltraServerCount() => this.UltraServerCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer included in this reserved capacity offering, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UltraServerType { get; set; }

        /// <summary>
        /// Checks to see if the UltraServerType property is set.
        /// </summary>
        internal bool IsSetUltraServerType() => this.UltraServerType != null;
    }
}
