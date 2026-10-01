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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the ListNetworkMigrationCodeGenerationSegments operation.
    /// Lists code generation segments, which represent individual infrastructure components
    /// generated as code templates.
    /// </summary>
    public partial class ListNetworkMigrationCodeGenerationSegmentsRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters to apply when listing code generation segments.
        /// </para>
        /// </summary>
        public ListNetworkMigrationCodeGenerationSegmentsFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string NetworkMigrationDefinitionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationDefinitionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationDefinitionID() => this.NetworkMigrationDefinitionID != null;

        /// <summary>
        /// Gets and sets the property NetworkMigrationExecutionID. 
        /// <para>
        /// The unique identifier of the network migration execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string NetworkMigrationExecutionID { get; set; }

        /// <summary>
        /// Checks to see if the NetworkMigrationExecutionID property is set.
        /// </summary>
        internal bool IsSetNetworkMigrationExecutionID() => this.NetworkMigrationExecutionID != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
