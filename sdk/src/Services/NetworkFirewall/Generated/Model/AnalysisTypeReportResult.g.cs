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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The results of a <c>COMPLETED</c> analysis report generated with <a>StartAnalysisReport</a>.
    /// 
    ///  
    /// <para>
    /// For an example of traffic analysis report results, see the response syntax of <a>GetAnalysisReportResults</a>.
    /// </para>
    /// </summary>
    public partial class AnalysisTypeReportResult
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The most frequently accessed domains.
        /// </para>
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property FirstAccessed. 
        /// <para>
        /// The date and time any domain was first accessed (within the last 30 day period).
        /// </para>
        /// </summary>
        public DateTime? FirstAccessed { get; set; }

        /// <summary>
        /// Checks to see if the FirstAccessed property is set.
        /// </summary>
        internal bool IsSetFirstAccessed() => this.FirstAccessed.HasValue;

        /// <summary>
        /// Gets and sets the property Hits. 
        /// <para>
        /// The number of attempts made to access a observed domain.
        /// </para>
        /// </summary>
        public Hits Hits { get; set; }

        /// <summary>
        /// Checks to see if the Hits property is set.
        /// </summary>
        internal bool IsSetHits() => this.Hits != null;

        /// <summary>
        /// Gets and sets the property LastAccessed. 
        /// <para>
        /// The date and time any domain was last accessed (within the last 30 day period).
        /// </para>
        /// </summary>
        public DateTime? LastAccessed { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessed property is set.
        /// </summary>
        internal bool IsSetLastAccessed() => this.LastAccessed.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The type of traffic captured by the analysis report.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property UniqueSources. 
        /// <para>
        /// The number of unique source IP addresses that connected to a domain.
        /// </para>
        /// </summary>
        public UniqueSources UniqueSources { get; set; }

        /// <summary>
        /// Checks to see if the UniqueSources property is set.
        /// </summary>
        internal bool IsSetUniqueSources() => this.UniqueSources != null;
    }
}
