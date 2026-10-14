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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for increasing the capacity of Amazon EC2 Auto Scaling groups during
    /// a Region switch.
    /// </summary>
    public partial class Ec2AsgCapacityIncreaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property Asgs. 
        /// <para>
        /// The EC2 Auto Scaling groups for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<Asg> Asgs { get; set; } = AWSConfigs.InitializeCollections ? new List<Asg>() : null;

        /// <summary>
        /// Checks to see if the Asgs property is set.
        /// </summary>
        internal bool IsSetAsgs() => this.Asgs != null && (this.Asgs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityMonitoringApproach. 
        /// <para>
        /// The monitoring approach that you specify EC2 Auto Scaling groups for the configuration.
        /// </para>
        /// </summary>
        public Ec2AsgCapacityMonitoringApproach CapacityMonitoringApproach { get; set; }

        /// <summary>
        /// Checks to see if the CapacityMonitoringApproach property is set.
        /// </summary>
        internal bool IsSetCapacityMonitoringApproach() => this.CapacityMonitoringApproach != null;

        /// <summary>
        /// Gets and sets the property TargetPercent. 
        /// <para>
        /// The target percentage that you specify for EC2 Auto Scaling groups. The default is
        /// 100.
        /// </para>
        /// </summary>
        public int? TargetPercent { get; set; }

        /// <summary>
        /// Checks to see if the TargetPercent property is set.
        /// </summary>
        internal bool IsSetTargetPercent() => this.TargetPercent.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? TimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutMinutes() => this.TimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Ungraceful. 
        /// <para>
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public Ec2Ungraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;

        /// <summary>
        /// Gets and sets the property WaitELBTargetGroupHealthy. 
        /// <para>
        /// If enabled, the step completes only after each attached ELB target group reports a
        /// healthy target count that matches the group's new desired capacity calculated in the
        /// step.
        /// </para>
        /// </summary>
        public WaitELBTargetGroupHealthy WaitELBTargetGroupHealthy { get; set; }

        /// <summary>
        /// Checks to see if the WaitELBTargetGroupHealthy property is set.
        /// </summary>
        internal bool IsSetWaitELBTargetGroupHealthy() => this.WaitELBTargetGroupHealthy != null;
    }
}
