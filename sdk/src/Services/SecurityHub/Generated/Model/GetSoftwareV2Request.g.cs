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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the GetSoftwareV2 operation. Returns a list of software
    /// packages installed on your resources. Each result identifies a package by name, version,
    /// and type, and includes the number of resources that contain that package. <para> You
    /// can use the <c>Scopes</c> parameter to define the data boundary for the query. Currently,
    /// <c>Scopes</c> supports <c>AwsOrganizations</c>, which lets you retrieve software from
    /// your entire organization or from specific organizational units. Only the delegated
    /// administrator account can use <c>Scopes</c>. </para> <para> You can use the <c>Filters</c>
    /// parameter to refine results based on package and resource attributes. You can use
    /// <c>Scopes</c> and <c>Filters</c> independently or together. When both are provided,
    /// <c>Scopes</c> narrows the data set first, and then <c>Filters</c> refines results
    /// within that scoped data set. </para> <para> To list the resources that contain a specific
    /// package, use <c>GetSoftwareResourcesV2</c>. To get counts of software grouped by a
    /// field, use <c>GetSoftwareStatisticsV2</c>. </para>
    /// </summary>
    public partial class GetSoftwareV2Request : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters software packages based on a set of criteria. You can nest composite filters
        /// up to three levels deep.
        /// </para>
        /// </summary>
        public SoftwareFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return. Valid values are 1–100. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token required for pagination. On your first call, set the value of this parameter
        /// to <c>NULL</c>. For subsequent calls, to continue listing data, set the value of this
        /// parameter to the value returned in the previous response.
        /// </para>
        ///  
        /// <para>
        /// A token expires one hour after it's issued. If you change <c>Filters</c> or <c>SortCriteria</c>
        /// between calls, the token is no longer valid and the request fails with a <c>ValidationException</c>.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// Limits the results to software on resources from specific organizational units or
        /// from the delegated administrator's organization. Only the delegated administrator
        /// account can use this parameter. Other accounts receive an <c>AccessDeniedException</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If you omit it, the delegated administrator sees software
        /// from all accounts across the entire organization. Other accounts see only software
        /// on their own resources.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 10 entries in <c>Scopes.AwsOrganizations</c>. If multiple entries
        /// are specified, the entries are combined using OR logic.
        /// </para>
        /// </summary>
        public SoftwareScopes Scopes { get; set; }

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null;

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The software attributes used to sort the list of returned software packages. You can't
        /// sort by <c>ResourceCount</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SortCriterion> SortCriteria { get; set; } = AWSConfigs.InitializeCollections ? new List<SortCriterion>() : null;

        /// <summary>
        /// Checks to see if the SortCriteria property is set.
        /// </summary>
        internal bool IsSetSortCriteria() => this.SortCriteria != null && (this.SortCriteria.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
