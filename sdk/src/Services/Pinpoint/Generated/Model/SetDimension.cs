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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the dimension type and values for a segment dimension.
    /// </summary>
    public partial class SetDimension
    {
        private DimensionType _dimensionType;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property DimensionType. 
        /// <para>
        /// The type of segment dimension to use. Valid values are: INCLUSIVE, endpoints that
        /// match the criteria are included in the segment; and, EXCLUSIVE, endpoints that match
        /// the criteria are excluded from the segment.
        /// </para>
        /// </summary>
        public DimensionType DimensionType
        {
            get { return this._dimensionType; }
            set { this._dimensionType = value; }
        }

        // Check to see if DimensionType property is set
        internal bool IsSetDimensionType()
        {
            return this._dimensionType != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The criteria values to use for the segment dimension. Depending on the value of the
        /// DimensionType property, endpoints are included or excluded from the segment if their
        /// values match the criteria values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}