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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Trailer options corresponding to the vehicle.
    /// </summary>
    public partial class RouteMatrixTrailerOptions
    {
        private int? _trailerCount;

        /// <summary>
        /// Gets and sets the property TrailerCount. 
        /// <para>
        /// Number of trailers attached to the vehicle.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>0</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
        public int? TrailerCount
        {
            get { return this._trailerCount; }
            set { this._trailerCount = value; }
        }

        // Check to see if TrailerCount property is set
        internal bool IsSetTrailerCount()
        {
            return this._trailerCount.HasValue; 
        }

    }
}