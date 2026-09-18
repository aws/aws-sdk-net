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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Specifies the time or distance limits used to calculate reachable areas. You can provide
    /// up to five thresholds for a single type to generate multiple isolines in a single
    /// request. For example, you might request areas reachable within 5, 10, and 15 minutes,
    /// or within 1, 2, and 5 kilometers.
    /// </summary>
    public partial class IsolineThresholds
    {
        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// List of travel distances in meters. For example, [1000, 2000, 5000] would calculate
        /// areas reachable within 1, 2, and 5 kilometers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<long> Distance { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance != null && (this.Distance.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// List of travel times in seconds. For example, [300, 600, 900] would calculate areas
        /// reachable within 5, 10, and 15 minutes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<long> Time { get; set; } = AWSConfigs.InitializeCollections ? new List<long>() : null;

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null && (this.Time.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
