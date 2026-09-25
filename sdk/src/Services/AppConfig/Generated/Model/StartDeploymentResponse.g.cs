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
    /// This is the response object from the StartDeployment operation.
    /// </summary>
    public partial class StartDeploymentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that was deployed.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AppliedExtensions. 
        /// <para>
        /// A list of extensions that were processed as part of the deployment. The extensions
        /// that were previously associated to the configuration profile, environment, or the
        /// application when <c>StartDeployment</c> was called.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AppliedExtension> AppliedExtensions { get; set; } = AWSConfigs.InitializeCollections ? new List<AppliedExtension>() : null;

        /// <summary>
        /// Checks to see if the AppliedExtensions property is set.
        /// </summary>
        internal bool IsSetAppliedExtensions() => this.AppliedExtensions != null && (this.AppliedExtensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time the deployment completed. 
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigurationLocationUri. 
        /// <para>
        /// Information about the source location of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ConfigurationLocationUri { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationLocationUri property is set.
        /// </summary>
        internal bool IsSetConfigurationLocationUri() => this.ConfigurationLocationUri != null;

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
        /// The configuration version that was deployed.
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
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The ID of the deployment strategy that was deployed.
        /// </para>
        /// </summary>
        public string DeploymentStrategyId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStrategyId property is set.
        /// </summary>
        internal bool IsSetDeploymentStrategyId() => this.DeploymentStrategyId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that was deployed.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EventLog. 
        /// <para>
        /// A list containing all events related to a deployment. The most recent events are displayed
        /// first.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentEvent> EventLog { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentEvent>() : null;

        /// <summary>
        /// Checks to see if the EventLog property is set.
        /// </summary>
        internal bool IsSetEventLog() => this.EventLog != null && (this.EventLog.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FinalBakeTimeInMinutes. 
        /// <para>
        /// The amount of time that AppConfig monitored for alarms before considering the deployment
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
        /// The algorithm used to define how percentage grew over time.
        /// </para>
        /// </summary>
        public GrowthType GrowthType { get; set; }

        /// <summary>
        /// Checks to see if the GrowthType property is set.
        /// </summary>
        internal bool IsSetGrowthType() => this.GrowthType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name of the Key Management Service key used to encrypt configuration
        /// data. You can encrypt secrets stored in Secrets Manager, Amazon Simple Storage Service
        /// (Amazon S3) objects encrypted with SSE-KMS, or secure string parameters stored in
        /// Amazon Web Services Systems Manager Parameter Store. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Key Management Service key identifier (key ID, key alias, or key ARN) provided
        /// when the resource was created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

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
        /// The time the deployment started.
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
