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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the ListPartnerEventSourceAccounts operation. An SaaS
    /// partner can use this operation to display the Amazon Web Services account ID that
    /// a particular partner event source name is associated with. This operation is not used
    /// by Amazon Web Services customers.
    /// </summary>
    public partial class ListPartnerEventSourceAccountsRequest : AmazonCloudWatchEventsRequest
    {
        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// The name of the partner event source to display account information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceName property is set.
        /// </summary>
        internal bool IsSetEventSourceName() => this.EventSourceName != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifying this limits the number of results returned by this operation. The operation
        /// also returns a NextToken which you can use in a subsequent operation to retrieve the
        /// next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to this operation. Specifying this retrieves
        /// the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
