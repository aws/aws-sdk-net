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
    /// Represents a Contributor Insights summary entry.
    /// </summary>
    public partial class ContributorInsightsSummary
    {
        /// <summary>
        /// Gets and sets the property ContributorInsightsMode. 
        /// <para>
        /// Indicates the current mode of CloudWatch Contributor Insights, specifying whether
        /// it tracks all access and throttled events or throttled events only for the DynamoDB
        /// table or index.
        /// </para>
        /// </summary>
        public ContributorInsightsMode ContributorInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsMode property is set.
        /// </summary>
        internal bool IsSetContributorInsightsMode() => this.ContributorInsightsMode != null;

        /// <summary>
        /// Gets and sets the property ContributorInsightsStatus. 
        /// <para>
        /// Describes the current status for contributor insights for the given table and index,
        /// if applicable.
        /// </para>
        /// </summary>
        public ContributorInsightsStatus ContributorInsightsStatus { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsStatus property is set.
        /// </summary>
        internal bool IsSetContributorInsightsStatus() => this.ContributorInsightsStatus != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// Name of the index associated with the summary, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// Name of the table associated with the summary.
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
