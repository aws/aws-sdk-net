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
    /// Container for the parameters to the UpdateContributorInsights operation. Updates the
    /// status for contributor insights for a specific table or index. CloudWatch Contributor
    /// Insights for DynamoDB graphs display the partition key and (if applicable) sort key
    /// of frequently accessed items and frequently throttled items in plaintext. If you require
    /// the use of Amazon Web Services Key Management Service (KMS) to encrypt this table’s
    /// partition key and sort key data with an Amazon Web Services managed key or customer
    /// managed key, you should not enable CloudWatch Contributor Insights for DynamoDB for
    /// this table.
    /// </summary>
    public partial class UpdateContributorInsightsRequest : AmazonDynamoDBRequest
    {
        /// <summary>
        /// Gets and sets the property ContributorInsightsAction. 
        /// <para>
        /// Represents the contributor insights action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContributorInsightsAction ContributorInsightsAction { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsAction property is set.
        /// </summary>
        internal bool IsSetContributorInsightsAction() => this.ContributorInsightsAction != null;

        /// <summary>
        /// Gets and sets the property ContributorInsightsMode. 
        /// <para>
        /// Specifies whether to track all access and throttled events or throttled events only
        /// for the DynamoDB table or index.
        /// </para>
        /// </summary>
        public ContributorInsightsMode ContributorInsightsMode { get; set; }

        /// <summary>
        /// Checks to see if the ContributorInsightsMode property is set.
        /// </summary>
        internal bool IsSetContributorInsightsMode() => this.ContributorInsightsMode != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The global secondary index name, if applicable.
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
        /// The name of the table. You can also provide the Amazon Resource Name (ARN) of the
        /// table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
