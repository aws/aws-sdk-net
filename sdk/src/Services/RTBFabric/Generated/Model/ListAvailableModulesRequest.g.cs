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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Container for the parameters to the ListAvailableModules operation. Lists the modules
    /// that you can attach, newest first by <c>createdAt</c>. Results are paginated. Use
    /// <c>nextToken</c> to get the next page.
    /// </summary>
    public partial class ListAvailableModulesRequest : AmazonRTBFabricRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results for each page, from 1 to 10. The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If nextToken is returned, there are more results available. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// Each pagination token expires after 24 hours; using an expired token fails with ValidationException.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SubscriptionType. 
        /// <para>
        /// Lists only modules that you have access to this way.
        /// </para>
        /// </summary>
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionType property is set.
        /// </summary>
        internal bool IsSetSubscriptionType() => this.SubscriptionType != null;
    }
}
