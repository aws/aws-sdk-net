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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourcePolicyStatement operation.
    /// Adds a new resource policy statement to a bot or bot alias. If a resource policy exists,
    /// the statement is added to the current resource policy. If a policy doesn't exist,
    /// a new policy is created.
    /// 
    ///  
    /// <para>
    /// You can't create a resource policy statement that allows cross-account access.
    /// </para>
    ///  
    /// <para>
    /// You need to add the <c>CreateResourcePolicy</c> or <c>UpdateResourcePolicy</c> action
    /// to the bot role in order to call the API.
    /// </para>
    /// </summary>
    public partial class CreateResourcePolicyStatementRequest : AmazonLexModelsV2Request
    {
        private List<string> _action = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, Dictionary<string, string>> _condition = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private Effect _effect;
        private string _expectedRevisionId;
        private List<Principal> _principal = AWSConfigs.InitializeCollections ? new List<Principal>() : null;
        private string _resourceArn;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The Amazon Lex action that this policy either allows or denies. The action must apply
        /// to the resource type of the specified ARN. For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonlexv2.html">
        /// Actions, resources, and condition keys for Amazon Lex V2</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Condition. 
        /// <para>
        /// Specifies a condition when the policy is in effect. If the principal of the policy
        /// is a service principal, you must provide two condition blocks, one with a SourceAccount
        /// global condition key and one with a SourceArn global condition key.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_condition.html">IAM
        /// JSON policy elements: Condition </a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public Dictionary<string, Dictionary<string, string>> Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null && (this._condition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// Determines whether the statement allows or denies access to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Effect Effect
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
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The identifier of the revision of the policy to edit. If this revision ID doesn't
        /// match the current revision ID, Amazon Lex throws an exception.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a revision, Amazon Lex overwrites the contents of the policy
        /// with the new values.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string ExpectedRevisionId
        {
            get { return this._expectedRevisionId; }
            set { this._expectedRevisionId = value; }
        }

        // Check to see if ExpectedRevisionId property is set
        internal bool IsSetExpectedRevisionId()
        {
            return this._expectedRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// An IAM principal, such as an IAM user, IAM role, or Amazon Web Services services that
        /// is allowed or denied access to a resource. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html">Amazon
        /// Web Services JSON policy elements: Principal</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Principal> Principal
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bot or bot alias that the resource policy is
        /// attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// The name of the statement. The ID is the same as the <c>Sid</c> IAM property. The
        /// statement name must be unique within the policy. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_sid.html">IAM
        /// JSON policy elements: Sid</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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