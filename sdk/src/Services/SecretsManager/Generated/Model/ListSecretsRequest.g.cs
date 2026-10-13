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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListSecrets operation. Lists the secrets that
    /// are stored by Secrets Manager in the Amazon Web Services account, not including secrets
    /// that are marked for deletion. To see secrets marked for deletion, use the Secrets
    /// Manager console. <para> All Secrets Manager operations are eventually consistent.
    /// ListSecrets might not reflect changes from the last five minutes. You can get more
    /// recent information for a specific secret by calling <a>DescribeSecret</a>. </para>
    /// <para> To list the versions of a secret, use <a>ListSecretVersionIds</a>. </para>
    /// <para> To retrieve the values for the secrets, call <a>BatchGetSecretValue</a> or
    /// <a>GetSecretValue</a>. </para> <para> For information about finding secrets in the
    /// console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_search-secret.html">Find
    /// secrets in Secrets Manager</a>. </para> <para> Secrets Manager generates a CloudTrail
    /// log entry when you call this action. Do not include sensitive information in request
    /// parameters because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>. </para> <para> <b>Required permissions:
    /// </b> <c>secretsmanager:ListSecrets</c>. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. </para>
    /// </summary>
    public partial class ListSecretsRequest : AmazonSecretsManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to the list of secrets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludePlannedDeletion. 
        /// <para>
        /// Specifies whether to include secrets scheduled for deletion. By default, secrets scheduled
        /// for deletion aren't included.
        /// </para>
        /// </summary>
        public bool? IncludePlannedDeletion { get; set; }

        /// <summary>
        /// Checks to see if the IncludePlannedDeletion property is set.
        /// </summary>
        internal bool IsSetIncludePlannedDeletion() => this.IncludePlannedDeletion.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to include in the response.
        /// </para>
        ///  
        /// <para>
        /// If there are more results available, in the response, Secrets Manager includes <c>NextToken</c>.
        /// To get the next results, call <c>ListSecrets</c> again with the value from <c>NextToken</c>.
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
        /// A token that indicates where the output should continue from, if a previous call did
        /// not show all results. To get the next results, call <c>ListSecrets</c> again with
        /// this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// If not specified, secrets are listed by <c>CreatedDate</c>.
        /// </para>
        /// </summary>
        public SortByType SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Secrets are listed by <c>CreatedDate</c>. 
        /// </para>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
