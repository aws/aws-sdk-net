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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Amazon ECS cluster.
    /// </summary>
    public partial class AwsEcsClusterDetails
    {
        /// <summary>
        /// Gets and sets the property ActiveServicesCount. 
        /// <para>
        /// The number of services that are running on the cluster in an <c>ACTIVE</c> state.
        /// You can view these services with the Amazon ECS <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_ListServices.html">
        /// <c>ListServices</c> </a> API operation. 
        /// </para>
        /// </summary>
        public int? ActiveServicesCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveServicesCount property is set.
        /// </summary>
        internal bool IsSetActiveServicesCount() => this.ActiveServicesCount.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The short name of one or more capacity providers to associate with the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityProviders property is set.
        /// </summary>
        internal bool IsSetCapacityProviders() => this.CapacityProviders != null && (this.CapacityProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the cluster. 
        /// </para>
        /// </summary>
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A name that you use to identify your cluster. 
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ClusterSettings. 
        /// <para>
        /// The setting to use to create the cluster. Specifically used to configure whether to
        /// enable CloudWatch Container Insights for the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsClusterClusterSettingsDetails> ClusterSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsClusterClusterSettingsDetails>() : null;

        /// <summary>
        /// Checks to see if the ClusterSettings property is set.
        /// </summary>
        internal bool IsSetClusterSettings() => this.ClusterSettings != null && (this.ClusterSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The run command configuration for the cluster.
        /// </para>
        /// </summary>
        public AwsEcsClusterConfigurationDetails Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DefaultCapacityProviderStrategy. 
        /// <para>
        /// The default capacity provider strategy for the cluster. The default capacity provider
        /// strategy is used when services or tasks are run without a specified launch type or
        /// capacity provider strategy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsClusterDefaultCapacityProviderStrategyDetails> DefaultCapacityProviderStrategy { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEcsClusterDefaultCapacityProviderStrategyDetails>() : null;

        /// <summary>
        /// Checks to see if the DefaultCapacityProviderStrategy property is set.
        /// </summary>
        internal bool IsSetDefaultCapacityProviderStrategy() => this.DefaultCapacityProviderStrategy != null && (this.DefaultCapacityProviderStrategy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RegisteredContainerInstancesCount. 
        /// <para>
        /// The number of container instances registered into the cluster. This includes container
        /// instances in both <c>ACTIVE</c> and <c>DRAINING</c> status. 
        /// </para>
        /// </summary>
        public int? RegisteredContainerInstancesCount { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredContainerInstancesCount property is set.
        /// </summary>
        internal bool IsSetRegisteredContainerInstancesCount() => this.RegisteredContainerInstancesCount.HasValue;

        /// <summary>
        /// Gets and sets the property RunningTasksCount. 
        /// <para>
        /// The number of tasks in the cluster that are in the <c>RUNNING</c> state. 
        /// </para>
        /// </summary>
        public int? RunningTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the RunningTasksCount property is set.
        /// </summary>
        internal bool IsSetRunningTasksCount() => this.RunningTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the cluster. 
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
