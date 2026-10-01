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
    /// Configuration for data preparation operations, defining the complete pipeline from
    /// source tables through transformations to destination tables.
    /// </summary>
    public partial class DataPrepConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationTableMap. 
        /// <para>
        /// A map of destination tables that receive the final prepared data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public Dictionary<string, DestinationTable> DestinationTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DestinationTable>() : null;

        /// <summary>
        /// Checks to see if the DestinationTableMap property is set.
        /// </summary>
        internal bool IsSetDestinationTableMap() => this.DestinationTableMap != null && (this.DestinationTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceTableMap. 
        /// <para>
        /// A map of source tables that provide information about underlying sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public Dictionary<string, SourceTable> SourceTableMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SourceTable>() : null;

        /// <summary>
        /// Checks to see if the SourceTableMap property is set.
        /// </summary>
        internal bool IsSetSourceTableMap() => this.SourceTableMap != null && (this.SourceTableMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransformStepMap. 
        /// <para>
        /// A map of transformation steps that process the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public Dictionary<string, TransformStep> TransformStepMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TransformStep>() : null;

        /// <summary>
        /// Checks to see if the TransformStepMap property is set.
        /// </summary>
        internal bool IsSetTransformStepMap() => this.TransformStepMap != null && (this.TransformStepMap.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
