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
    /// The configuration of a Managed Service for Apache Flink Studio notebook.
    /// </summary>
    public partial class ZeppelinApplicationConfigurationDescription
    {
        private CatalogConfigurationDescription _catalogConfigurationDescription;
        private List<CustomArtifactConfigurationDescription> _customArtifactsConfigurationDescription = AWSConfigs.InitializeCollections ? new List<CustomArtifactConfigurationDescription>() : null;
        private DeployAsApplicationConfigurationDescription _deployAsApplicationConfigurationDescription;
        private ZeppelinMonitoringConfigurationDescription _monitoringConfigurationDescription;

        /// <summary>
        /// Gets and sets the property CatalogConfigurationDescription. 
        /// <para>
        /// The Amazon Glue Data Catalog that is associated with the Managed Service for Apache
        /// Flink Studio notebook.
        /// </para>
        /// </summary>
        public CatalogConfigurationDescription CatalogConfigurationDescription
        {
            get { return this._catalogConfigurationDescription; }
            set { this._catalogConfigurationDescription = value; }
        }

        // Check to see if CatalogConfigurationDescription property is set
        internal bool IsSetCatalogConfigurationDescription()
        {
            return this._catalogConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CustomArtifactsConfigurationDescription. 
        /// <para>
        /// Custom artifacts are dependency JARs and user-defined functions (UDF).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<CustomArtifactConfigurationDescription> CustomArtifactsConfigurationDescription
        {
            get { return this._customArtifactsConfigurationDescription; }
            set { this._customArtifactsConfigurationDescription = value; }
        }

        // Check to see if CustomArtifactsConfigurationDescription property is set
        internal bool IsSetCustomArtifactsConfigurationDescription()
        {
            return this._customArtifactsConfigurationDescription != null && (this._customArtifactsConfigurationDescription.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeployAsApplicationConfigurationDescription. 
        /// <para>
        /// The parameters required to deploy a Managed Service for Apache Flink Studio notebook
        /// as an application with durable state.
        /// </para>
        /// </summary>
        public DeployAsApplicationConfigurationDescription DeployAsApplicationConfigurationDescription
        {
            get { return this._deployAsApplicationConfigurationDescription; }
            set { this._deployAsApplicationConfigurationDescription = value; }
        }

        // Check to see if DeployAsApplicationConfigurationDescription property is set
        internal bool IsSetDeployAsApplicationConfigurationDescription()
        {
            return this._deployAsApplicationConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationDescription. 
        /// <para>
        /// The monitoring configuration of a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ZeppelinMonitoringConfigurationDescription MonitoringConfigurationDescription
        {
            get { return this._monitoringConfigurationDescription; }
            set { this._monitoringConfigurationDescription = value; }
        }

        // Check to see if MonitoringConfigurationDescription property is set
        internal bool IsSetMonitoringConfigurationDescription()
        {
            return this._monitoringConfigurationDescription != null;
        }

    }
}