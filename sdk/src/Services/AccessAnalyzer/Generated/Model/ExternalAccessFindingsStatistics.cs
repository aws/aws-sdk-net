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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Provides aggregate statistics about the findings for the specified external access
    /// analyzer.
    /// </summary>
    public partial class ExternalAccessFindingsStatistics
    {
        private Dictionary<string, ResourceTypeDetails> _resourceTypeStatistics = AWSConfigs.InitializeCollections ? new Dictionary<string, ResourceTypeDetails>() : null;
        private int? _totalActiveFindings;
        private int? _totalArchivedFindings;
        private int? _totalResolvedFindings;

        /// <summary>
        /// Gets and sets the property ResourceTypeStatistics. 
        /// <para>
        /// The total number of active cross-account and public findings for each resource type
        /// of the specified external access analyzer.
        /// </para>
        /// </summary>
        public Dictionary<string, ResourceTypeDetails> ResourceTypeStatistics
        {
            get { return this._resourceTypeStatistics; }
            set { this._resourceTypeStatistics = value; }
        }

        // Check to see if ResourceTypeStatistics property is set
        internal bool IsSetResourceTypeStatistics()
        {
            return this._resourceTypeStatistics != null && (this._resourceTypeStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalActiveFindings. 
        /// <para>
        /// The number of active findings for the specified external access analyzer.
        /// </para>
        /// </summary>
        public int? TotalActiveFindings
        {
            get { return this._totalActiveFindings; }
            set { this._totalActiveFindings = value; }
        }

        // Check to see if TotalActiveFindings property is set
        internal bool IsSetTotalActiveFindings()
        {
            return this._totalActiveFindings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalArchivedFindings. 
        /// <para>
        /// The number of archived findings for the specified external access analyzer.
        /// </para>
        /// </summary>
        public int? TotalArchivedFindings
        {
            get { return this._totalArchivedFindings; }
            set { this._totalArchivedFindings = value; }
        }

        // Check to see if TotalArchivedFindings property is set
        internal bool IsSetTotalArchivedFindings()
        {
            return this._totalArchivedFindings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResolvedFindings. 
        /// <para>
        /// The number of resolved findings for the specified external access analyzer.
        /// </para>
        /// </summary>
        public int? TotalResolvedFindings
        {
            get { return this._totalResolvedFindings; }
            set { this._totalResolvedFindings = value; }
        }

        // Check to see if TotalResolvedFindings property is set
        internal bool IsSetTotalResolvedFindings()
        {
            return this._totalResolvedFindings.HasValue; 
        }

    }
}