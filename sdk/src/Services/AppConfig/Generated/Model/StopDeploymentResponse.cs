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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// This is the response object from the StopDeployment operation.
    /// </summary>
    public partial class StopDeploymentResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private List<AppliedExtension> _appliedExtensions = new List<AppliedExtension>();
        private DateTime? _completedAt;
        private string _configurationLocationUri;
        private string _configurationName;
        private string _configurationProfileId;
        private string _configurationVersion;
        private int? _deploymentDurationInMinutes;
        private int? _deploymentNumber;
        private string _deploymentStrategyId;
        private string _description;
        private string _environmentId;
        private List<DeploymentEvent> _eventLog = new List<DeploymentEvent>();
        private int? _finalBakeTimeInMinutes;
        private float? _growthFactor;
        private GrowthType _growthType;
        private string _kmsKeyArn;
        private string _kmsKeyIdentifier;
        private float? _percentageComplete;
        private DateTime? _startedAt;
        private DeploymentState _state;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application that was deployed.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AppliedExtensions. 
        /// <para>
        /// A list of extensions that were processed as part of the deployment. The extensions
        /// that were previously associated to the configuration profile, environment, or the
        /// application when <code>StartDeployment</code> was called.
        /// </para>
        /// </summary>
        public List<AppliedExtension> AppliedExtensions
        {
            get { return this._appliedExtensions; }
            set { this._appliedExtensions = value; }
        }

        // Check to see if AppliedExtensions property is set
        internal bool IsSetAppliedExtensions()
        {
            return this._appliedExtensions != null && this._appliedExtensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time the deployment completed. 
        /// </para>
        /// </summary>
        public DateTime CompletedAt
        {
            get { return this._completedAt.GetValueOrDefault(); }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationLocationUri. 
        /// <para>
        /// Information about the source location of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ConfigurationLocationUri
        {
            get { return this._configurationLocationUri; }
            set { this._configurationLocationUri = value; }
        }

        // Check to see if ConfigurationLocationUri property is set
        internal bool IsSetConfigurationLocationUri()
        {
            return this._configurationLocationUri != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The ID of the configuration profile that was deployed.
        /// </para>
        /// </summary>
        public string ConfigurationProfileId
        {
            get { return this._configurationProfileId; }
            set { this._configurationProfileId = value; }
        }

        // Check to see if ConfigurationProfileId property is set
        internal bool IsSetConfigurationProfileId()
        {
            return this._configurationProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationVersion. 
        /// <para>
        /// The configuration version that was deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ConfigurationVersion
        {
            get { return this._configurationVersion; }
            set { this._configurationVersion = value; }
        }

        // Check to see if ConfigurationVersion property is set
        internal bool IsSetConfigurationVersion()
        {
            return this._configurationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time the deployment lasted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
        public int DeploymentDurationInMinutes
        {
            get { return this._deploymentDurationInMinutes.GetValueOrDefault(); }
            set { this._deploymentDurationInMinutes = value; }
        }

        // Check to see if DeploymentDurationInMinutes property is set
        internal bool IsSetDeploymentDurationInMinutes()
        {
            return this._deploymentDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentNumber. 
        /// <para>
        /// The sequence number of the deployment.
        /// </para>
        /// </summary>
        public int DeploymentNumber
        {
            get { return this._deploymentNumber.GetValueOrDefault(); }
            set { this._deploymentNumber = value; }
        }

        // Check to see if DeploymentNumber property is set
        internal bool IsSetDeploymentNumber()
        {
            return this._deploymentNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The ID of the deployment strategy that was deployed.
        /// </para>
        /// </summary>
        public string DeploymentStrategyId
        {
            get { return this._deploymentStrategyId; }
            set { this._deploymentStrategyId = value; }
        }

        // Check to see if DeploymentStrategyId property is set
        internal bool IsSetDeploymentStrategyId()
        {
            return this._deploymentStrategyId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment that was deployed.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property EventLog. 
        /// <para>
        /// A list containing all events related to a deployment. The most recent events are displayed
        /// first.
        /// </para>
        /// </summary>
        public List<DeploymentEvent> EventLog
        {
            get { return this._eventLog; }
            set { this._eventLog = value; }
        }

        // Check to see if EventLog property is set
        internal bool IsSetEventLog()
        {
            return this._eventLog != null && this._eventLog.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FinalBakeTimeInMinutes. 
        /// <para>
        /// The amount of time that AppConfig monitored for alarms before considering the deployment
        /// to be complete and no longer eligible for automatic rollback.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
        public int FinalBakeTimeInMinutes
        {
            get { return this._finalBakeTimeInMinutes.GetValueOrDefault(); }
            set { this._finalBakeTimeInMinutes = value; }
        }

        // Check to see if FinalBakeTimeInMinutes property is set
        internal bool IsSetFinalBakeTimeInMinutes()
        {
            return this._finalBakeTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrowthFactor. 
        /// <para>
        /// The percentage of targets to receive a deployed configuration during each interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public float GrowthFactor
        {
            get { return this._growthFactor.GetValueOrDefault(); }
            set { this._growthFactor = value; }
        }

        // Check to see if GrowthFactor property is set
        internal bool IsSetGrowthFactor()
        {
            return this._growthFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrowthType. 
        /// <para>
        /// The algorithm used to define how percentage grew over time.
        /// </para>
        /// </summary>
        public GrowthType GrowthType
        {
            get { return this._growthType; }
            set { this._growthType = value; }
        }

        // Check to see if GrowthType property is set
        internal bool IsSetGrowthType()
        {
            return this._growthType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name of the Key Management Service key used to encrypt configuration
        /// data. You can encrypt secrets stored in Secrets Manager, Amazon Simple Storage Service
        /// (Amazon S3) objects encrypted with SSE-KMS, or secure string parameters stored in
        /// Amazon Web Services Systems Manager Parameter Store. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The KMS key identifier (key ID, key alias, or key ARN). AppConfig uses this ID to
        /// encrypt the configuration data using a customer managed key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PercentageComplete. 
        /// <para>
        /// The percentage of targets for which the deployment is available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public float PercentageComplete
        {
            get { return this._percentageComplete.GetValueOrDefault(); }
            set { this._percentageComplete = value; }
        }

        // Check to see if PercentageComplete property is set
        internal bool IsSetPercentageComplete()
        {
            return this._percentageComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time the deployment started.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the deployment.
        /// </para>
        /// </summary>
        public DeploymentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}