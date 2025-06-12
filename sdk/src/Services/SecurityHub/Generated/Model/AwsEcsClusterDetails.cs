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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon ECS cluster.
    /// </summary>
    public partial class AwsEcsClusterDetails
    {
        private int? _activeServicesCount;
        private List<string> _capacityProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clusterArn;
        private string _clusterName;
        private List<AwsEcsClusterClusterSettingsDetails> _clusterSettings = AWSConfigs.InitializeCollections ? new List<AwsEcsClusterClusterSettingsDetails>() : null;
        private AwsEcsClusterConfigurationDetails _configuration;
        private List<AwsEcsClusterDefaultCapacityProviderStrategyDetails> _defaultCapacityProviderStrategy = AWSConfigs.InitializeCollections ? new List<AwsEcsClusterDefaultCapacityProviderStrategyDetails>() : null;
        private int? _registeredContainerInstancesCount;
        private int? _runningTasksCount;
        private string _status;

        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an <c>ACTIVE</c> state.
        /// You can view these services with the Amazon ECS <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServices.html">
        /// <c>ListServices</c> </a> API operation. 
        /// </para>
        /// </summary>
        public int? ActiveServicesCount
        {
            get { return this._activeServicesCount; }
            set { this._activeServicesCount = value; }
        }

        // Check to see if ActiveServicesCount property is set
        internal bool IsSetActiveServicesCount()
        {
            return this._activeServicesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The short name of one or more capacity providers to associate with the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityProviders
        {
            get { return this._capacityProviders; }
            set { this._capacityProviders = value; }
        }

        // Check to see if CapacityProviders property is set
        internal bool IsSetCapacityProviders()
        {
            return this._capacityProviders != null && (this._capacityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. 
        /// </para>
        /// </summary>
        public string ClusterArn
        {
            get { return this._clusterArn; }
            set { this._clusterArn = value; }
        }

        // Check to see if ClusterArn property is set
        internal bool IsSetClusterArn()
        {
            return this._clusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A name that you use to identify your cluster. 
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterSettings. 
        /// <para>
        /// The setting to use to create the cluster. Specifically used to configure whether to
        /// enable CloudWatch Container Insights for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsClusterClusterSettingsDetails> ClusterSettings
        {
            get { return this._clusterSettings; }
            set { this._clusterSettings = value; }
        }

        // Check to see if ClusterSettings property is set
        internal bool IsSetClusterSettings()
        {
            return this._clusterSettings != null && (this._clusterSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The run command configuration for the cluster.
        /// </para>
        /// </summary>
        public AwsEcsClusterConfigurationDetails Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCapacityProviderStrategy. 
        /// <para>
        /// The default capacity provider strategy for the cluster. The default capacity provider
        /// strategy is used when services or tasks are run without a specified launch type or
        /// capacity provider strategy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsClusterDefaultCapacityProviderStrategyDetails> DefaultCapacityProviderStrategy
        {
            get { return this._defaultCapacityProviderStrategy; }
            set { this._defaultCapacityProviderStrategy = value; }
        }

        // Check to see if DefaultCapacityProviderStrategy property is set
        internal bool IsSetDefaultCapacityProviderStrategy()
        {
            return this._defaultCapacityProviderStrategy != null && (this._defaultCapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster. This includes container
        /// instances in both <c>ACTIVE</c> and <c>DRAINING</c> status. 
        /// </para>
        /// </summary>
        public int? RegisteredContainerInstancesCount
        {
            get { return this._registeredContainerInstancesCount; }
            set { this._registeredContainerInstancesCount = value; }
        }

        // Check to see if RegisteredContainerInstancesCount property is set
        internal bool IsSetRegisteredContainerInstancesCount()
        {
            return this._registeredContainerInstancesCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>RUNNING</c> state. 
        /// </para>
        /// </summary>
        public int? RunningTasksCount
        {
            get { return this._runningTasksCount; }
            set { this._runningTasksCount = value; }
        }

        // Check to see if RunningTasksCount property is set
        internal bool IsSetRunningTasksCount()
        {
            return this._runningTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}