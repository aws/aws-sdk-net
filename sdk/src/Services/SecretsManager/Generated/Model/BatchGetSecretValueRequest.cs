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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
    /// Container for the parameters to the BatchGetSecretValue operation.
    /// Retrieves the contents of the encrypted fields <c>SecretString</c> or <c>SecretBinary</c>
    /// for up to 20 secrets. To retrieve a single secret, call <a>GetSecretValue</a>. 
    /// 
    ///  
    /// <para>
    /// To choose which secrets to retrieve, you can specify a list of secrets by name or
    /// ARN, or you can use filters. If Secrets Manager encounters errors such as <c>AccessDeniedException</c>
    /// while attempting to retrieve any of the secrets, you can see the errors in <c>Errors</c>
    /// in the response.
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager generates CloudTrail <c>GetSecretValue</c> log entries for each secret
    /// you request when you call this action. Do not include sensitive information in request
    /// parameters because it might be logged. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/retrieve-ct-entries.html">Logging
    /// Secrets Manager events with CloudTrail</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>secretsmanager:BatchGetSecretValue</c>, and you
    /// must have <c>secretsmanager:GetSecretValue</c> for each secret. If you use filters,
    /// you must also have <c>secretsmanager:ListSecrets</c>. If the secrets are encrypted
    /// using customer-managed keys instead of the Amazon Web Services managed key <c>aws/secretsmanager</c>,
    /// then you also need <c>kms:Decrypt</c> permissions for the keys. For more information,
    /// see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/reference_iam-permissions.html#reference_iam-permissions_actions">
    /// IAM policy actions for Secrets Manager</a> and <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access.html">Authentication
    /// and access control in Secrets Manager</a>. 
    /// </para>
    /// </summary>
    public partial class BatchGetSecretValueRequest : AmazonSecretsManagerRequest
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _secretIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to choose which secrets to retrieve. You must include <c>Filters</c> or
        /// <c>SecretIdList</c>, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to include in the response.
        /// </para>
        ///  
        /// <para>
        /// If there are more results available, in the response, Secrets Manager includes <c>NextToken</c>.
        /// To get the next results, call <c>BatchGetSecretValue</c> again with the value from
        /// <c>NextToken</c>. To use this parameter, you must also use the <c>Filters</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where the output should continue from, if a previous call did
        /// not show all results. To get the next results, call <c>BatchGetSecretValue</c> again
        /// with this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SecretIdList. 
        /// <para>
        /// The ARN or names of the secrets to retrieve. You must include <c>Filters</c> or <c>SecretIdList</c>,
        /// but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> SecretIdList
        {
            get { return this._secretIdList; }
            set { this._secretIdList = value; }
        }

        // Check to see if SecretIdList property is set
        internal bool IsSetSecretIdList()
        {
            return this._secretIdList != null && (this._secretIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}