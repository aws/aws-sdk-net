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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a dataset.
    /// </summary>
    public partial class DatasetMetadata
    {
        /// <summary>
        /// Gets and sets the property CalculatedFields. 
        /// <para>
        /// The list of calculated field definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicCalculatedField> CalculatedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicCalculatedField>() : null;

        /// <summary>
        /// Checks to see if the CalculatedFields property is set.
        /// </summary>
        internal bool IsSetCalculatedFields() => this.CalculatedFields != null && (this.CalculatedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Columns. 
        /// <para>
        /// The list of column definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicColumn> Columns { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicColumn>() : null;

        /// <summary>
        /// Checks to see if the Columns property is set.
        /// </summary>
        internal bool IsSetColumns() => this.Columns != null && (this.Columns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataAggregation. 
        /// <para>
        /// The definition of a data aggregation.
        /// </para>
        /// </summary>
        public DataAggregation DataAggregation { get; set; }

        /// <summary>
        /// Checks to see if the DataAggregation property is set.
        /// </summary>
        internal bool IsSetDataAggregation() => this.DataAggregation != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetDescription. 
        /// <para>
        /// The description of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetDescription { get; set; }

        /// <summary>
        /// Checks to see if the DatasetDescription property is set.
        /// </summary>
        internal bool IsSetDatasetDescription() => this.DatasetDescription != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The list of filter definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NamedEntities. 
        /// <para>
        /// The list of named entities definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TopicNamedEntity> NamedEntities { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicNamedEntity>() : null;

        /// <summary>
        /// Checks to see if the NamedEntities property is set.
        /// </summary>
        internal bool IsSetNamedEntities() => this.NamedEntities != null && (this.NamedEntities.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
