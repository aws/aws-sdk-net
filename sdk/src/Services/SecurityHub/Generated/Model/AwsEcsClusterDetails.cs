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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// provides details about an ECS cluster.
    /// </summary>
    public partial class AwsEcsClusterDetails
    {
        private List<string> _capacityProviders = new List<string>();
        private List<AwsEcsClusterClusterSettingsDetails> _clusterSettings = new List<AwsEcsClusterClusterSettingsDetails>();
        private AwsEcsClusterConfigurationDetails _configuration;
        private List<AwsEcsClusterDefaultCapacityProviderStrategyDetails> _defaultCapacityProviderStrategy = new List<AwsEcsClusterDefaultCapacityProviderStrategyDetails>();

        /// <summary>
        /// Gets and sets the property CapacityProviders. 
        /// <para>
        /// The short name of one or more capacity providers to associate with the cluster.
        /// </para>
        /// </summary>
        public List<string> CapacityProviders
        {
            get { return this._capacityProviders; }
            set { this._capacityProviders = value; }
        }

        // Check to see if CapacityProviders property is set
        internal bool IsSetCapacityProviders()
        {
            return this._capacityProviders != null && this._capacityProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterSettings. 
        /// <para>
        /// The setting to use to create the cluster. Specifically used to configure whether to
        /// enable CloudWatch Container Insights for the cluster.
        /// </para>
        /// </summary>
        public List<AwsEcsClusterClusterSettingsDetails> ClusterSettings
        {
            get { return this._clusterSettings; }
            set { this._clusterSettings = value; }
        }

        // Check to see if ClusterSettings property is set
        internal bool IsSetClusterSettings()
        {
            return this._clusterSettings != null && this._clusterSettings.Count > 0; 
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
        /// </summary>
        public List<AwsEcsClusterDefaultCapacityProviderStrategyDetails> DefaultCapacityProviderStrategy
        {
            get { return this._defaultCapacityProviderStrategy; }
            set { this._defaultCapacityProviderStrategy = value; }
        }

        // Check to see if DefaultCapacityProviderStrategy property is set
        internal bool IsSetDefaultCapacityProviderStrategy()
        {
            return this._defaultCapacityProviderStrategy != null && this._defaultCapacityProviderStrategy.Count > 0; 
        }

    }
}