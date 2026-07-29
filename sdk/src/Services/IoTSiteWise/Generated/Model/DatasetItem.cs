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
    /// &lt;p&gt;A dataset to process.&lt;/p&gt;
    /// </summary>
    public partial class DatasetItem
    {
        private string _datasetId;
        private List<string> _exportDataTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TrimSettings _trimSettings;

        /// <summary>
        /// Gets and sets the property DatasetId. &lt;p&gt;The unique identifier for the dataset.&lt;/p&gt;
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property ExportDataTypes. &lt;p&gt;The optional subset of data types
        /// to export. If omitted, all data types are exported.&lt;/p&gt;
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> ExportDataTypes
        {
            get { return this._exportDataTypes; }
            set { this._exportDataTypes = value; }
        }

        // Check to see if ExportDataTypes property is set
        internal bool IsSetExportDataTypes()
        {
            return this._exportDataTypes != null && (this._exportDataTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrimSettings. &lt;p&gt;The trim settings applied to all
        /// items in the dataset. When omitted, the full dataset time range is used.&lt;/p&gt;
        /// </summary>
        public TrimSettings TrimSettings
        {
            get { return this._trimSettings; }
            set { this._trimSettings = value; }
        }

        // Check to see if TrimSettings property is set
        internal bool IsSetTrimSettings()
        {
            return this._trimSettings != null;
        }

    }
}