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
    public partial class ZeppelinApplicationConfiguration
    {
        private CatalogConfiguration _catalogConfiguration;
        private List<CustomArtifactConfiguration> _customArtifactsConfiguration = AWSConfigs.InitializeCollections ? new List<CustomArtifactConfiguration>() : null;
        private DeployAsApplicationConfiguration _deployAsApplicationConfiguration;
        private ZeppelinMonitoringConfiguration _monitoringConfiguration;

        /// <summary>
        /// Gets and sets the property CatalogConfiguration. 
        /// <para>
        /// The Amazon Glue Data Catalog that you use in queries in a Managed Service for Apache
        /// Flink Studio notebook.
        /// </para>
        /// </summary>
        public CatalogConfiguration CatalogConfiguration
        {
            get { return this._catalogConfiguration; }
            set { this._catalogConfiguration = value; }
        }

        // Check to see if CatalogConfiguration property is set
        internal bool IsSetCatalogConfiguration()
        {
            return this._catalogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomArtifactsConfiguration. 
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
        public List<CustomArtifactConfiguration> CustomArtifactsConfiguration
        {
            get { return this._customArtifactsConfiguration; }
            set { this._customArtifactsConfiguration = value; }
        }

        // Check to see if CustomArtifactsConfiguration property is set
        internal bool IsSetCustomArtifactsConfiguration()
        {
            return this._customArtifactsConfiguration != null && (this._customArtifactsConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeployAsApplicationConfiguration. 
        /// <para>
        /// The information required to deploy a Managed Service for Apache Flink Studio notebook
        /// as an application with durable state.
        /// </para>
        /// </summary>
        public DeployAsApplicationConfiguration DeployAsApplicationConfiguration
        {
            get { return this._deployAsApplicationConfiguration; }
            set { this._deployAsApplicationConfiguration = value; }
        }

        // Check to see if DeployAsApplicationConfiguration property is set
        internal bool IsSetDeployAsApplicationConfiguration()
        {
            return this._deployAsApplicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// The monitoring configuration of a Managed Service for Apache Flink Studio notebook.
        /// </para>
        /// </summary>
        public ZeppelinMonitoringConfiguration MonitoringConfiguration
        {
            get { return this._monitoringConfiguration; }
            set { this._monitoringConfiguration = value; }
        }

        // Check to see if MonitoringConfiguration property is set
        internal bool IsSetMonitoringConfiguration()
        {
            return this._monitoringConfiguration != null;
        }

    }
}