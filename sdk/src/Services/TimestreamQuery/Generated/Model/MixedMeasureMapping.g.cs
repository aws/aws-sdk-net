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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// MixedMeasureMappings are mappings that can be used to ingest data into a mixture of
    /// narrow and multi measures in the derived table.
    /// </summary>
    public partial class MixedMeasureMapping
    {
        /// <summary>
        /// Gets and sets the property MeasureName. 
        /// <para>
        /// Refers to the value of measure_name in a result row. This field is required if MeasureNameColumn
        /// is provided.
        /// </para>
        /// </summary>
        public string MeasureName { get; set; }

        /// <summary>
        /// Checks to see if the MeasureName property is set.
        /// </summary>
        internal bool IsSetMeasureName() => this.MeasureName != null;

        /// <summary>
        /// Gets and sets the property MeasureValueType. 
        /// <para>
        /// Type of the value that is to be read from sourceColumn. If the mapping is for MULTI,
        /// use MeasureValueType.MULTI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MeasureValueType MeasureValueType { get; set; }

        /// <summary>
        /// Checks to see if the MeasureValueType property is set.
        /// </summary>
        internal bool IsSetMeasureValueType() => this.MeasureValueType != null;

        /// <summary>
        /// Gets and sets the property MultiMeasureAttributeMappings. 
        /// <para>
        /// Required when measureValueType is MULTI. Attribute mappings for MULTI value measures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<MultiMeasureAttributeMapping> MultiMeasureAttributeMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<MultiMeasureAttributeMapping>() : null;

        /// <summary>
        /// Checks to see if the MultiMeasureAttributeMappings property is set.
        /// </summary>
        internal bool IsSetMultiMeasureAttributeMappings() => this.MultiMeasureAttributeMappings != null && (this.MultiMeasureAttributeMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceColumn. 
        /// <para>
        /// This field refers to the source column from which measure-value is to be read for
        /// result materialization.
        /// </para>
        /// </summary>
        public string SourceColumn { get; set; }

        /// <summary>
        /// Checks to see if the SourceColumn property is set.
        /// </summary>
        internal bool IsSetSourceColumn() => this.SourceColumn != null;

        /// <summary>
        /// Gets and sets the property TargetMeasureName. 
        /// <para>
        /// Target measure name to be used. If not provided, the target measure name by default
        /// would be measure-name if provided, or sourceColumn otherwise. 
        /// </para>
        /// </summary>
        public string TargetMeasureName { get; set; }

        /// <summary>
        /// Checks to see if the TargetMeasureName property is set.
        /// </summary>
        internal bool IsSetTargetMeasureName() => this.TargetMeasureName != null;
    }
}
