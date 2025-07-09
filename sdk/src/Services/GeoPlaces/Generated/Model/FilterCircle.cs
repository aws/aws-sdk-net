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
    /// The <c>Circle</c> that all results must be in.
    /// </summary>
    public partial class FilterCircle
    {
        private List<double> _center = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private long? _radius;

        /// <summary>
        /// Gets and sets the property Center. 
        /// <para>
        /// The center position, in longitude and latitude, of the <c>FilterCircle</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Center
        {
            get { return this._center; }
            set { this._center = value; }
        }

        // Check to see if Center property is set
        internal bool IsSetCenter()
        {
            return this._center != null && (this._center.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Radius. 
        /// <para>
        /// The radius, in meters, of the <c>FilterCircle</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=21000000)]
        public long? Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }

        // Check to see if Radius property is set
        internal bool IsSetRadius()
        {
            return this._radius.HasValue; 
        }

    }
}