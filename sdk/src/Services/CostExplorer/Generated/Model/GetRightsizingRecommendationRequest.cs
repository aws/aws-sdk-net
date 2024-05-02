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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetRightsizingRecommendation operation.
    /// Creates recommendations that help you save cost by identifying idle and underutilized
    /// Amazon EC2 instances.
    /// 
    ///  
    /// <para>
    /// Recommendations are generated to either downsize or terminate instances, along with
    /// providing savings detail and metrics. For more information about calculation and function,
    /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/ce-rightsizing.html">Optimizing
    /// Your Cost with Rightsizing Recommendations</a> in the <i>Billing and Cost Management
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetRightsizingRecommendationRequest : AmazonCostExplorerRequest
    {
        private RightsizingRecommendationConfiguration _configuration;
        private Expression _filter;
        private string _nextPageToken;
        private int? _pageSize;
        private string _service;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// You can use Configuration to customize recommendations across two attributes. You
        /// can choose to view recommendations for instances within the same instance families
        /// or across different instance families. You can also choose to view your estimated
        /// savings that are associated with recommendations with consideration of existing Savings
        /// Plans or RI benefits, or neither. 
        /// </para>
        /// </summary>
        public RightsizingRecommendationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The pagination token that indicates the next set of results that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The specific service that you want recommendations for. The only valid value for <c>GetRightsizingRecommendation</c>
        /// is "<c>AmazonEC2</c>".
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}