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
    /// The visualization properties for solid, gradient, and categorical colors.
    /// </summary>
    public partial class GeospatialColor
    {
        /// <summary>
        /// Gets and sets the property Categorical. 
        /// <para>
        /// The visualization properties for the categorical color.
        /// </para>
        /// </summary>
        public GeospatialCategoricalColor Categorical { get; set; }

        /// <summary>
        /// Checks to see if the Categorical property is set.
        /// </summary>
        internal bool IsSetCategorical() => this.Categorical != null;

        /// <summary>
        /// Gets and sets the property Gradient. 
        /// <para>
        /// The visualization properties for the gradient color.
        /// </para>
        /// </summary>
        public GeospatialGradientColor Gradient { get; set; }

        /// <summary>
        /// Checks to see if the Gradient property is set.
        /// </summary>
        internal bool IsSetGradient() => this.Gradient != null;

        /// <summary>
        /// Gets and sets the property Solid. 
        /// <para>
        /// The visualization properties for the solid color.
        /// </para>
        /// </summary>
        public GeospatialSolidColor Solid { get; set; }

        /// <summary>
        /// Checks to see if the Solid property is set.
        /// </summary>
        internal bool IsSetSolid() => this.Solid != null;
    }
}
