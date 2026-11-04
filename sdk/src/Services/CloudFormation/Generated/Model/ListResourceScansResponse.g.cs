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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the ListResourceScans operation.
    /// </summary>
    public partial class ListResourceScansResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the request doesn't return all the remaining results, <c>NextToken</c> is set to
        /// a token. To retrieve the next set of results, call <c>ListResourceScans</c> again
        /// and use that value for the <c>NextToken</c> parameter. If the request returns all
        /// results, <c>NextToken</c> is set to an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceScanSummaries. 
        /// <para>
        /// The list of scans returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceScanSummary> ResourceScanSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceScanSummary>() : null;

        /// <summary>
        /// Checks to see if the ResourceScanSummaries property is set.
        /// </summary>
        internal bool IsSetResourceScanSummaries() => this.ResourceScanSummaries != null && (this.ResourceScanSummaries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
