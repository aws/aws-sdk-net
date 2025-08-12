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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the ListEffectivePolicyValidationErrors operation.
    /// </summary>
    public partial class ListEffectivePolicyValidationErrorsResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private List<EffectivePolicyValidationError> _effectivePolicyValidationErrors = AWSConfigs.InitializeCollections ? new List<EffectivePolicyValidationError>() : null;
        private DateTime? _evaluationTimestamp;
        private string _nextToken;
        private string _path;
        private EffectivePolicyType _policyType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the specified account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property EffectivePolicyValidationErrors. 
        /// <para>
        /// The <c>EffectivePolicyValidationError</c> object contains details about the validation
        /// errors that occurred when generating or enforcing an effective policy, such as which
        /// policies contributed to the error and location of the error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EffectivePolicyValidationError> EffectivePolicyValidationErrors
        {
            get { return this._effectivePolicyValidationErrors; }
            set { this._effectivePolicyValidationErrors = value; }
        }

        // Check to see if EffectivePolicyValidationErrors property is set
        internal bool IsSetEffectivePolicyValidationErrors()
        {
            return this._effectivePolicyValidationErrors != null && (this._effectivePolicyValidationErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationTimestamp. 
        /// <para>
        /// The time when the latest effective policy was generated for the specified account.
        /// </para>
        /// </summary>
        public DateTime? EvaluationTimestamp
        {
            get { return this._evaluationTimestamp; }
            set { this._evaluationTimestamp = value; }
        }

        // Check to see if EvaluationTimestamp property is set
        internal bool IsSetEvaluationTimestamp()
        {
            return this._evaluationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <c>NextToken</c> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <c>NextToken</c> response element comes back as <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The path in the organization where the specified account exists.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The specified policy type. One of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_declarative.html">DECLARATIVE_POLICY_EC2</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_backup.html">BACKUP_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">TAG_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_chatbot.html">CHATBOT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">AISERVICES_OPT_OUT_POLICY</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_security_hub.html">SECURITYHUB_POLICY</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EffectivePolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}