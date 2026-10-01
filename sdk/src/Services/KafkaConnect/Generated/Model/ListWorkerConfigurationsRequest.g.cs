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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkerConfigurations operation. Returns a
    /// list of all of the worker configurations in this account and Region.
    /// </summary>
    public partial class ListWorkerConfigurationsRequest : AmazonKafkaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of worker configurations to list in one response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// Lists worker configuration names that start with the specified text string.
        /// </para>
        /// </summary>
        public string NamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the NamePrefix property is set.
        /// </summary>
        internal bool IsSetNamePrefix() => this.NamePrefix != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response of a ListWorkerConfigurations operation is truncated, it will include
        /// a NextToken. Send this NextToken in a subsequent request to continue listing from
        /// where the previous operation left off.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
