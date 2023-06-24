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
    /// It contains configs such as ReverseGeocodingConfig and MapMatchingConfig.
    /// </summary>
    public partial class VectorEnrichmentJobConfig
    {
        private MapMatchingConfig _mapMatchingConfig;
        private ReverseGeocodingConfig _reverseGeocodingConfig;

        /// <summary>
        /// Gets and sets the property MapMatchingConfig. 
        /// <para>
        /// The input structure for Map Matching operation type.
        /// </para>
        /// </summary>
        public MapMatchingConfig MapMatchingConfig
        {
            get { return this._mapMatchingConfig; }
            set { this._mapMatchingConfig = value; }
        }

        // Check to see if MapMatchingConfig property is set
        internal bool IsSetMapMatchingConfig()
        {
            return this._mapMatchingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ReverseGeocodingConfig. 
        /// <para>
        /// The input structure for Reverse Geocoding operation type.
        /// </para>
        /// </summary>
        public ReverseGeocodingConfig ReverseGeocodingConfig
        {
            get { return this._reverseGeocodingConfig; }
            set { this._reverseGeocodingConfig = value; }
        }

        // Check to see if ReverseGeocodingConfig property is set
        internal bool IsSetReverseGeocodingConfig()
        {
            return this._reverseGeocodingConfig != null;
        }

    }
}