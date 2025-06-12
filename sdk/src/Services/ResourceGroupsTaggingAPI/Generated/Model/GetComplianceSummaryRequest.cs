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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetComplianceSummary operation.
    /// Returns a table that shows counts of resources that are noncompliant with their tag
    /// policies.
    /// 
    ///  
    /// <para>
    /// For more information on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
    /// Policies</a> in the <i>Organizations User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can call this operation only from the organization's management account and from
    /// the us-east-1 Region.
    /// </para>
    ///  
    /// <para>
    /// This operation supports pagination, where the response can be sent in multiple pages.
    /// You should check the <c>PaginationToken</c> response parameter to determine if there
    /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
    /// response parameter value as an input to the next request until you recieve a <c>null</c>
    /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
    /// waiting to be returned.
    /// </para>
    /// </summary>
    public partial class GetComplianceSummaryRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private List<string> _groupBy = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _paginationToken;
        private List<string> _regionFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resourceTypeFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tagKeyFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _targetIdFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// Specifies a list of attributes to group the counts of noncompliant resources by. If
        /// supplied, the counts are sorted by those attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && (this._groupBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of results to be returned in each page. A query can return
        /// fewer than this maximum, even if there are more results still to return. You should
        /// always check the <c>PaginationToken</c> response value to see if there are more results.
        /// You can specify a minimum of 1 and a maximum value of 100.
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
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// Specifies a <c>PaginationToken</c> response value from a previous request to indicate
        /// that you want the next page of results. Leave this parameter empty in your initial
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegionFilters. 
        /// <para>
        /// Specifies a list of Amazon Web Services Regions to limit the output to. If you use
        /// this parameter, the count of returned noncompliant resources includes only resources
        /// in the specified Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> RegionFilters
        {
            get { return this._regionFilters; }
            set { this._regionFilters = value; }
        }

        // Check to see if RegionFilters property is set
        internal bool IsSetRegionFilters()
        {
            return this._regionFilters != null && (this._regionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeFilters. 
        /// <para>
        /// Specifies that you want the response to include information for only resources of
        /// the specified types. The format of each resource type is <c>service[:resourceType]</c>.
        /// For example, specifying a resource type of <c>ec2</c> returns all Amazon EC2 resources
        /// (which includes EC2 instances). Specifying a resource type of <c>ec2:instance</c>
        /// returns only EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// The string for each service name and resource type is the same as that embedded in
        /// a resource's Amazon Resource Name (ARN). Consult the <i> <a href="https://docs.aws.amazon.com/general/latest/gr/">Amazon
        /// Web Services General Reference</a> </i> for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a list of service name strings, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services Service Namespaces</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resource type strings, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arns-syntax">Example
        /// ARNs</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify multiple resource types by using a comma separated array. The array
        /// can include up to 100 items. Note that the length constraint requirement applies to
        /// each resource type filter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResourceTypeFilters
        {
            get { return this._resourceTypeFilters; }
            set { this._resourceTypeFilters = value; }
        }

        // Check to see if ResourceTypeFilters property is set
        internal bool IsSetResourceTypeFilters()
        {
            return this._resourceTypeFilters != null && (this._resourceTypeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagKeyFilters. 
        /// <para>
        /// Specifies that you want the response to include information for only resources that
        /// have tags with the specified tag keys. If you use this parameter, the count of returned
        /// noncompliant resources includes only resources that have the specified tag keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> TagKeyFilters
        {
            get { return this._tagKeyFilters; }
            set { this._tagKeyFilters = value; }
        }

        // Check to see if TagKeyFilters property is set
        internal bool IsSetTagKeyFilters()
        {
            return this._tagKeyFilters != null && (this._tagKeyFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetIdFilters. 
        /// <para>
        /// Specifies target identifiers (usually, specific account IDs) to limit the output by.
        /// If you use this parameter, the count of returned noncompliant resources includes only
        /// resources with the specified target IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> TargetIdFilters
        {
            get { return this._targetIdFilters; }
            set { this._targetIdFilters = value; }
        }

        // Check to see if TargetIdFilters property is set
        internal bool IsSetTargetIdFilters()
        {
            return this._targetIdFilters != null && (this._targetIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}