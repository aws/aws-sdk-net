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
    /// Information about the deployment.
    /// </summary>
    public partial class DeploymentSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Time the deployment completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationName property is set.
        /// </summary>
        internal bool IsSetConfigurationName() => this.ConfigurationName != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The ID of the configuration profile that was deployed.
        /// </para>
        /// </summary>
        public string ConfigurationProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationProfileId property is set.
        /// </summary>
        internal bool IsSetConfigurationProfileId() => this.ConfigurationProfileId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationVersion. 
        /// <para>
        /// The version of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ConfigurationVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationVersion property is set.
        /// </summary>
        internal bool IsSetConfigurationVersion() => this.ConfigurationVersion != null;

        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time the deployment lasted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1440)]
        public int? DeploymentDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetDeploymentDurationInMinutes() => this.DeploymentDurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentNumber. 
        /// <para>
        /// The sequence number of the deployment.
        /// </para>
        /// </summary>
        public int? DeploymentNumber { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentNumber property is set.
        /// </summary>
        internal bool IsSetDeploymentNumber() => this.DeploymentNumber.HasValue;

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
        /// The algorithm used to define how percentage grows over time.
        /// </para>
        /// </summary>
        public GrowthType GrowthType { get; set; }

        /// <summary>
        /// Checks to see if the GrowthType property is set.
        /// </summary>
        internal bool IsSetGrowthType() => this.GrowthType != null;

        /// <summary>
        /// Gets and sets the property PercentageComplete. 
        /// <para>
        /// The percentage of targets for which the deployment is available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public float? PercentageComplete { get; set; }

        /// <summary>
        /// Checks to see if the PercentageComplete property is set.
        /// </summary>
        internal bool IsSetPercentageComplete() => this.PercentageComplete.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// Time the deployment started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the deployment.
        /// </para>
        /// </summary>
        public DeploymentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of deployment.
        /// </para>
        /// </summary>
        public DeploymentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A user-defined label for an AppConfig hosted configuration version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
