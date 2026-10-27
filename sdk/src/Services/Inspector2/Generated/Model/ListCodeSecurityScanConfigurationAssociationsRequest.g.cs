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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the ListCodeSecurityScanConfigurationAssociations
    /// operation. Lists the associations between code repositories and Amazon Inspector code
    /// security scan configurations.
    /// </summary>
    public partial class ListCodeSecurityScanConfigurationAssociationsRequest : AmazonInspector2Request
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If your request would return
        /// more than the maximum the response will return a <c>nextToken</c> value, use this
        /// value when you call the action again to get the remaining results.
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
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the <c>NextToken</c> value returned from the previous request to continue listing
        /// results after the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scan configuration to list associations for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfigurationArn property is set.
        /// </summary>
        internal bool IsSetScanConfigurationArn() => this.ScanConfigurationArn != null;
    }
}
