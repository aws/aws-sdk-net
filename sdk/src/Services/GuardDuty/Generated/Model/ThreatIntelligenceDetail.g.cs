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
    /// An instance of a threat intelligence detail that constitutes evidence for the finding.
    /// </summary>
    public partial class ThreatIntelligenceDetail
    {
        /// <summary>
        /// Gets and sets the property ThreatFileSha256. 
        /// <para>
        /// SHA256 of the file that generated the finding.
        /// </para>
        /// </summary>
        public string ThreatFileSha256 { get; set; }

        /// <summary>
        /// Checks to see if the ThreatFileSha256 property is set.
        /// </summary>
        internal bool IsSetThreatFileSha256() => this.ThreatFileSha256 != null;

        /// <summary>
        /// Gets and sets the property ThreatListName. 
        /// <para>
        /// The name of the threat intelligence list that triggered the finding.
        /// </para>
        /// </summary>
        public string ThreatListName { get; set; }

        /// <summary>
        /// Checks to see if the ThreatListName property is set.
        /// </summary>
        internal bool IsSetThreatListName() => this.ThreatListName != null;

        /// <summary>
        /// Gets and sets the property ThreatNames. 
        /// <para>
        /// A list of names of the threats in the threat intelligence list that triggered the
        /// finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ThreatNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ThreatNames property is set.
        /// </summary>
        internal bool IsSetThreatNames() => this.ThreatNames != null && (this.ThreatNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
