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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// Creates a dataset. Session and curated datasets are created in a workspace. A session
    /// dataset contains data segments of time series data, and a curated dataset curates
    /// data segments selected from source session datasets. A dataset that connects to an
    /// external datasource is created outside of a workspace.
    /// </summary>
    public partial class CreateDatasetRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private DatasetConfig _datasetConfig;
        private string _datasetDescription;
        private string _datasetId;
        private string _datasetName;
        private DatasetSource _datasetSource;
        private DatasetTypeEnum _datasetType;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetConfig. 
        /// <para>
        /// The configuration for the dataset.
        /// </para>
        /// </summary>
        public DatasetConfig DatasetConfig
        {
            get { return this._datasetConfig; }
            set { this._datasetConfig = value; }
        }

        // Check to see if DatasetConfig property is set
        internal bool IsSetDatasetConfig()
        {
            return this._datasetConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// A description about the dataset, and its functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DatasetDescription
        {
            get { return this._datasetDescription; }
            set { this._datasetDescription = value; }
        }

        // Check to see if DatasetDescription property is set
        internal bool IsSetDatasetDescription()
        {
            return this._datasetDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetSource. 
        /// <para>
        /// The data source for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSource DatasetSource
        {
            get { return this._datasetSource; }
            set { this._datasetSource = value; }
        }

        // Check to see if DatasetSource property is set
        internal bool IsSetDatasetSource()
        {
            return this._datasetSource != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        /// The type of dataset: a session dataset, a curated dataset, or a connection to an external
        /// datasource.
        /// </para>
        /// </summary>
        public DatasetTypeEnum DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata for the dataset, provided as key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that contain metadata for the access policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/tag-resources.html">Tagging
        /// your IoT SiteWise resources</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset. Required for session and curated
        /// datasets. Omit this field for datasets that connect to an external datasource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}