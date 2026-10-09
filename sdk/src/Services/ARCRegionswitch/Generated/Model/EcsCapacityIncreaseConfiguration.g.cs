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
    /// The configuration for an Amazon Web Services ECS capacity increase.
    /// </summary>
    public partial class EcsCapacityIncreaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property CapacityMonitoringApproach. 
        /// <para>
        /// The monitoring approach specified for the configuration, for example, <c>Most_Recent</c>.
        /// </para>
        /// </summary>
        public EcsCapacityMonitoringApproach CapacityMonitoringApproach { get; set; }

        /// <summary>
        /// Checks to see if the CapacityMonitoringApproach property is set.
        /// </summary>
        internal bool IsSetCapacityMonitoringApproach() => this.CapacityMonitoringApproach != null;

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The services specified for the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 2)]
        public List<Service> Services { get; set; } = AWSConfigs.InitializeCollections ? new List<Service>() : null;

        /// <summary>
        /// Checks to see if the Services property is set.
        /// </summary>
        internal bool IsSetServices() => this.Services != null && (this.Services.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetPercent. 
        /// <para>
        /// The target percentage specified for the configuration. The default is 100.
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
        public EcsUngraceful Ungraceful { get; set; }

        /// <summary>
        /// Checks to see if the Ungraceful property is set.
        /// </summary>
        internal bool IsSetUngraceful() => this.Ungraceful != null;

        /// <summary>
        /// Gets and sets the property WaitELBTargetGroupHealthy. 
        /// <para>
        /// If enabled, the step completes only after each attached ELB target group reports a
        /// healthy target count that matches the service's new desired task count calculated
        /// in the step.
        /// </para>
        /// </summary>
        public WaitELBTargetGroupHealthy WaitELBTargetGroupHealthy { get; set; }

        /// <summary>
        /// Checks to see if the WaitELBTargetGroupHealthy property is set.
        /// </summary>
        internal bool IsSetWaitELBTargetGroupHealthy() => this.WaitELBTargetGroupHealthy != null;
    }
}
