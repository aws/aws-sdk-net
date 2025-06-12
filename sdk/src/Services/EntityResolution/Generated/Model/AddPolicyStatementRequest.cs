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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the AddPolicyStatement operation.
    /// Adds a policy statement object. To retrieve a list of existing policy statements,
    /// use the <c>GetPolicy</c> API.
    /// </summary>
    public partial class AddPolicyStatementRequest : AmazonEntityResolutionRequest
    {
        private List<string> _action = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private string _condition;
        private StatementEffect _effect;
        private List<string> _principal = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that the principal can use on the resource. 
        /// </para>
        ///  
        /// <para>
        /// For example, <c>entityresolution:GetIdMappingJob</c>, <c>entityresolution:GetMatchingJob</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null && (this._action.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that will be accessed by the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A set of condition keys that you can use in key policies.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40960)]
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// Determines whether the permissions specified in the policy are to be allowed (<c>Allow</c>)
        /// or denied (<c>Deny</c>).
        /// </para>
        ///  <important> 
        /// <para>
        ///  If you set the value of the <c>effect</c> parameter to <c>Deny</c> for the <c>AddPolicyStatement</c>
        /// operation, you must also set the value of the <c>effect</c> parameter in the <c>policy</c>
        /// to <c>Deny</c> for the <c>PutPolicy</c> operation.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatementEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Web Services service or Amazon Web Services account that can access the
        /// resource defined as ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null && (this._principal.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// A statement identifier that differentiates the statement from others in the same policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string StatementId
        {
            get { return this._statementId; }
            set { this._statementId = value; }
        }

        // Check to see if StatementId property is set
        internal bool IsSetStatementId()
        {
            return this._statementId != null;
        }

    }
}