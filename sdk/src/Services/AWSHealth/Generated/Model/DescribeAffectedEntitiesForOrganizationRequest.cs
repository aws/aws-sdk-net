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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAffectedEntitiesForOrganization operation.
    /// Returns a list of entities that have been affected by one or more events for one or
    /// more accounts in your organization in Organizations, based on the filter criteria.
    /// Entities can refer to individual customer resources, groups of customer resources,
    /// or any other construct, depending on the Amazon Web Services service.
    /// 
    ///  
    /// <para>
    /// At least one event Amazon Resource Name (ARN) and account ID are required.
    /// </para>
    ///  
    /// <para>
    /// Before you can call this operation, you must first enable Health to work with Organizations.
    /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
    /// operation from your organization's management account.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
    /// next request to return more results.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation doesn't support resource-level permissions. You can't use this operation
    /// to allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
    /// and action-based conditions</a> in the <i>Health User Guide</i>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DescribeAffectedEntitiesForOrganizationRequest : AmazonAWSHealthRequest
    {
        private string _locale;
        private int? _maxResults;
        private string _nextToken;
        private List<EntityAccountFilter> _organizationEntityAccountFilters = AWSConfigs.InitializeCollections ? new List<EntityAccountFilter>() : null;
        private List<EventAccountFilter> _organizationEntityFilters = AWSConfigs.InitializeCollections ? new List<EventAccountFilter>() : null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale (language) to return information in. English (en) is the default and the
        /// only supported value at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in one batch, between 10 and 100, inclusive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If the results of a search are large, only a portion of the results are returned,
        /// and a <c>nextToken</c> pagination token is returned in the response. To retrieve the
        /// next batch of results, reissue the search request and include the returned token.
        /// When all results have been returned, the response does not contain a pagination token
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
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
        /// Gets and sets the property OrganizationEntityAccountFilters. 
        /// <para>
        /// A JSON set of elements including the <c>awsAccountId</c>, <c>eventArn</c> and a set
        /// of <c>statusCodes</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EntityAccountFilter> OrganizationEntityAccountFilters
        {
            get { return this._organizationEntityAccountFilters; }
            set { this._organizationEntityAccountFilters = value; }
        }

        // Check to see if OrganizationEntityAccountFilters property is set
        internal bool IsSetOrganizationEntityAccountFilters()
        {
            return this._organizationEntityAccountFilters != null && (this._organizationEntityAccountFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationEntityFilters. 
        /// <para>
        /// A JSON set of elements including the <c>awsAccountId</c> and the <c>eventArn</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated, use organizationEntityAccountFilters instead.")]
        [AWSProperty(Min=1, Max=10)]
        public List<EventAccountFilter> OrganizationEntityFilters
        {
            get { return this._organizationEntityFilters; }
            set { this._organizationEntityFilters = value; }
        }

        // Check to see if OrganizationEntityFilters property is set
        internal bool IsSetOrganizationEntityFilters()
        {
            return this._organizationEntityFilters != null && (this._organizationEntityFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}