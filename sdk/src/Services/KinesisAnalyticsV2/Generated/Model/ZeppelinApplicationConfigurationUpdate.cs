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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
        private CatalogConfigurationUpdate _catalogConfigurationUpdate;
        private List<CustomArtifactConfiguration> _customArtifactsConfigurationUpdate = AWSConfigs.InitializeCollections ? new List<CustomArtifactConfiguration>() : null;
        private DeployAsApplicationConfigurationUpdate _deployAsApplicationConfigurationUpdate;
        private ZeppelinMonitoringConfigurationUpdate _monitoringConfigurationUpdate;

        /// <summary>
        /// Gets and sets the property CatalogConfigurationUpdate. 
        /// <para>
        /// Updates to the configuration of the Amazon Glue Data Catalog that is associated with
        /// the Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public CatalogConfigurationUpdate CatalogConfigurationUpdate
        {
            get { return this._catalogConfigurationUpdate; }
            set { this._catalogConfigurationUpdate = value; }
        }

        // Check to see if CatalogConfigurationUpdate property is set
        internal bool IsSetCatalogConfigurationUpdate()
        {
            return this._catalogConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property CustomArtifactsConfigurationUpdate. 
        /// <para>
        /// Updates to the customer artifacts. Custom artifacts are dependency JAR files and user-defined
        /// functions (UDF).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<CustomArtifactConfiguration> CustomArtifactsConfigurationUpdate
        {
            get { return this._customArtifactsConfigurationUpdate; }
            set { this._customArtifactsConfigurationUpdate = value; }
        }

        // Check to see if CustomArtifactsConfigurationUpdate property is set
        internal bool IsSetCustomArtifactsConfigurationUpdate()
        {
            return this._customArtifactsConfigurationUpdate != null && (this._customArtifactsConfigurationUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeployAsApplicationConfigurationUpdate.
        /// </summary>
        public DeployAsApplicationConfigurationUpdate DeployAsApplicationConfigurationUpdate
        {
            get { return this._deployAsApplicationConfigurationUpdate; }
            set { this._deployAsApplicationConfigurationUpdate = value; }
        }

        // Check to see if DeployAsApplicationConfigurationUpdate property is set
        internal bool IsSetDeployAsApplicationConfigurationUpdate()
        {
            return this._deployAsApplicationConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationUpdate. 
        /// <para>
        /// Updates to the monitoring configuration of a Managed Service for Apache Flink Studio
        /// notebook.
        /// </para>
        /// </summary>
        public ZeppelinMonitoringConfigurationUpdate MonitoringConfigurationUpdate
        {
            get { return this._monitoringConfigurationUpdate; }
            set { this._monitoringConfigurationUpdate = value; }
        }

        // Check to see if MonitoringConfigurationUpdate property is set
        internal bool IsSetMonitoringConfigurationUpdate()
        {
            return this._monitoringConfigurationUpdate != null;
        }

    }
}