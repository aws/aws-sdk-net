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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the ListRules operation. Lists the rules for the specified
    /// listener.
    /// </summary>
    public partial class ListRulesRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property ListenerIdentifier. 
        /// <para>
        /// The ID or ARN of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ListenerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ListenerIdentifier property is set.
        /// </summary>
        internal bool IsSetListenerIdentifier() => this.ListenerIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// A pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;
    }
}
