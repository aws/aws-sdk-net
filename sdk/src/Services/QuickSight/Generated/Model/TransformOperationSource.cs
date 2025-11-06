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
    /// Specifies the source of data for a transform operation, including the source operation
    /// and column mappings.
    /// </summary>
    public partial class TransformOperationSource
    {
        private List<DataSetColumnIdMapping> _columnIdMappings = AWSConfigs.InitializeCollections ? new List<DataSetColumnIdMapping>() : null;
        private string _transformOperationId;

        /// <summary>
        /// Gets and sets the property ColumnIdMappings. 
        /// <para>
        /// The mappings between source column identifiers and target column identifiers for this
        /// transformation.
        /// </para>
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
        /// Gets and sets the property TransformOperationId. 
        /// <para>
        /// The identifier of the transform operation that provides input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TransformOperationId
        {
            get { return this._transformOperationId; }
            set { this._transformOperationId = value; }
        }

        // Check to see if TransformOperationId property is set
        internal bool IsSetTransformOperationId()
        {
            return this._transformOperationId != null;
        }

    }
}