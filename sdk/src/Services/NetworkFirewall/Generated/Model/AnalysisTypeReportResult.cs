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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
        private string _domain;
        private DateTime? _firstAccessed;
        private Hits _hits;
        private DateTime? _lastAccessed;
        private string _protocol;
        private UniqueSources _uniqueSources;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The most frequently accessed domains.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property FirstAccessed. 
        /// <para>
        /// The date and time any domain was first accessed (within the last 30 day period).
        /// </para>
        /// </summary>
        public DateTime? FirstAccessed
        {
            get { return this._firstAccessed; }
            set { this._firstAccessed = value; }
        }

        // Check to see if FirstAccessed property is set
        internal bool IsSetFirstAccessed()
        {
            return this._firstAccessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hits. 
        /// <para>
        /// The number of attempts made to access a observed domain.
        /// </para>
        /// </summary>
        public Hits Hits
        {
            get { return this._hits; }
            set { this._hits = value; }
        }

        // Check to see if Hits property is set
        internal bool IsSetHits()
        {
            return this._hits != null;
        }

        /// <summary>
        /// Gets and sets the property LastAccessed. 
        /// <para>
        /// The date and time any domain was last accessed (within the last 30 day period).
        /// </para>
        /// </summary>
        public DateTime? LastAccessed
        {
            get { return this._lastAccessed; }
            set { this._lastAccessed = value; }
        }

        // Check to see if LastAccessed property is set
        internal bool IsSetLastAccessed()
        {
            return this._lastAccessed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The type of traffic captured by the analysis report.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueSources. 
        /// <para>
        /// The number of unique source IP addresses that connected to a domain.
        /// </para>
        /// </summary>
        public UniqueSources UniqueSources
        {
            get { return this._uniqueSources; }
            set { this._uniqueSources = value; }
        }

        // Check to see if UniqueSources property is set
        internal bool IsSetUniqueSources()
        {
            return this._uniqueSources != null;
        }

    }
}