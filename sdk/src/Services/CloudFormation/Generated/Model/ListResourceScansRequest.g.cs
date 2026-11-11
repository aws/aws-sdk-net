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
    /// Container for the parameters to the ListResourceScans operation. List the resource
    /// scans from newest to oldest. By default it will return up to 10 resource scans.
    /// </summary>
    public partial class ListResourceScansRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// If the number of available results exceeds this maximum, the response includes a <c>NextToken</c>
        /// value that you can use for the <c>NextToken</c> parameter to get the next set of results.
        /// The default value is 10. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ScanTypeFilter. 
        /// <para>
        /// The scan type that you want to get summary information about. The default is <c>FULL</c>.
        /// </para>
        /// </summary>
        public ScanType ScanTypeFilter { get; set; }

        /// <summary>
        /// Checks to see if the ScanTypeFilter property is set.
        /// </summary>
        internal bool IsSetScanTypeFilter() => this.ScanTypeFilter != null;
    }
}
