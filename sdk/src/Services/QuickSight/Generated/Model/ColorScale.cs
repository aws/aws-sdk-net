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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Determines the color scale that is applied to the visual.
    /// </summary>
    public partial class ColorScale
    {
        private ColorFillType _colorFillType;
        private List<DataColor> _colors = new List<DataColor>();
        private DataColor _nullValueColor;

        /// <summary>
        /// Gets and sets the property ColorFillType. 
        /// <para>
        /// Determines the color fill type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColorFillType ColorFillType
        {
            get { return this._colorFillType; }
            set { this._colorFillType = value; }
        }

        // Check to see if ColorFillType property is set
        internal bool IsSetColorFillType()
        {
            return this._colorFillType != null;
        }

        /// <summary>
        /// Gets and sets the property Colors. 
        /// <para>
        /// Determines the list of colors that are applied to the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=3)]
        public List<DataColor> Colors
        {
            get { return this._colors; }
            set { this._colors = value; }
        }

        // Check to see if Colors property is set
        internal bool IsSetColors()
        {
            return this._colors != null && this._colors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NullValueColor. 
        /// <para>
        /// Determines the color that is applied to null values.
        /// </para>
        /// </summary>
        public DataColor NullValueColor
        {
            get { return this._nullValueColor; }
            set { this._nullValueColor = value; }
        }

        // Check to see if NullValueColor property is set
        internal bool IsSetNullValueColor()
        {
            return this._nullValueColor != null;
        }

    }
}