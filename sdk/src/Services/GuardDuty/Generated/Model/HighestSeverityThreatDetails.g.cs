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
    /// Contains details of the highest severity threat detected during scan and number of
    /// infected files.
    /// </summary>
    public partial class HighestSeverityThreatDetails
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// Total number of infected files with the highest severity threat detected.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Severity level of the highest severity threat detected.
        /// </para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property ThreatName. 
        /// <para>
        /// Threat name of the highest severity threat detected as part of the malware scan.
        /// </para>
        /// </summary>
        public string ThreatName { get; set; }

        /// <summary>
        /// Checks to see if the ThreatName property is set.
        /// </summary>
        internal bool IsSetThreatName() => this.ThreatName != null;
    }
}
