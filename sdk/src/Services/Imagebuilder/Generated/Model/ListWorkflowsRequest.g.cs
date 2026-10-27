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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkflows operation. Lists workflow versions
    /// based on filtering parameters. To list the build versions of a specific workflow version,
    /// call <a>ListWorkflowBuildVersions</a>.
    /// </summary>
    public partial class ListWorkflowsRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ByName. 
        /// <para>
        /// Specifies whether to return one entry per workflow name, with all versions of each
        /// workflow aggregated. Defaults to <c>false</c>, which returns one entry per workflow
        /// version. You can't combine this option with the <c>version</c> filter.
        /// </para>
        /// </summary>
        public bool? ByName { get; set; }

        /// <summary>
        /// Checks to see if the ByName property is set.
        /// </summary>
        internal bool IsSetByName() => this.ByName.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to narrow the list of workflows. You can filter on <c>name</c>, <c>version</c>,
        /// <c>description</c>, and <c>type</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. Use the <c>nextToken</c> value from
        /// a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Filters results based on the workflow owner. By default, this request returns the
        /// workflows that your account owns (<c>Self</c>). Specify <c>Amazon</c> to list the
        /// workflows that Image Builder manages. Image Builder rejects the <c>Shared</c> and
        /// <c>ThirdParty</c> owner values for workflows, and <c>AWSMarketplace</c> returns no
        /// results.
        /// </para>
        /// </summary>
        public Ownership Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;
    }
}
