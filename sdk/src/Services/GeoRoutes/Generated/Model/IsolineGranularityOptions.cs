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
    /// Isoline granularity related options.
    /// </summary>
    public partial class IsolineGranularityOptions
    {
        private int? _maxPoints;
        private long? _maxResolution;

        /// <summary>
        /// Gets and sets the property MaxPoints. 
        /// <para>
        /// Maximum number of points of returned Isoline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=31)]
        public int? MaxPoints
        {
            get { return this._maxPoints; }
            set { this._maxPoints = value; }
        }

        // Check to see if MaxPoints property is set
        internal bool IsSetMaxPoints()
        {
            return this._maxPoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResolution. 
        /// <para>
        /// Maximum resolution of the returned isoline.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxResolution
        {
            get { return this._maxResolution; }
            set { this._maxResolution = value; }
        }

        // Check to see if MaxResolution property is set
        internal bool IsSetMaxResolution()
        {
            return this._maxResolution.HasValue; 
        }

    }
}