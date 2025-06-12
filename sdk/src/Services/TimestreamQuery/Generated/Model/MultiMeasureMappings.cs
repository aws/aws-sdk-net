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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
    /// Only one of MixedMeasureMappings or MultiMeasureMappings is to be provided. MultiMeasureMappings
    /// can be used to ingest data as multi measures in the derived table.
    /// </summary>
    public partial class MultiMeasureMappings
    {
        private List<MultiMeasureAttributeMapping> _multiMeasureAttributeMappings = AWSConfigs.InitializeCollections ? new List<MultiMeasureAttributeMapping>() : null;
        private string _targetMultiMeasureName;

        /// <summary>
        /// Gets and sets the property MultiMeasureAttributeMappings. 
        /// <para>
        /// Required. Attribute mappings to be used for mapping query results to ingest data for
        /// multi-measure attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<MultiMeasureAttributeMapping> MultiMeasureAttributeMappings
        {
            get { return this._multiMeasureAttributeMappings; }
            set { this._multiMeasureAttributeMappings = value; }
        }

        // Check to see if MultiMeasureAttributeMappings property is set
        internal bool IsSetMultiMeasureAttributeMappings()
        {
            return this._multiMeasureAttributeMappings != null && (this._multiMeasureAttributeMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetMultiMeasureName. 
        /// <para>
        /// The name of the target multi-measure name in the derived table. This input is required
        /// when measureNameColumn is not provided. If MeasureNameColumn is provided, then value
        /// from that column will be used as multi-measure name.
        /// </para>
        /// </summary>
        public string TargetMultiMeasureName
        {
            get { return this._targetMultiMeasureName; }
            set { this._targetMultiMeasureName = value; }
        }

        // Check to see if TargetMultiMeasureName property is set
        internal bool IsSetTargetMultiMeasureName()
        {
            return this._targetMultiMeasureName != null;
        }

    }
}