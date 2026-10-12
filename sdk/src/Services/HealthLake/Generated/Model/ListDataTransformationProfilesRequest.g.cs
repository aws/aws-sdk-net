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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Container for the parameters to the ListDataTransformationProfiles operation. Lists
    /// all data transformation profiles in your account, returning the latest version summary
    /// for each. Use <c>GetDataTransformationProfile</c> to retrieve profile content. Results
    /// are paginated. Use the <c>NextToken</c> parameter to retrieve additional results.
    /// </summary>
    public partial class ListDataTransformationProfilesRequest : AmazonHealthLakeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of profiles to return per page. If you don't specify a value, the
        /// service returns up to 100 results.
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
        /// The pagination token from a previous response. Pass this value to retrieve the next
        /// page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// Filters the results by source data format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFormat SourceFormat { get; set; }

        /// <summary>
        /// Checks to see if the SourceFormat property is set.
        /// </summary>
        internal bool IsSetSourceFormat() => this.SourceFormat != null;
    }
}
