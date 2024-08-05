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
    /// Container for the parameters to the ListControlDomainInsights operation.
    /// Lists the latest analytics data for control domains across all of your active assessments.
    /// 
    /// 
    ///  
    /// <para>
    /// Audit Manager supports the control domains that are provided by Amazon Web Services
    /// Control Catalog. For information about how to find a list of available control domains,
    /// see <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_ListDomains.html">
    /// <c>ListDomains</c> </a> in the Amazon Web Services Control Catalog API Reference.
    /// </para>
    ///  <note> 
    /// <para>
    /// A control domain is listed only if at least one of the controls within that domain
    /// collected evidence on the <c>lastUpdated</c> date of <c>controlDomainInsights</c>.
    /// If this condition isn’t met, no data is listed for that control domain.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListControlDomainInsightsRequest : AmazonAuditManagerRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Represents the maximum number of results on a page or for an API request call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
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