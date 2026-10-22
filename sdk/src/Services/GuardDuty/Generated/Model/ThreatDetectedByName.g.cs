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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about identified threats organized by threat name.
    /// </summary>
    public partial class ThreatDetectedByName
    {
        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// Total number of infected files identified.
        /// </para>
        /// </summary>
        public int? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property Shortened. 
        /// <para>
        /// Flag to determine if the finding contains every single infected file-path and/or every
        /// threat.
        /// </para>
        /// </summary>
        public bool? Shortened { get; set; }

        /// <summary>
        /// Checks to see if the Shortened property is set.
        /// </summary>
        internal bool IsSetShortened() => this.Shortened.HasValue;

        /// <summary>
        /// Gets and sets the property ThreatNames. 
        /// <para>
        /// List of identified threats with details, organized by threat name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScanThreatName> ThreatNames { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanThreatName>() : null;

        /// <summary>
        /// Checks to see if the ThreatNames property is set.
        /// </summary>
        internal bool IsSetThreatNames() => this.ThreatNames != null && (this.ThreatNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UniqueThreatNameCount. 
        /// <para>
        /// Total number of unique threats by name identified, as part of the malware scan.
        /// </para>
        /// </summary>
        public int? UniqueThreatNameCount { get; set; }

        /// <summary>
        /// Checks to see if the UniqueThreatNameCount property is set.
        /// </summary>
        internal bool IsSetUniqueThreatNameCount() => this.UniqueThreatNameCount.HasValue;
    }
}
