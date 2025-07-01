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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The configuration policy for the trained models.
    /// </summary>
    public partial class TrainedModelsConfigurationPolicy
    {
        private List<LogsConfigurationPolicy> _containerLogs = AWSConfigs.InitializeCollections ? new List<LogsConfigurationPolicy>() : null;
        private MetricsConfigurationPolicy _containerMetrics;
        private TrainedModelArtifactMaxSize _maxArtifactSize;

        /// <summary>
        /// Gets and sets the property ContainerLogs. 
        /// <para>
        /// The container for the logs of the trained model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<LogsConfigurationPolicy> ContainerLogs
        {
            get { return this._containerLogs; }
            set { this._containerLogs = value; }
        }

        // Check to see if ContainerLogs property is set
        internal bool IsSetContainerLogs()
        {
            return this._containerLogs != null && (this._containerLogs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContainerMetrics. 
        /// <para>
        /// The container for the metrics of the trained model.
        /// </para>
        /// </summary>
        public MetricsConfigurationPolicy ContainerMetrics
        {
            get { return this._containerMetrics; }
            set { this._containerMetrics = value; }
        }

        // Check to see if ContainerMetrics property is set
        internal bool IsSetContainerMetrics()
        {
            return this._containerMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property MaxArtifactSize. 
        /// <para>
        /// The maximum size limit for trained model artifacts as defined in the configuration
        /// policy. This setting helps enforce consistent size limits across trained models in
        /// the collaboration.
        /// </para>
        /// </summary>
        public TrainedModelArtifactMaxSize MaxArtifactSize
        {
            get { return this._maxArtifactSize; }
            set { this._maxArtifactSize = value; }
        }

        // Check to see if MaxArtifactSize property is set
        internal bool IsSetMaxArtifactSize()
        {
            return this._maxArtifactSize != null;
        }

    }
}