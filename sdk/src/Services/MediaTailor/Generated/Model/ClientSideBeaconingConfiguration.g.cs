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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The beaconing settings that apply to client-side reporting sessions: whether MediaTailor
    /// includes its beacons in the ad tracking response, and which player operation events
    /// it reports on.
    /// </summary>
    public partial class ClientSideBeaconingConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdditionalEventTypes. 
        /// <para>
        /// The player operation events to report on, in addition to the ad progress events that
        /// MediaTailor always reports on. The default is an empty list. This parameter is valid
        /// only when <c>ReportingMode</c> is <c>INSIGHTS</c>. MediaTailor rejects the request
        /// if you specify a value while <c>ReportingMode</c> is <c>DISABLED</c>, or if you specify
        /// duplicate values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalEventTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalEventTypes property is set.
        /// </summary>
        internal bool IsSetAdditionalEventTypes() => this.AdditionalEventTypes != null && (this.AdditionalEventTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportingMode. 
        /// <para>
        /// Specifies whether MediaTailor includes its beacons in the ad tracking response. Valid
        /// values, which are case-sensitive:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INSIGHTS</c> – MediaTailor includes its beacons in the ad tracking response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – MediaTailor doesn't include its beacons in the ad tracking response.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you send a <c>ClientSide</c> object, this setting is required. If you omit <c>BeaconingConfiguration</c>
        /// or <c>ClientSide</c> entirely, MediaTailor uses <c>INSIGHTS</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>PutPlaybackConfiguration</c> replaces the whole playback configuration. To keep
        /// beaconing off, include <c>DISABLED</c> in every subsequent write.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientSideBeaconingMode ReportingMode { get; set; }

        /// <summary>
        /// Checks to see if the ReportingMode property is set.
        /// </summary>
        internal bool IsSetReportingMode() => this.ReportingMode != null;
    }
}
