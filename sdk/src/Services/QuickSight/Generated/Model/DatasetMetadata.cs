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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a dataset.
    /// </summary>
    public partial class DatasetMetadata
    {
        private List<TopicCalculatedField> _calculatedFields = AWSConfigs.InitializeCollections ? new List<TopicCalculatedField>() : null;
        private List<TopicColumn> _columns = AWSConfigs.InitializeCollections ? new List<TopicColumn>() : null;
        private DataAggregation _dataAggregation;
        private string _datasetArn;
        private string _datasetDescription;
        private string _datasetName;
        private List<TopicFilter> _filters = AWSConfigs.InitializeCollections ? new List<TopicFilter>() : null;
        private List<TopicNamedEntity> _namedEntities = AWSConfigs.InitializeCollections ? new List<TopicNamedEntity>() : null;

        /// <summary>
        /// Gets and sets the property CalculatedFields. 
        /// <para>
        /// The list of calculated field definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicCalculatedField> CalculatedFields
        {
            get { return this._calculatedFields; }
            set { this._calculatedFields = value; }
        }

        // Check to see if CalculatedFields property is set
        internal bool IsSetCalculatedFields()
        {
            return this._calculatedFields != null && (this._calculatedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// The list of column definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicColumn> Columns
        {
            get { return this._columns; }
            set { this._columns = value; }
        }

        // Check to see if Columns property is set
        internal bool IsSetColumns()
        {
            return this._columns != null && (this._columns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataAggregation. 
        /// <para>
        /// The definition of a data aggregation.
        /// </para>
        /// </summary>
        public DataAggregation DataAggregation
        {
            get { return this._dataAggregation; }
            set { this._dataAggregation = value; }
        }

        // Check to see if DataAggregation property is set
        internal bool IsSetDataAggregation()
        {
            return this._dataAggregation != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// The description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// The list of filter definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamedEntities. 
        /// <para>
        /// The list of named entities definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicNamedEntity> NamedEntities
        {
            get { return this._namedEntities; }
            set { this._namedEntities = value; }
        }

        // Check to see if NamedEntities property is set
        internal bool IsSetNamedEntities()
        {
            return this._namedEntities != null && (this._namedEntities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}