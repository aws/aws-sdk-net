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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the ListEngagementGroups operation. Lists the active,
    /// fully curated AWS Partner Central engagement groups that are available to you in the
    /// specified catalog. An engagement group is a curated set of engagements that share
    /// common characteristics, such as customer geography, industry, or solution category.
    /// To retrieve the engagements in a group, pass the group <c>Id</c> to <c>SearchEngagements</c>
    /// as <c>GroupId</c>, and use <c>NextToken</c> to retrieve additional pages of groups.
    /// </summary>
    public partial class ListEngagementGroupsRequest : AmazonPartnerCentralSellingRequest
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which to list engagement groups. The following values are
        /// valid:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c>: Production.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Sandbox</c>: Testing environments.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property EngagementGroupIdentifiers. 
        /// <para>
        /// Filters the results to the specified engagement groups. Each entry can be an engagement
        /// group identifier or an engagement group ARN. You can specify 1 to 10 entries. Identifiers
        /// that don't match an active group available to you are ignored.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> EngagementGroupIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EngagementGroupIdentifiers property is set.
        /// </summary>
        internal bool IsSetEngagementGroupIdentifiers() => this.EngagementGroupIdentifiers != null && (this.EngagementGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of results to return in a single call. If you omit this
        /// value, the operation returns up to 20 results. Use this value to control pagination
        /// together with <c>NextToken</c>.
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
        /// A pagination token returned by a previous call. Pass it in a subsequent call to retrieve
        /// the next page of results. Omit it on the first call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ReadinessLevel. 
        /// <para>
        /// Filters the results to engagement groups with the specified readiness level. If you
        /// omit this field, the operation returns groups of all readiness levels.
        /// </para>
        /// </summary>
        public ReadinessLevel ReadinessLevel { get; set; }

        /// <summary>
        /// Checks to see if the ReadinessLevel property is set.
        /// </summary>
        internal bool IsSetReadinessLevel() => this.ReadinessLevel != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// Specifies the field and direction used to sort the results. You can sort by <c>Count</c>
        /// or <c>UpdatedAt</c>. If you omit this field, the operation returns groups in recommended
        /// order.
        /// </para>
        /// </summary>
        public EngagementGroupSort Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
