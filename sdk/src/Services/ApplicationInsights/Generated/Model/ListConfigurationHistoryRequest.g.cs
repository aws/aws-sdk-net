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

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the ListConfigurationHistory operation. Lists the
    /// INFO, WARN, and ERROR events for periodic configuration updates performed by Application
    /// Insights. Examples of events represented are: <ul> <li> <para> INFO: creating a new
    /// alarm or updating an alarm threshold. </para> </li> <li> <para> WARN: alarm not created
    /// due to insufficient data points used to predict thresholds. </para> </li> <li> <para>
    /// ERROR: alarm not created due to permission errors or exceeding quotas. </para> </li>
    /// </ul>
    /// </summary>
    public partial class ListConfigurationHistoryRequest : AmazonApplicationInsightsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the resource group owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the event.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of the configuration update event. Possible values include INFO, WARN,
        /// and ERROR.
        /// </para>
        /// </summary>
        public ConfigurationEventStatus EventStatus { get; set; }

        /// <summary>
        /// Checks to see if the EventStatus property is set.
        /// </summary>
        internal bool IsSetEventStatus() => this.EventStatus != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results returned by <c>ListConfigurationHistory</c> in paginated
        /// output. When this parameter is used, <c>ListConfigurationHistory</c> returns only
        /// <c>MaxResults</c> in a single page along with a <c>NextToken</c> response element.
        /// The remaining results of the initial request can be seen by sending another <c>ListConfigurationHistory</c>
        /// request with the returned <c>NextToken</c> value. If this parameter is not used, then
        /// <c>ListConfigurationHistory</c> returns all results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>NextToken</c> value returned from a previous paginated <c>ListConfigurationHistory</c>
        /// request where <c>MaxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>NextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// Resource group to which the application belongs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the event. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
