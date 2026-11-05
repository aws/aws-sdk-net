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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// This is the response object from the DescribeContributorInsights operation.
    /// </summary>
    public partial class DescribeContributorInsightsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContributorInsightsMode. 
        /// <para>
        /// The mode of CloudWatch Contributor Insights for DynamoDB that determines which events
        /// are emitted. Can be set to track all access and throttled events or throttled events
        /// only.
        /// </para>
        /// </summary>
        public ContributorInsightsMode ContributorInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsMode property is set.
        /// </summary>
        internal bool IsSetContributorInsightsMode() => this.ContributorInsightsMode != null;

        /// <summary>
        /// Gets and sets the property ContributorInsightsRuleList. 
        /// <para>
        /// List of names of the associated contributor insights rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContributorInsightsRuleList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContributorInsightsRuleList property is set.
        /// </summary>
        internal bool IsSetContributorInsightsRuleList() => this.ContributorInsightsRuleList != null && (this.ContributorInsightsRuleList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContributorInsightsStatus. 
        /// <para>
        /// Current status of contributor insights.
        /// </para>
        /// </summary>
        public ContributorInsightsStatus ContributorInsightsStatus { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsStatus property is set.
        /// </summary>
        internal bool IsSetContributorInsightsStatus() => this.ContributorInsightsStatus != null;

        /// <summary>
        /// Gets and sets the property FailureException. 
        /// <para>
        /// Returns information about the last failure that was encountered.
        /// </para>
        ///  
        /// <para>
        /// The most common exceptions for a FAILED status are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// LimitExceededException - Per-account Amazon CloudWatch Contributor Insights rule limit
        /// reached. Please disable Contributor Insights for other tables/indexes OR disable Contributor
        /// Insights rules before retrying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AccessDeniedException - Amazon CloudWatch Contributor Insights rules cannot be modified
        /// due to insufficient permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AccessDeniedException - Failed to create service-linked role for Contributor Insights
        /// due to insufficient permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InternalServerError - Failed to create Amazon CloudWatch Contributor Insights rules.
        /// Please retry request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FailureException FailureException { get; set; }

        /// <summary>
        /// Checks to see if the FailureException property is set.
        /// </summary>
        internal bool IsSetFailureException() => this.FailureException != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index being described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// Timestamp of the last time the status was changed.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateDateTime() => this.LastUpdateDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table being described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
