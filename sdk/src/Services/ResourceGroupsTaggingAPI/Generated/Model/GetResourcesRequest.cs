/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetResources operation.
    /// Returns all the tagged resources that are associated with the specified tags (keys
    /// and values) located in the specified region for the AWS account. The tags and the
    /// resource types that you specify in the request are known as <i>filters</i>. The response
    /// includes all tags that are associated with the requested resources. If no filter is
    /// provided, this action returns a paginated resource list with the associated tags.
    /// </summary>
    public partial class GetResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _paginationToken;
        private int? _resourcesPerPage;
        private List<string> _resourceTypeFilters = new List<string>();
        private List<TagFilter> _tagFilters = new List<TagFilter>();
        private int? _tagsPerPage;

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// A string that indicates that additional data is available. Leave this value empty
        /// for your initial request. If the response includes a <code>PaginationToken</code>,
        /// use that string for this value to request an additional page of data.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourcesPerPage. 
        /// <para>
        /// A limit that restricts the number of resources returned by GetResources in paginated
        /// output. You can set ResourcesPerPage to a minimum of 1 item and the maximum of 50
        /// items. 
        /// </para>
        /// </summary>
        public int ResourcesPerPage
        {
            get { return this._resourcesPerPage.GetValueOrDefault(); }
            set { this._resourcesPerPage = value; }
        }

        // Check to see if ResourcesPerPage property is set
        internal bool IsSetResourcesPerPage()
        {
            return this._resourcesPerPage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeFilters. 
        /// <para>
        /// The constraints on the resources that you want returned. The format of each resource
        /// type is <code>service[:resourceType]</code>. For example, specifying a resource type
        /// of <code>ec2</code> returns all tagged Amazon EC2 resources (which includes tagged
        /// EC2 instances). Specifying a resource type of <code>ec2:instance</code> returns only
        /// EC2 instances. 
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
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// A list of tags (keys and values). A request can include up to 50 keys, and each key
        /// can include up to 20 values.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple filters connected by an AND operator in a single request,
        /// the response returns only those resources that are associated with every specified
        /// filter.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple filters connected by an OR operator in a single request, the
        /// response returns all resources that are associated with at least one or possibly more
        /// of the specified filters.
        /// </para>
        /// </summary>
        public List<TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && this._tagFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagsPerPage. 
        /// <para>
        /// A limit that restricts the number of tags (key and value pairs) returned by GetResources
        /// in paginated output. A resource with no tags is counted as having one tag (one key
        /// and value pair).
        /// </para>
        ///  
        /// <para>
        ///  <code>GetResources</code> does not split a resource and its associated tags across
        /// pages. If the specified <code>TagsPerPage</code> would cause such a break, a <code>PaginationToken</code>
        /// is returned in place of the affected resource and its tags. Use that token in another
        /// request to get the remaining data. For example, if you specify a <code>TagsPerPage</code>
        /// of <code>100</code> and the account has 22 resources with 10 tags each (meaning that
        /// each resource has 10 key and value pairs), the output will consist of 3 pages, with
        /// the first page displaying the first 10 resources, each with its 10 tags, the second
        /// page displaying the next 10 resources each with its 10 tags, and the third page displaying
        /// the remaining 2 resources, each with its 10 tags.
        /// </para>
        ///   
        /// <para>
        /// You can set <code>TagsPerPage</code> to a minimum of 100 items and the maximum of
        /// 500 items.
        /// </para>
        /// </summary>
        public int TagsPerPage
        {
            get { return this._tagsPerPage.GetValueOrDefault(); }
            set { this._tagsPerPage = value; }
        }

        // Check to see if TagsPerPage property is set
        internal bool IsSetTagsPerPage()
        {
            return this._tagsPerPage.HasValue; 
        }

    }
}