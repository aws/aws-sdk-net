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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Defines the structure for multi-Region cluster configurations, containing the witness
    /// region and linked cluster settings.
    /// </summary>
    public partial class MultiRegionProperties
    {
        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// The set of peered clusters that form the multi-Region cluster configuration. Each
        /// peered cluster represents a database instance in a different Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Clusters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Clusters property is set.
        /// </summary>
        internal bool IsSetClusters() => this.Clusters != null && (this.Clusters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WitnessRegion. 
        /// <para>
        /// The Region that serves as the witness region for a multi-Region cluster. The witness
        /// Region helps maintain cluster consistency and quorum.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 50)]
        public string WitnessRegion { get; set; }

        /// <summary>
        /// Checks to see if the WitnessRegion property is set.
        /// </summary>
        internal bool IsSetWitnessRegion() => this.WitnessRegion != null;
    }
}
