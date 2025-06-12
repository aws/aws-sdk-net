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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The data configuration for your dataset group and any additional datasets.
    /// </summary>
    public partial class DataConfig
    {
        private List<AdditionalDataset> _additionalDatasets = AWSConfigs.InitializeCollections ? new List<AdditionalDataset>() : null;
        private List<AttributeConfig> _attributeConfigs = AWSConfigs.InitializeCollections ? new List<AttributeConfig>() : null;
        private string _datasetGroupArn;

        /// <summary>
        /// Gets and sets the property AdditionalDatasets. 
        /// <para>
        /// Additional built-in datasets like Holidays and the Weather Index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<AdditionalDataset> AdditionalDatasets
        {
            get { return this._additionalDatasets; }
            set { this._additionalDatasets = value; }
        }

        // Check to see if AdditionalDatasets property is set
        internal bool IsSetAdditionalDatasets()
        {
            return this._additionalDatasets != null && (this._additionalDatasets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributeConfigs. 
        /// <para>
        /// Aggregation and filling options for attributes in your dataset group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<AttributeConfig> AttributeConfigs
        {
            get { return this._attributeConfigs; }
            set { this._attributeConfigs = value; }
        }

        // Check to see if AttributeConfigs property is set
        internal bool IsSetAttributeConfigs()
        {
            return this._attributeConfigs != null && (this._attributeConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatasetGroupArn. 
        /// <para>
        /// The ARN of the dataset group used to train the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string DatasetGroupArn
        {
            get { return this._datasetGroupArn; }
            set { this._datasetGroupArn = value; }
        }

        // Check to see if DatasetGroupArn property is set
        internal bool IsSetDatasetGroupArn()
        {
            return this._datasetGroupArn != null;
        }

    }
}