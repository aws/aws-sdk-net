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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Matter endpoint used in capability report.
    /// </summary>
    public partial class MatterCapabilityReportEndpoint
    {
        private List<string> _clientClusters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<MatterCapabilityReportCluster> _clusters = AWSConfigs.InitializeCollections ? new List<MatterCapabilityReportCluster>() : null;
        private List<string> _deviceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private List<string> _parts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _semanticTags = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClientClusters. 
        /// <para>
        /// Semantic information related to endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<string> ClientClusters
        {
            get { return this._clientClusters; }
            set { this._clientClusters = value; }
        }

        // Check to see if ClientClusters property is set
        internal bool IsSetClientClusters()
        {
            return this._clientClusters != null && (this._clientClusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// Matter clusters used in capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<MatterCapabilityReportCluster> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeviceTypes. 
        /// <para>
        /// The type of device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<string> DeviceTypes
        {
            get { return this._deviceTypes; }
            set { this._deviceTypes = value; }
        }

        // Check to see if DeviceTypes property is set
        internal bool IsSetDeviceTypes()
        {
            return this._deviceTypes != null && (this._deviceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the Amazon Web Services Matter capability report endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// Heirachy of child endpoints contained in the given endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<string> Parts
        {
            get { return this._parts; }
            set { this._parts = value; }
        }

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this._parts != null && (this._parts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SemanticTags. 
        /// <para>
        /// Semantic information related to endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<string> SemanticTags
        {
            get { return this._semanticTags; }
            set { this._semanticTags = value; }
        }

        // Check to see if SemanticTags property is set
        internal bool IsSetSemanticTags()
        {
            return this._semanticTags != null && (this._semanticTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}