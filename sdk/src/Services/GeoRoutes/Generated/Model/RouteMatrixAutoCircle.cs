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
    /// Provides the circle that was used while calculating the route.
    /// </summary>
    public partial class RouteMatrixAutoCircle
    {
        private long? _margin;
        private long? _maxRadius;

        /// <summary>
        /// Gets and sets the property Margin. 
        /// <para>
        /// The margin provided for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200000)]
        public long? Margin
        {
            get { return this._margin; }
            set { this._margin = value; }
        }

        // Check to see if Margin property is set
        internal bool IsSetMargin()
        {
            return this._margin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRadius. 
        /// <para>
        /// The maximum size of the radius provided for the calculation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200000)]
        public long? MaxRadius
        {
            get { return this._maxRadius; }
            set { this._maxRadius = value; }
        }

        // Check to see if MaxRadius property is set
        internal bool IsSetMaxRadius()
        {
            return this._maxRadius.HasValue; 
        }

    }
}