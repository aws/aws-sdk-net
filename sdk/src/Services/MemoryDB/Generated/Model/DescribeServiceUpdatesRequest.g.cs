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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeServiceUpdates operation. Returns details
    /// of the service updates.
    /// </summary>
    public partial class DescribeServiceUpdatesRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterNames. 
        /// <para>
        /// The list of cluster names to identify service updates to apply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> ClusterNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClusterNames property is set.
        /// </summary>
        internal bool IsSetClusterNames() => this.ClusterNames != null && (this.ClusterNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified MaxResults value, a token is included in the response so that the remaining
        /// results can be retrieved.
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
        /// An optional argument to pass in case the total number of records exceeds the value
        /// of MaxResults. If nextToken is returned, there are more results available. The value
        /// of nextToken is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update to describe.
        /// </para>
        /// </summary>
        public string ServiceUpdateName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateName property is set.
        /// </summary>
        internal bool IsSetServiceUpdateName() => this.ServiceUpdateName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status(es) of the service updates to filter on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
