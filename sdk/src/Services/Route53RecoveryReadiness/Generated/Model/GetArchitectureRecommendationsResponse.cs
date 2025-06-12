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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetArchitectureRecommendations operation.
    /// </summary>
    public partial class GetArchitectureRecommendationsResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastAuditTimestamp;
        private string _nextToken;
        private List<Recommendation> _recommendations = AWSConfigs.InitializeCollections ? new List<Recommendation>() : null;

        /// <summary>
        /// Gets and sets the property LastAuditTimestamp. 
        /// <para>
        /// The time that a recovery group was last assessed for recommendations, in UTC ISO-8601
        /// format.
        /// </para>
        /// </summary>
        public DateTime? LastAuditTimestamp
        {
            get { return this._lastAuditTimestamp; }
            set { this._lastAuditTimestamp = value; }
        }

        // Check to see if LastAuditTimestamp property is set
        internal bool IsSetLastAuditTimestamp()
        {
            return this._lastAuditTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results you want to see.
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

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// A list of the recommendations for the customer's application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Recommendation> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && (this._recommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}