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
    /// Container for the parameters to the ListSpaces operation. Lists spaces.
    /// </summary>
    public partial class ListSpacesRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdEquals. 
        /// <para>
        /// A parameter to search for the domain ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DomainIdEquals { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdEquals property is set.
        /// </summary>
        internal bool IsSetDomainIdEquals() => this.DomainIdEquals != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This parameter defines the maximum number of results that can be return in a single
        /// response. The <c>MaxResults</c> parameter is an upper bound, not a target. If there
        /// are more results available than the value specified, a <c>NextToken</c> is provided
        /// in the response. The <c>NextToken</c> indicates that the user should get the next
        /// set of results by providing this token as a part of a subsequent call. The default
        /// value for <c>MaxResults</c> is 10.
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
        /// If the previous response was truncated, you will receive this token. Use it in your
        /// next request to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The parameter by which to sort the results. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public SpaceSortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. The default is <c>Ascending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property SpaceNameContains. 
        /// <para>
        /// A parameter by which to filter the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string SpaceNameContains { get; set; }

        /// <summary>
        /// Checks to see if the SpaceNameContains property is set.
        /// </summary>
        internal bool IsSetSpaceNameContains() => this.SpaceNameContains != null;
    }
}
