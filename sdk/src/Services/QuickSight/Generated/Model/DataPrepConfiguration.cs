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
    /// Configuration for data preparation operations, defining the complete pipeline from
    /// source tables through transformations to destination tables.
    /// </summary>
    public partial class DataPrepConfiguration
    {
        private Dictionary<string, DestinationTable> _destinationTableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, DestinationTable>() : null;
        private Dictionary<string, SourceTable> _sourceTableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, SourceTable>() : null;
        private Dictionary<string, TransformStep> _transformStepMap = AWSConfigs.InitializeCollections ? new Dictionary<string, TransformStep>() : null;

        /// <summary>
        /// Gets and sets the property DestinationTableMap. 
        /// <para>
        /// A map of destination tables that receive the final prepared data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public Dictionary<string, DestinationTable> DestinationTableMap
        {
            get { return this._destinationTableMap; }
            set { this._destinationTableMap = value; }
        }

        // Check to see if DestinationTableMap property is set
        internal bool IsSetDestinationTableMap()
        {
            return this._destinationTableMap != null && (this._destinationTableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceTableMap. 
        /// <para>
        /// A map of source tables that provide information about underlying sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public Dictionary<string, SourceTable> SourceTableMap
        {
            get { return this._sourceTableMap; }
            set { this._sourceTableMap = value; }
        }

        // Check to see if SourceTableMap property is set
        internal bool IsSetSourceTableMap()
        {
            return this._sourceTableMap != null && (this._sourceTableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransformStepMap. 
        /// <para>
        /// A map of transformation steps that process the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public Dictionary<string, TransformStep> TransformStepMap
        {
            get { return this._transformStepMap; }
            set { this._transformStepMap = value; }
        }

        // Check to see if TransformStepMap property is set
        internal bool IsSetTransformStepMap()
        {
            return this._transformStepMap != null && (this._transformStepMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}