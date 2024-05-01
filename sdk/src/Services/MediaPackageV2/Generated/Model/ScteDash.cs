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
    public partial class ScteDash
    {
        private AdMarkerDash _adMarkerDash;

        /// <summary>
        /// Gets and sets the property AdMarkerDash. 
        /// <para>
        /// Choose how ad markers are included in the packaged content. If you include ad markers
        /// in the content stream in your upstream encoders, then you need to inform MediaPackage
        /// what to do with the ad markers in the output.
        /// </para>
        ///  
        /// <para>
        /// Value description:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Binary</c> - The SCTE-35 marker is expressed as a hex-string (Base64 string) rather
        /// than full XML.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XML</c> - The SCTE marker is expressed fully in XML.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AdMarkerDash AdMarkerDash
        {
            get { return this._adMarkerDash; }
            set { this._adMarkerDash = value; }
        }

        // Check to see if AdMarkerDash property is set
        internal bool IsSetAdMarkerDash()
        {
            return this._adMarkerDash != null;
        }

    }
}