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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Specifies the map tile style selected from an available provider.
    /// </summary>
    public partial class MapConfiguration
    {
        private string _style;

        /// <summary>
        /// Gets and sets the property Style. 
        /// <para>
        /// Specifies the map style selected from an available data provider.
        /// </para>
        ///  
        /// <para>
        /// Valid styles: <code>VectorEsriLightGrayCanvas</code>, <code>VectorEsriLight</code>,
        /// <code>VectorEsriStreets</code>, <code>VectorEsriNavigation</code>, <code>VectorEsriDarkGrayCanvas</code>,
        /// <code>VectorEsriLightGrayCanvas</code>, <code>VectorHereBerlin</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When using HERE as your data provider, and selecting the Style <code>VectorHereBerlin</code>,
        /// you may not use HERE Maps for Asset Management. See the <a href="https://aws.amazon.com/service-terms/">AWS
        /// Service Terms</a> for Amazon Location Service. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Style
        {
            get { return this._style; }
            set { this._style = value; }
        }

        // Check to see if Style property is set
        internal bool IsSetStyle()
        {
            return this._style != null;
        }

    }
}