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
    /// The tick label options of an axis.
    /// </summary>
    public partial class AxisTickLabelOptions
    {
        private LabelOptions _labelOptions;
        private double? _rotationAngle;

        /// <summary>
        /// Gets and sets the property LabelOptions. 
        /// <para>
        /// Determines whether or not the axis ticks are visible.
        /// </para>
        /// </summary>
        public LabelOptions LabelOptions
        {
            get { return this._labelOptions; }
            set { this._labelOptions = value; }
        }

        // Check to see if LabelOptions property is set
        internal bool IsSetLabelOptions()
        {
            return this._labelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RotationAngle. 
        /// <para>
        /// The rotation angle of the axis tick labels.
        /// </para>
        /// </summary>
        public double RotationAngle
        {
            get { return this._rotationAngle.GetValueOrDefault(); }
            set { this._rotationAngle = value; }
        }

        // Check to see if RotationAngle property is set
        internal bool IsSetRotationAngle()
        {
            return this._rotationAngle.HasValue; 
        }

    }
}