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
    /// The custom actions for a layer.
    /// </summary>
    public partial class GeospatialLayerJoinDefinition
    {
        /// <summary>
        /// Gets and sets the property ColorField. 
        /// <para>
        /// The geospatial color field for the join definition.
        /// </para>
        /// </summary>
        public GeospatialLayerColorField ColorField { get; set; }

        /// <summary>
        /// Checks to see if the ColorField property is set.
        /// </summary>
        internal bool IsSetColorField() => this.ColorField != null;

        /// <summary>
        /// Gets and sets the property DatasetKeyField.
        /// </summary>
        public UnaggregatedField DatasetKeyField { get; set; }

        /// <summary>
        /// Checks to see if the DatasetKeyField property is set.
        /// </summary>
        internal bool IsSetDatasetKeyField() => this.DatasetKeyField != null;

        /// <summary>
        /// Gets and sets the property ShapeKeyField. 
        /// <para>
        /// The name of the field or property in the geospatial data source.
        /// </para>
        /// </summary>
        public string ShapeKeyField { get; set; }

        /// <summary>
        /// Checks to see if the ShapeKeyField property is set.
        /// </summary>
        internal bool IsSetShapeKeyField() => this.ShapeKeyField != null;
    }
}
