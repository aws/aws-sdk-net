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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermission operation.
    /// Running <code>PutPermission</code> permits the specified AWS account or AWS organization
    /// to put events to the specified <i>event bus</i>. Amazon EventBridge (CloudWatch Events)
    /// rules in your account are triggered by these events arriving to an event bus in your
    /// account. 
    /// 
    ///  
    /// <para>
    /// For another account to send events to your account, that external account must have
    /// an EventBridge rule with your account's event bus as a target.
    /// </para>
    ///  
    /// <para>
    /// To enable multiple AWS accounts to put events to your event bus, run <code>PutPermission</code>
    /// once for each of these accounts. Or, if all the accounts are members of the same AWS
    /// organization, you can run <code>PutPermission</code> once specifying <code>Principal</code>
    /// as "*" and specifying the AWS organization ID in <code>Condition</code>, to grant
    /// permissions to all accounts in that organization.
    /// </para>
    ///  
    /// <para>
    /// If you grant permissions using an organization, then accounts in that organization
    /// must specify a <code>RoleArn</code> with proper permissions when they use <code>PutTarget</code>
    /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between AWS Accounts</a> in the <i>Amazon EventBridge User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The permission policy on the default event bus cannot exceed 10 KB in size.
    /// </para>
    /// </summary>
    public partial class PutPermissionRequest : AmazonEventBridgeRequest
    {
        private string _action;
        private Condition _condition;
        private string _eventBusName;
        private string _policy;
        private string _principal;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that you are enabling the other account to perform. Currently, this must
        /// be <code>events:PutEvents</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// This parameter enables you to limit the permission to accounts that fulfill a certain
        /// condition, such as being a member of a certain AWS organization. For more information
        /// about AWS Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">What
        /// Is AWS Organizations</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>Condition</code> with an AWS organization ID, and specify "*"
        /// as the value for <code>Principal</code>, you grant permission to all the accounts
        /// in the named organization.
        /// </para>
        ///  
        /// <para>
        /// The <code>Condition</code> is a JSON string which must contain <code>Type</code>,
        /// <code>Key</code>, and <code>Value</code> fields.
        /// </para>
        /// </summary>
        public Condition Condition
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
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name of the event bus associated with the rule. If you omit this, the default
        /// event bus is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EventBusName
        {
            get { return this._eventBusName; }
            set { this._eventBusName = value; }
        }

        // Check to see if EventBusName property is set
        internal bool IsSetEventBusName()
        {
            return this._eventBusName != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A JSON string that describes the permission policy statement. You can include a <code>Policy</code>
        /// parameter in the request instead of using the <code>StatementId</code>, <code>Action</code>,
        /// <code>Principal</code>, or <code>Condition</code> parameters.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The 12-digit AWS account ID that you are permitting to put events to your default
        /// event bus. Specify "*" to permit any account to put events to your default event bus.
        /// </para>
        ///  
        /// <para>
        /// If you specify "*" without specifying <code>Condition</code>, avoid creating rules
        /// that may match undesirable events. To create more secure rules, make sure that the
        /// event pattern for each rule contains an <code>account</code> field with a specific
        /// account ID from which to receive events. Rules with an account field do not match
        /// any events sent from other accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// An identifier string for the external account that you are granting permissions to.
        /// If you later want to revoke the permission for this external account, specify this
        /// <code>StatementId</code> when you run <a>RemovePermission</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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