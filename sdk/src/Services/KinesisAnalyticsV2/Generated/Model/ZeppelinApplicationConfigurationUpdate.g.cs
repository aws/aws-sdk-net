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
    /// Updates to the configuration of Managed Service for Apache Flink Studio notebook.
    /// </summary>
    public partial class ZeppelinApplicationConfigurationUpdate
    {
        /// <summary>
        /// Gets and sets the property CatalogConfigurationUpdate. 
        /// <para>
        /// Updates to the configuration of the Amazon Glue Data Catalog that is associated with
        /// the Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public CatalogConfigurationUpdate CatalogConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the CatalogConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetCatalogConfigurationUpdate() => this.CatalogConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property CustomArtifactsConfigurationUpdate. 
        /// <para>
        /// Updates to the customer artifacts. Custom artifacts are dependency JAR files and user-defined
        /// functions (UDF).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CustomArtifactConfiguration> CustomArtifactsConfigurationUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomArtifactConfiguration>() : null;

        /// <summary>
        /// Checks to see if the CustomArtifactsConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetCustomArtifactsConfigurationUpdate() => this.CustomArtifactsConfigurationUpdate != null && (this.CustomArtifactsConfigurationUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeployAsApplicationConfigurationUpdate.
        /// </summary>
        public DeployAsApplicationConfigurationUpdate DeployAsApplicationConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the DeployAsApplicationConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetDeployAsApplicationConfigurationUpdate() => this.DeployAsApplicationConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationUpdate. 
        /// <para>
        /// Updates to the monitoring configuration of a Managed Service for Apache Flink Studio
        /// notebook.
        /// </para>
        /// </summary>
        public ZeppelinMonitoringConfigurationUpdate MonitoringConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetMonitoringConfigurationUpdate() => this.MonitoringConfigurationUpdate != null;
    }
}
