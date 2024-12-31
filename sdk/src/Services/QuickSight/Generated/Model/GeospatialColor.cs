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
    /// The visualization properties for solid, gradient, and categorical colors.
    /// </summary>
    public partial class GeospatialColor
    {
        private GeospatialCategoricalColor _categorical;
        private GeospatialGradientColor _gradient;
        private GeospatialSolidColor _solid;

        /// <summary>
        /// Gets and sets the property Categorical. 
        /// <para>
        /// The visualization properties for the categorical color.
        /// </para>
        /// </summary>
        public GeospatialCategoricalColor Categorical
        {
            get { return this._categorical; }
            set { this._categorical = value; }
        }

        // Check to see if Categorical property is set
        internal bool IsSetCategorical()
        {
            return this._categorical != null;
        }

        /// <summary>
        /// Gets and sets the property Gradient. 
        /// <para>
        /// The visualization properties for the gradient color.
        /// </para>
        /// </summary>
        public GeospatialGradientColor Gradient
        {
            get { return this._gradient; }
            set { this._gradient = value; }
        }

        // Check to see if Gradient property is set
        internal bool IsSetGradient()
        {
            return this._gradient != null;
        }

        /// <summary>
        /// Gets and sets the property Solid. 
        /// <para>
        /// The visualization properties for the solid color.
        /// </para>
        /// </summary>
        public GeospatialSolidColor Solid
        {
            get { return this._solid; }
            set { this._solid = value; }
        }

        // Check to see if Solid property is set
        internal bool IsSetSolid()
        {
            return this._solid != null;
        }

    }
}