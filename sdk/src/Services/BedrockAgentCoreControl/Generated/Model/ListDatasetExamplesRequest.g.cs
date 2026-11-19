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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the ListDatasetExamples operation. Returns paginated
    /// examples from the dataset. The server embeds the resolved version in the pagination
    /// token. Once pagination begins, all subsequent pages are pinned to that version regardless
    /// of concurrent mutations. A request with a pagination token can omit <c>datasetVersion</c>.
    /// If it sets a version that differs from the token's version, the request fails with
    /// a <c>ValidationException</c>.
    /// </summary>
    public partial class ListDatasetExamplesRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        ///  The unique identifier of the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        ///  Version to paginate: "DRAFT" or a version number. Defaults to DRAFT if absent on
        /// the first request. With a pagination token, the version comes from the token: you
        /// can omit this member, and a value that differs from the token's version is rejected
        /// with a <c>ValidationException</c>. 
        /// </para>
        /// </summary>
        public string DatasetVersion { get; set; }

        /// <summary>
        /// Checks to see if the DatasetVersion property is set.
        /// </summary>
        internal bool IsSetDatasetVersion() => this.DatasetVersion != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        ///  A filter to apply to the examples. 
        /// </para>
        /// </summary>
        public ListDatasetExamplesFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  Maximum number of examples to return per page. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next page of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
