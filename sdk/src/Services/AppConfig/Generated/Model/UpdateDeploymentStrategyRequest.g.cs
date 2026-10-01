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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeploymentStrategy operation. Updates a
    /// deployment strategy.
    /// </summary>
    public partial class UpdateDeploymentStrategyRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time for a deployment to last.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1440)]
        public int? DeploymentDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetDeploymentDurationInMinutes() => this.DeploymentDurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The deployment strategy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeploymentStrategyId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStrategyId property is set.
        /// </summary>
        internal bool IsSetDeploymentStrategyId() => this.DeploymentStrategyId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the deployment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FinalBakeTimeInMinutes. 
        /// <para>
        /// The amount of time that AppConfig monitors for alarms before considering the deployment
        /// to be complete and no longer eligible for automatic rollback.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1440)]
        public int? FinalBakeTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the FinalBakeTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetFinalBakeTimeInMinutes() => this.FinalBakeTimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property GrowthFactor. 
        /// <para>
        /// The percentage of targets to receive a deployed configuration during each interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public float? GrowthFactor { get; set; }

        /// <summary>
        /// Checks to see if the GrowthFactor property is set.
        /// </summary>
        internal bool IsSetGrowthFactor() => this.GrowthFactor.HasValue;

        /// <summary>
        /// Gets and sets the property GrowthType. 
        /// <para>
        /// The algorithm used to define how percentage grows over time. AppConfig supports the
        /// following growth types:
        /// </para>
        ///  
        /// <para>
        ///  <b>Linear</b>: For this type, AppConfig processes the deployment by increments of
        /// the growth factor evenly distributed over the deployment time. For example, a linear
        /// deployment that uses a growth factor of 20 initially makes the configuration available
        /// to 20 percent of the targets. After 1/5th of the deployment time has passed, the system
        /// updates the percentage to 40 percent. This continues until 100% of the targets are
        /// set to receive the deployed configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Exponential</b>: For this type, AppConfig processes the deployment exponentially
        /// using the following formula: <c>G*(2^N)</c>. In this formula, <c>G</c> is the growth
        /// factor specified by the user and <c>N</c> is the number of steps until the configuration
        /// is deployed to all targets. For example, if you specify a growth factor of 2, then
        /// the system rolls out the configuration as follows:
        /// </para>
        ///  
        /// <para>
        ///  <c>2*(2^0)</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2*(2^1)</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>2*(2^2)</c> 
        /// </para>
        ///  
        /// <para>
        /// Expressed numerically, the deployment rolls out as follows: 2% of the targets, 4%
        /// of the targets, 8% of the targets, and continues until the configuration has been
        /// deployed to all targets.
        /// </para>
        /// </summary>
        public GrowthType GrowthType { get; set; }

        /// <summary>
        /// Checks to see if the GrowthType property is set.
        /// </summary>
        internal bool IsSetGrowthType() => this.GrowthType != null;
    }
}
