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
    /// Specifies the source table and column mappings for an import table operation.
    /// </summary>
    public partial class ImportTableOperationSource
    {
        private List<DataSetColumnIdMapping> _columnIdMappings = AWSConfigs.InitializeCollections ? new List<DataSetColumnIdMapping>() : null;
        private string _sourceTableId;

        /// <summary>
        /// Gets and sets the property ColumnIdMappings. 
        /// <para>
        /// The mappings between source column identifiers and target column identifiers during
        /// the import.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public List<DataSetColumnIdMapping> ColumnIdMappings
        {
            get { return this._columnIdMappings; }
            set { this._columnIdMappings = value; }
        }

        // Check to see if ColumnIdMappings property is set
        internal bool IsSetColumnIdMappings()
        {
            return this._columnIdMappings != null && (this._columnIdMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceTableId. 
        /// <para>
        /// The identifier of the source table to import data from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SourceTableId
        {
            get { return this._sourceTableId; }
            set { this._sourceTableId = value; }
        }

        // Check to see if SourceTableId property is set
        internal bool IsSetSourceTableId()
        {
            return this._sourceTableId != null;
        }

    }
}