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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonEMRServerlessRequest
    {
        private Architecture _architecture;
        private AutoStartConfig _autoStartConfiguration;
        private AutoStopConfig _autoStopConfiguration;
        private string _clientToken;
        private IdentityCenterConfigurationInput _identityCenterConfiguration;
        private ImageConfigurationInput _imageConfiguration;
        private Dictionary<string, InitialCapacityConfig> _initialCapacity = AWSConfigs.InitializeCollections ? new Dictionary<string, InitialCapacityConfig>() : null;
        private InteractiveConfiguration _interactiveConfiguration;
        private MaximumAllowedResources _maximumCapacity;
        private MonitoringConfiguration _monitoringConfiguration;
        private string _name;
        private NetworkConfiguration _networkConfiguration;
        private string _releaseLabel;
        private List<Configuration> _runtimeConfiguration = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;
        private SchedulerConfiguration _schedulerConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _type;
        private Dictionary<string, WorkerTypeSpecificationInput> _workerTypeSpecifications = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkerTypeSpecificationInput>() : null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture of an application.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStartConfiguration. 
        /// <para>
        /// The configuration for an application to automatically start on job submission.
        /// </para>
        /// </summary>
        public AutoStartConfig AutoStartConfiguration
        {
            get { return this._autoStartConfiguration; }
            set { this._autoStartConfiguration = value; }
        }

        // Check to see if AutoStartConfiguration property is set
        internal bool IsSetAutoStartConfiguration()
        {
            return this._autoStartConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoStopConfiguration. 
        /// <para>
        /// The configuration for an application to automatically stop after a certain amount
        /// of time being idle.
        /// </para>
        /// </summary>
        public AutoStopConfig AutoStopConfiguration
        {
            get { return this._autoStopConfiguration; }
            set { this._autoStopConfiguration = value; }
        }

        // Check to see if AutoStopConfiguration property is set
        internal bool IsSetAutoStopConfiguration()
        {
            return this._autoStopConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the application to create. Its value must be unique
        /// for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// The IAM Identity Center Configuration accepts the Identity Center instance parameter
        /// required to enable trusted identity propagation. This configuration allows identity
        /// propagation between integrated services and the Identity Center instance.
        /// </para>
        /// </summary>
        public IdentityCenterConfigurationInput IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The image configuration for all worker types. You can either set this parameter or
        /// <c>imageConfiguration</c> for each worker type in <c>workerTypeSpecifications</c>.
        /// </para>
        /// </summary>
        public ImageConfigurationInput ImageConfiguration
        {
            get { return this._imageConfiguration; }
            set { this._imageConfiguration = value; }
        }

        // Check to see if ImageConfiguration property is set
        internal bool IsSetImageConfiguration()
        {
            return this._imageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InitialCapacity. 
        /// <para>
        /// The capacity to initialize when the application is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, InitialCapacityConfig> InitialCapacity
        {
            get { return this._initialCapacity; }
            set { this._initialCapacity = value; }
        }

        // Check to see if InitialCapacity property is set
        internal bool IsSetInitialCapacity()
        {
            return this._initialCapacity != null && (this._initialCapacity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InteractiveConfiguration. 
        /// <para>
        /// The interactive configuration object that enables the interactive use cases to use
        /// when running an application.
        /// </para>
        /// </summary>
        public InteractiveConfiguration InteractiveConfiguration
        {
            get { return this._interactiveConfiguration; }
            set { this._interactiveConfiguration = value; }
        }

        // Check to see if InteractiveConfiguration property is set
        internal bool IsSetInteractiveConfiguration()
        {
            return this._interactiveConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumCapacity. 
        /// <para>
        /// The maximum capacity to allocate when the application is created. This is cumulative
        /// across all workers at any given point in time, not just when an application is created.
        /// No new resources will be created once any one of the defined limits is hit.
        /// </para>
        /// </summary>
        public MaximumAllowedResources MaximumCapacity
        {
            get { return this._maximumCapacity; }
            set { this._maximumCapacity = value; }
        }

        // Check to see if MaximumCapacity property is set
        internal bool IsSetMaximumCapacity()
        {
            return this._maximumCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// The configuration setting for monitoring.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration
        {
            get { return this._monitoringConfiguration; }
            set { this._monitoringConfiguration = value; }
        }

        // Check to see if MonitoringConfiguration property is set
        internal bool IsSetMonitoringConfiguration()
        {
            return this._monitoringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for customer VPC connectivity.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release associated with the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/emr-serverless/latest/APIReference/API_Configuration.html">Configuration</a>
        /// specifications to use when creating an application. Each configuration consists of
        /// a classification and properties. This configuration is applied to all the job runs
        /// submitted under the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<Configuration> RuntimeConfiguration
        {
            get { return this._runtimeConfiguration; }
            set { this._runtimeConfiguration = value; }
        }

        // Check to see if RuntimeConfiguration property is set
        internal bool IsSetRuntimeConfiguration()
        {
            return this._runtimeConfiguration != null && (this._runtimeConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchedulerConfiguration. 
        /// <para>
        /// The scheduler configuration for batch and streaming jobs running on this application.
        /// Supported with release labels emr-7.0.0 and above.
        /// </para>
        /// </summary>
        public SchedulerConfiguration SchedulerConfiguration
        {
            get { return this._schedulerConfiguration; }
            set { this._schedulerConfiguration = value; }
        }

        // Check to see if SchedulerConfiguration property is set
        internal bool IsSetSchedulerConfiguration()
        {
            return this._schedulerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of application you want to start, such as Spark or Hive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerTypeSpecifications. 
        /// <para>
        /// The key-value pairs that specify worker type to <c>WorkerTypeSpecificationInput</c>.
        /// This parameter must contain all valid worker types for a Spark or Hive application.
        /// Valid worker types include <c>Driver</c> and <c>Executor</c> for Spark applications
        /// and <c>HiveDriver</c> and <c>TezTask</c> for Hive applications. You can either set
        /// image details in this parameter for each worker type, or in <c>imageConfiguration</c>
        /// for all worker types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, WorkerTypeSpecificationInput> WorkerTypeSpecifications
        {
            get { return this._workerTypeSpecifications; }
            set { this._workerTypeSpecifications = value; }
        }

        // Check to see if WorkerTypeSpecifications property is set
        internal bool IsSetWorkerTypeSpecifications()
        {
            return this._workerTypeSpecifications != null && (this._workerTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}