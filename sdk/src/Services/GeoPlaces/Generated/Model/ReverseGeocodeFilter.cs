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
 * Do not modify this file. This file is generated from the geo-places-2020-11-19.normal.json service model.
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
namespace Amazon.GeoPlaces.Model
{
    /// <summary>
    /// The included place types.
    /// </summary>
    public partial class ReverseGeocodeFilter
    {
        private List<string> _includePlaceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property IncludePlaceTypes. 
        /// <para>
        /// The included place types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> IncludePlaceTypes
        {
            get { return this._includePlaceTypes; }
            set { this._includePlaceTypes = value; }
        }

        // Check to see if IncludePlaceTypes property is set
        internal bool IsSetIncludePlaceTypes()
        {
            return this._includePlaceTypes != null && (this._includePlaceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}