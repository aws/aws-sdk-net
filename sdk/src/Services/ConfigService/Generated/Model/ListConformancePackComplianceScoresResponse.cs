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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the ListConformancePackComplianceScores operation.
    /// </summary>
    public partial class ListConformancePackComplianceScoresResponse : AmazonWebServiceResponse
    {
        private List<ConformancePackComplianceScore> _conformancePackComplianceScores = AWSConfigs.InitializeCollections ? new List<ConformancePackComplianceScore>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConformancePackComplianceScores. 
        /// <para>
        /// A list of <c>ConformancePackComplianceScore</c> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConformancePackComplianceScore> ConformancePackComplianceScores
        {
            get { return this._conformancePackComplianceScores; }
            set { this._conformancePackComplianceScores = value; }
        }

        // Check to see if ConformancePackComplianceScores property is set
        internal bool IsSetConformancePackComplianceScores()
        {
            return this._conformancePackComplianceScores != null && (this._conformancePackComplianceScores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string that you can use to get the next page of results in a
        /// paginated response.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}