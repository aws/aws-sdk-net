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

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetComplianceSummary operation.
    /// Returns a table that shows counts of resources that are noncompliant with their tag
    /// policies.
    /// 
    ///  
    /// <para>
    /// For more information on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
    /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can call this operation only from the organization's master account and from the
    /// us-east-1 Region.
    /// </para>
    /// </summary>
    public partial class GetComplianceSummaryRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private List<string> _groupBy = new List<string>();
        private int? _maxResults;
        private string _paginationToken;
        private List<string> _regionFilters = new List<string>();
        private List<string> _resourceTypeFilters = new List<string>();
        private List<string> _tagKeyFilters = new List<string>();
        private List<string> _targetIdFilters = new List<string>();

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// A list of attributes to group the counts of noncompliant resources by. If supplied,
        /// the counts are sorted by those attributes.
        /// </para>
        /// </summary>
        public List<string> GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null && this._groupBy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// A limit that restricts the number of results that are returned per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// A string that indicates that additional data is available. Leave this value empty
        /// for your initial request. If the response includes a <code>PaginationToken</code>,
        /// use that string for this value to request an additional page of data.
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
        /// A list of Regions to limit the output by. If you use this parameter, the count of
        /// returned noncompliant resources includes only resources in the specified Regions.
        /// </para>
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
            return this._regionFilters != null && this._regionFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeFilters. 
        /// <para>
        /// The constraints on the resources that you want returned. The format of each resource
        /// type is <code>service[:resourceType]</code>. For example, specifying a resource type
        /// of <code>ec2</code> returns all Amazon EC2 resources (which includes EC2 instances).
        /// Specifying a resource type of <code>ec2:instance</code> returns only EC2 instances.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The string for each service name and resource type is the same as that embedded in
        /// a resource's Amazon Resource Name (ARN). Consult the <i>AWS General Reference</i>
        /// for the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a list of service name strings, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For resource type strings, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arns-syntax">Example
        /// ARNs</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify multiple resource types by using an array. The array can include up
        /// to 100 items. Note that the length constraint requirement applies to each resource
        /// type filter. 
        /// </para>
        /// </summary>
        public List<string> ResourceTypeFilters
        {
            get { return this._resourceTypeFilters; }
            set { this._resourceTypeFilters = value; }
        }

        // Check to see if ResourceTypeFilters property is set
        internal bool IsSetResourceTypeFilters()
        {
            return this._resourceTypeFilters != null && this._resourceTypeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagKeyFilters. 
        /// <para>
        /// A list of tag keys to limit the output by. If you use this parameter, the count of
        /// returned noncompliant resources includes only resources that have the specified tag
        /// keys.
        /// </para>
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
            return this._tagKeyFilters != null && this._tagKeyFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetIdFilters. 
        /// <para>
        /// The target identifiers (usually, specific account IDs) to limit the output by. If
        /// you use this parameter, the count of returned noncompliant resources includes only
        /// resources with the specified target IDs.
        /// </para>
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
            return this._targetIdFilters != null && this._targetIdFilters.Count > 0; 
        }

    }
}