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
    /// The custom actions for a layer.
    /// </summary>
    public partial class GeospatialLayerJoinDefinition
    {
        private GeospatialLayerColorField _colorField;
        private UnaggregatedField _datasetKeyField;
        private string _shapeKeyField;

        /// <summary>
        /// Gets and sets the property ColorField. 
        /// <para>
        /// The geospatial color field for the join definition.
        /// </para>
        /// </summary>
        public GeospatialLayerColorField ColorField
        {
            get { return this._colorField; }
            set { this._colorField = value; }
        }

        // Check to see if ColorField property is set
        internal bool IsSetColorField()
        {
            return this._colorField != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetKeyField.
        /// </summary>
        public UnaggregatedField DatasetKeyField
        {
            get { return this._datasetKeyField; }
            set { this._datasetKeyField = value; }
        }

        // Check to see if DatasetKeyField property is set
        internal bool IsSetDatasetKeyField()
        {
            return this._datasetKeyField != null;
        }

        /// <summary>
        /// Gets and sets the property ShapeKeyField. 
        /// <para>
        /// The name of the field or property in the geospatial data source.
        /// </para>
        /// </summary>
        public string ShapeKeyField
        {
            get { return this._shapeKeyField; }
            set { this._shapeKeyField = value; }
        }

        // Check to see if ShapeKeyField property is set
        internal bool IsSetShapeKeyField()
        {
            return this._shapeKeyField != null;
        }

    }
}