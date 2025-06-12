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
    /// This is the response object from the GetFindingsStatistics operation.
    /// </summary>
    public partial class GetFindingsStatisticsResponse : AmazonWebServiceResponse
    {
        private List<FindingsStatistics> _findingsStatistics = AWSConfigs.InitializeCollections ? new List<FindingsStatistics>() : null;
        private DateTime? _lastUpdatedAt;

        /// <summary>
        /// Gets and sets the property FindingsStatistics. 
        /// <para>
        /// A group of external access or unused access findings statistics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingsStatistics> FindingsStatistics
        {
            get { return this._findingsStatistics; }
            set { this._findingsStatistics = value; }
        }

        // Check to see if FindingsStatistics property is set
        internal bool IsSetFindingsStatistics()
        {
            return this._findingsStatistics != null && (this._findingsStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the retrieval of the findings statistics was last updated. If the
        /// findings statistics have not been previously retrieved for the specified analyzer,
        /// this field will not be populated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

    }
}