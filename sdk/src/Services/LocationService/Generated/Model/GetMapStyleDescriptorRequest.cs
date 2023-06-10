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
    /// Container for the parameters to the GetMapStyleDescriptor operation.
    /// Retrieves the map style descriptor from a map resource. 
    /// 
    ///  
    /// <para>
    /// The style descriptor contains speciﬁcations on how features render on a map. For example,
    /// what data to display, what order to display the data in, and the style for the data.
    /// Style descriptors follow the Mapbox Style Specification.
    /// </para>
    /// </summary>
    public partial class GetMapStyleDescriptorRequest : AmazonLocationServiceRequest
    {
        private string _key;
        private string _mapName;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The optional <a href="https://docs.aws.amazon.com/location/latest/developerguide/using-apikeys.html">API
        /// key</a> to authorize the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MapName. 
        /// <para>
        /// The map resource to retrieve the style descriptor from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MapName
        {
            get { return this._mapName; }
            set { this._mapName = value; }
        }

        // Check to see if MapName property is set
        internal bool IsSetMapName()
        {
            return this._mapName != null;
        }

    }
}