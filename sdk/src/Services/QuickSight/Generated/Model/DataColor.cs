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
    /// Determines the color that is applied to a particular data value.
    /// </summary>
    public partial class DataColor
    {
        private string _color;
        private double? _dataValue;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The color that is applied to the data value.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property DataValue. 
        /// <para>
        /// The data value that the color is applied to.
        /// </para>
        /// </summary>
        public double DataValue
        {
            get { return this._dataValue.GetValueOrDefault(); }
            set { this._dataValue = value; }
        }

        // Check to see if DataValue property is set
        internal bool IsSetDataValue()
        {
            return this._dataValue.HasValue; 
        }

    }
}