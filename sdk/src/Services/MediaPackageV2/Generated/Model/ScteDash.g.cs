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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public AdMarkerDash AdMarkerDash { get; set; }

        /// <summary>
        /// Checks to see if the AdMarkerDash property is set.
        /// </summary>
        internal bool IsSetAdMarkerDash() => this.AdMarkerDash != null;

        /// <summary>
        /// Gets and sets the property ScteInManifests. 
        /// <para>
        /// Controls which SCTE-35 events appear in DASH manifests. <c>ALL</c> includes all non-implicit
        /// SCTE-35 events. <c>MATCHES_FILTER</c> includes only events whose type matches the
        /// configured <c>ScteFilter</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value, the default is <c>ALL</c>.
        /// </para>
        /// </summary>
        public ScteInManifests ScteInManifests { get; set; }

        /// <summary>
        /// Checks to see if the ScteInManifests property is set.
        /// </summary>
        internal bool IsSetScteInManifests() => this.ScteInManifests != null;
    }
}
