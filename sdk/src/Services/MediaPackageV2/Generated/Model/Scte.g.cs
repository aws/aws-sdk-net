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
    public partial class Scte
    {
        /// <summary>
        /// Gets and sets the property CustomAdTypes. 
        /// <para>
        /// A list of additional non-Ad SCTE-35 event types to treat as advertisements. When configured,
        /// events matching these types produce ad markers (such as <c>SCTE35-OUT</c> and <c>SCTE35-IN</c>
        /// in HLS DATERANGE tags) in manifests.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>PROGRAM</c> | <c>CHAPTER</c> | <c>UNSCHEDULED_EVENT</c> | <c>ALTERNATE_CONTENT_OPPORTUNITY</c>
        /// | <c>NETWORK</c> 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify any values, the default is empty (only default ad types are used).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public List<string> CustomAdTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomAdTypes property is set.
        /// </summary>
        internal bool IsSetCustomAdTypes() => this.CustomAdTypes != null && (this.CustomAdTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScteFilter. 
        /// <para>
        /// The SCTE-35 message types that you want to be treated as ad markers in the output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> ScteFilter { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScteFilter property is set.
        /// </summary>
        internal bool IsSetScteFilter() => this.ScteFilter != null && (this.ScteFilter.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScteInSegments. 
        /// <para>
        /// Controls whether SCTE-35 messages are included in segment files.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// None – SCTE-35 messages are not included in segments (default)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All – SCTE-35 messages are embedded in segment data
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MatchesFilter – SCTE-35 messages which match the ScteFilter are embedded in segment
        /// data
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For DASH manifests, when set to <c>All</c> or <c>MatchesFilter</c>, an <c>InbandEventStream</c>
        /// tag signals that SCTE messages are present in segments. This setting works independently
        /// of manifest ad markers.
        /// </para>
        /// </summary>
        public ScteInSegments ScteInSegments { get; set; }

        /// <summary>
        /// Checks to see if the ScteInSegments property is set.
        /// </summary>
        internal bool IsSetScteInSegments() => this.ScteInSegments != null;
    }
}
