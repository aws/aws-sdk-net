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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// This is the response object from the ListAnomalousLogGroups operation.
    /// </summary>
    public partial class ListAnomalousLogGroupsResponse : AmazonWebServiceResponse
    {
        private List<AnomalousLogGroup> _anomalousLogGroups = AWSConfigs.InitializeCollections ? new List<AnomalousLogGroup>() : null;
        private string _insightId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AnomalousLogGroups. 
        /// <para>
        ///  The list of Amazon CloudWatch log groups that are related to an insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AnomalousLogGroup> AnomalousLogGroups
        {
            get { return this._anomalousLogGroups; }
            set { this._anomalousLogGroups = value; }
        }

        // Check to see if AnomalousLogGroups property is set
        internal bool IsSetAnomalousLogGroups()
        {
            return this._anomalousLogGroups != null && (this._anomalousLogGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        ///  The ID of the insight containing the log groups. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InsightId
        {
            get { return this._insightId; }
            set { this._insightId = value; }
        }

        // Check to see if InsightId property is set
        internal bool IsSetInsightId()
        {
            return this._insightId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If there are no more pages, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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