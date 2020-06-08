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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetResources operation.
    /// Returns all the tagged or previously tagged resources that are located in the specified
    /// Region for the AWS account.
    /// 
    ///  
    /// <para>
    /// Depending on what information you want returned, you can also specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
    /// includes all tags that are associated with the requested resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Information about compliance with the account's effective tag policy. For more information
    /// on tag policies, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
    /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// You can check the <code>PaginationToken</code> response parameter to determine if
    /// a query is complete. Queries occasionally return fewer results on a page than allowed.
    /// The <code>PaginationToken</code> response parameter value is <code>null</code> <i>only</i>
    /// when there are no more results to display. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private bool? _excludeCompliantResources;
        private bool? _includeComplianceDetails;
        private string _paginationToken;
        private int? _resourcesPerPage;
        private List<string> _resourceTypeFilters = new List<string>();
        private List<TagFilter> _tagFilters = new List<TagFilter>();
        private int? _tagsPerPage;

        /// <summary>
        /// Gets and sets the property ExcludeCompliantResources. 
        /// <para>
        /// Specifies whether to exclude resources that are compliant with the tag policy. Set
        /// this to <code>true</code> if you are interested in retrieving information on noncompliant
        /// resources only.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only if the <code>IncludeComplianceDetails</code> parameter
        /// is also set to <code>true</code>.
        /// </para>
        /// </summary>
        public bool ExcludeCompliantResources
        {
            get { return this._excludeCompliantResources.GetValueOrDefault(); }
            set { this._excludeCompliantResources = value; }
        }

        // Check to see if ExcludeCompliantResources property is set
        internal bool IsSetExcludeCompliantResources()
        {
            return this._excludeCompliantResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeComplianceDetails. 
        /// <para>
        /// Specifies whether to include details regarding the compliance with the effective tag
        /// policy. Set this to <code>true</code> to determine whether resources are compliant
        /// with the tag policy and to get details.
        /// </para>
        /// </summary>
        public bool IncludeComplianceDetails
        {
            get { return this._includeComplianceDetails.GetValueOrDefault(); }
            set { this._includeComplianceDetails = value; }
        }

        // Check to see if IncludeComplianceDetails property is set
        internal bool IsSetIncludeComplianceDetails()
        {
            return this._includeComplianceDetails.HasValue; 
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
        /// Gets and sets the property ResourcesPerPage. 
        /// <para>
        /// A limit that restricts the number of resources returned by GetResources in paginated
        /// output. You can set ResourcesPerPage to a minimum of 1 item and the maximum of 100
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
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// A list of TagFilters (keys and values). Each TagFilter specified must contain a key
        /// with values as optional. A request can include up to 50 keys, and each key can include
        /// up to 20 values. 
        /// </para>
        ///  
        /// <para>
        /// Note the following when deciding how to use TagFilters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you <i>do</i> specify a TagFilter, the response returns only those resources that
        /// are currently associated with the specified tag. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you <i>don't</i> specify a TagFilter, the response includes all resources that
        /// were ever associated with tags. Resources that currently don't have associated tags
        /// are shown with an empty tag set, like this: <code>"Tags": []</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify more than one filter in a single request, the response returns only
        /// those resources that satisfy all specified filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter that contains more than one value for a key, the response
        /// returns resources that match any of the specified values for that key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify any values for a key, the response returns resources that are
        /// tagged with that key irrespective of the value.
        /// </para>
        ///  
        /// <para>
        /// For example, for filters: filter1 = {key1, {value1}}, filter2 = {key2, {value2,value3,value4}}
        /// , filter3 = {key3}:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// GetResources( {filter1} ) returns resources tagged with key1=value1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GetResources( {filter2} ) returns resources tagged with key2=value2 or key2=value3
        /// or key2=value4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GetResources( {filter3} ) returns resources tagged with any tag containing key3 as
        /// its tag key, irrespective of its value
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GetResources( {filter1,filter2,filter3} ) returns resources tagged with ( key1=value1)
        /// and ( key2=value2 or key2=value3 or key2=value4) and (key3, irrespective of the value)
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// AWS recommends using <code>ResourcesPerPage</code> instead of this parameter.
        /// </para>
        ///  
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
        /// each resource has 10 key and value pairs), the output will consist of three pages.
        /// The first page displays the first 10 resources, each with its 10 tags. The second
        /// page displays the next 10 resources, each with its 10 tags. The third page displays
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