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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MultiPolygonGeometryInput
    {
        private List<List<List<List<double>>>> _coordinates = new List<List<List<List<double>>>>();

        /// <summary>
        /// Gets and sets the property Coordinates. 
        /// <para>
        /// The coordinates of the multipolygon geometry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<List<List<List<double>>>> Coordinates
        {
            get { return this._coordinates; }
            set { this._coordinates = value; }
        }

        // Check to see if Coordinates property is set
        internal bool IsSetCoordinates()
        {
            return this._coordinates != null && this._coordinates.Count > 0; 
        }

    }
}