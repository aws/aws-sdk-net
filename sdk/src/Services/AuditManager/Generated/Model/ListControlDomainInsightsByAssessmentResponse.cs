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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the ListControlDomainInsightsByAssessment operation.
    /// </summary>
    public partial class ListControlDomainInsightsByAssessmentResponse : AmazonWebServiceResponse
    {
        private List<ControlDomainInsights> _controlDomainInsights = AWSConfigs.InitializeCollections ? new List<ControlDomainInsights>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ControlDomainInsights. 
        /// <para>
        /// The control domain analytics data that the <c>ListControlDomainInsightsByAssessment</c>
        /// API returned. 
        /// </para>
        /// </summary>
        public List<ControlDomainInsights> ControlDomainInsights
        {
            get { return this._controlDomainInsights; }
            set { this._controlDomainInsights = value; }
        }

        // Check to see if ControlDomainInsights property is set
        internal bool IsSetControlDomainInsights()
        {
            return this._controlDomainInsights != null && (this._controlDomainInsights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used to fetch the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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