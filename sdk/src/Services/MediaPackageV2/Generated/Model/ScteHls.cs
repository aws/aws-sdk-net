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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The SCTE configuration.
    /// </summary>
    public partial class ScteHls
    {
        private AdMarkerHls _adMarkerHls;

        /// <summary>
        /// Gets and sets the property AdMarkerHls. 
        /// <para>
        /// Ad markers indicate when ads should be inserted during playback. If you include ad
        /// markers in the content stream in your upstream encoders, then you need to inform MediaPackage
        /// what to do with the ad markers in the output. Choose what you want MediaPackage to
        /// do with the ad markers.
        /// </para>
        ///  
        /// <para>
        /// Value description: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DATERANGE - Insert EXT-X-DATERANGE tags to signal ad and program transition events
        /// in TS and CMAF manifests. If you use DATERANGE, you must set a programDateTimeIntervalSeconds
        /// value of 1 or higher. To learn more about DATERANGE, see <a href="http://docs.aws.amazon.com/mediapackage/latest/ug/scte-35-ad-marker-ext-x-daterange.html">SCTE-35
        /// Ad Marker EXT-X-DATERANGE</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AdMarkerHls AdMarkerHls
        {
            get { return this._adMarkerHls; }
            set { this._adMarkerHls = value; }
        }

        // Check to see if AdMarkerHls property is set
        internal bool IsSetAdMarkerHls()
        {
            return this._adMarkerHls != null;
        }

    }
}