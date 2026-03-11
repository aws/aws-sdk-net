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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMap operation.
    /// <important> 
    /// <para>
    /// This operation is no longer current and may be deprecated in the future. We recommend
    /// upgrading to the Maps API V2 unless you require <c>Grab</c> data.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>DeleteMap</c> is part of a previous Amazon Location Service Maps API (version
    /// 1) which has been superseded by a more intuitive, powerful, and complete API (version
    /// 2).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Maps API version 2 has a simplified interface that can be used without creating
    /// or managing map resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using an AWS SDK or the AWS CLI, note that the Maps API version 2 is found
    /// under <c>geo-maps</c> or <c>geo_maps</c>, not under <c>location</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Since <c>Grab</c> is not yet fully supported in Maps API version 2, we recommend you
    /// continue using API version 1 when using <c>Grab</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Start your version 2 API journey with the <a href="https://docs.aws.amazon.com/location/latest/APIReference/API_Operations_Amazon_Location_Service_Maps_V2.html">Maps
    /// V2 API Reference</a> or the <a href="https://docs.aws.amazon.com/location/latest/developerguide/maps.html">Developer
    /// Guide</a>.
    /// </para>
    ///  </li> </ul> </important> 
    /// <para>
    /// Deletes a map resource from your Amazon Web Services account.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation deletes the resource permanently. If the map is being used in an application,
    /// the map may not render.
    /// </para>
    ///  </note>
    /// </para>
    /// </summary>
    public partial class DeleteMapRequest : AmazonLocationServiceRequest
    {
        private string _mapName;

        /// <summary>
        /// Gets and sets the property MapName. 
        /// <para>
        /// The name of the map resource to be deleted.
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