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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListFeatureGroups operation. List <c>FeatureGroup</c>s
    /// based on given filter and order.
    /// </summary>
    public partial class ListFeatureGroupsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Use this parameter to search for <c>FeatureGroups</c>s created after a specific date
        /// and time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// Use this parameter to search for <c>FeatureGroups</c>s created before a specific date
        /// and time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureGroupStatusEquals. 
        /// <para>
        /// A <c>FeatureGroup</c> status. Filters by <c>FeatureGroup</c> status. 
        /// </para>
        /// </summary>
        public FeatureGroupStatus FeatureGroupStatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the FeatureGroupStatusEquals property is set.
        /// </summary>
        internal bool IsSetFeatureGroupStatusEquals() => this.FeatureGroupStatusEquals != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c>ListFeatureGroups</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string that partially matches one or more <c>FeatureGroup</c>s names. Filters <c>FeatureGroup</c>s
        /// by name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to resume pagination of <c>ListFeatureGroups</c> results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OfflineStoreStatusEquals. 
        /// <para>
        /// An <c>OfflineStore</c> status. Filters by <c>OfflineStore</c> status. 
        /// </para>
        /// </summary>
        public OfflineStoreStatusValue OfflineStoreStatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the OfflineStoreStatusEquals property is set.
        /// </summary>
        internal bool IsSetOfflineStoreStatusEquals() => this.OfflineStoreStatusEquals != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value on which the feature group list is sorted.
        /// </para>
        /// </summary>
        public FeatureGroupSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which feature groups are listed.
        /// </para>
        /// </summary>
        public FeatureGroupSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
