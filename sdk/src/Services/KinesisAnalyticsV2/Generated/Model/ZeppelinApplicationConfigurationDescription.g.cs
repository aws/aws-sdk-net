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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// The configuration of a Managed Service for Apache Flink Studio notebook.
    /// </summary>
    public partial class ZeppelinApplicationConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property CatalogConfigurationDescription. 
        /// <para>
        /// The Amazon Glue Data Catalog that is associated with the Managed Service for Apache
        /// Flink Studio notebook.
        /// </para>
        /// </summary>
        public CatalogConfigurationDescription CatalogConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the CatalogConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetCatalogConfigurationDescription() => this.CatalogConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property CustomArtifactsConfigurationDescription. 
        /// <para>
        /// Custom artifacts are dependency JARs and user-defined functions (UDF).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CustomArtifactConfigurationDescription> CustomArtifactsConfigurationDescription { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomArtifactConfigurationDescription>() : null;

        /// <summary>
        /// Checks to see if the CustomArtifactsConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetCustomArtifactsConfigurationDescription() => this.CustomArtifactsConfigurationDescription != null && (this.CustomArtifactsConfigurationDescription.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeployAsApplicationConfigurationDescription. 
        /// <para>
        /// The parameters required to deploy a Managed Service for Apache Flink Studio notebook
        /// as an application with durable state.
        /// </para>
        /// </summary>
        public DeployAsApplicationConfigurationDescription DeployAsApplicationConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the DeployAsApplicationConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetDeployAsApplicationConfigurationDescription() => this.DeployAsApplicationConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationDescription. 
        /// <para>
        /// The monitoring configuration of a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ZeppelinMonitoringConfigurationDescription MonitoringConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetMonitoringConfigurationDescription() => this.MonitoringConfigurationDescription != null;
    }
}
