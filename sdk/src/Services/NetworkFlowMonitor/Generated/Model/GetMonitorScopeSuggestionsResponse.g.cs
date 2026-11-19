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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// This is the response object from the GetMonitorScopeSuggestions operation.
    /// </summary>
    public partial class GetMonitorScopeSuggestionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountsToAdd. 
        /// <para>
        /// The accounts that you can add to the monitoring scope, so that Network Flow Monitor
        /// can resolve the network paths for traffic to and from resources in those accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AccountToAdd> AccountsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<AccountToAdd>() : null;

        /// <summary>
        /// Checks to see if the AccountsToAdd property is set.
        /// </summary>
        internal bool IsSetAccountsToAdd() => this.AccountsToAdd != null && (this.AccountsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The coverage status of the monitoring scope for the monitor. The status can be one
        /// of the following
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETE</c>: The scope includes every account that sends traffic to, or receives
        /// traffic from, resources in the monitor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCOMPLETE</c>: There are accounts that you can add to the scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c>: Network Flow Monitor is determining the coverage of the scope.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STALE</c>: The coverage of the scope was last determined too long ago to be current.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScopeCoverageStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when Network Flow Monitor last determined the coverage of the monitoring
        /// scope.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
