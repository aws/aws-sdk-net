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
    /// The formatting configuration for the color.
    /// </summary>
    public partial class ConditionalFormattingColor
    {
        private ConditionalFormattingGradientColor _gradient;
        private ConditionalFormattingSolidColor _solid;

        /// <summary>
        /// Gets and sets the property Gradient. 
        /// <para>
        /// Formatting configuration for gradient color.
        /// </para>
        /// </summary>
        public ConditionalFormattingGradientColor Gradient
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
        /// Formatting configuration for solid color.
        /// </para>
        /// </summary>
        public ConditionalFormattingSolidColor Solid
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