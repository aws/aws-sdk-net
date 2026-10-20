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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Container for the parameters to the ListHarvestJobs operation. Returns a collection
    /// of HarvestJob records.
    /// </summary>
    public partial class ListHarvestJobsRequest : AmazonMediaPackageRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeChannelId. When specified, the request will return
        /// only HarvestJobs associated with the given Channel ID.
        /// </summary>
        public string IncludeChannelId { get; set; }

        /// <summary>
        /// Checks to see if the IncludeChannelId property is set.
        /// </summary>
        internal bool IsSetIncludeChannelId() => this.IncludeChannelId != null;

        /// <summary>
        /// Gets and sets the property IncludeStatus. When specified, the request will return
        /// only HarvestJobs in the given status.
        /// </summary>
        public string IncludeStatus { get; set; }

        /// <summary>
        /// Checks to see if the IncludeStatus property is set.
        /// </summary>
        internal bool IsSetIncludeStatus() => this.IncludeStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. The upper bound on the number of records to
        /// return.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. A token used to resume pagination from the end
        /// of a previous request.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
