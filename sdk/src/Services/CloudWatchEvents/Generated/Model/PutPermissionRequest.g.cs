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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermission operation. Running <c>PutPermission</c>
    /// permits the specified Amazon Web Services account or Amazon Web Services organization
    /// to put events to the specified <i>event bus</i>. Amazon EventBridge (CloudWatch Events)
    /// rules in your account are triggered by these events arriving to an event bus in your
    /// account. <para> For another account to send events to your account, that external
    /// account must have an EventBridge rule with your account's event bus as a target. </para>
    /// <para> To enable multiple Amazon Web Services accounts to put events to your event
    /// bus, run <c>PutPermission</c> once for each of these accounts. Or, if all the accounts
    /// are members of the same Amazon Web Services organization, you can run <c>PutPermission</c>
    /// once specifying <c>Principal</c> as "*" and specifying the Amazon Web Services organization
    /// ID in <c>Condition</c>, to grant permissions to all accounts in that organization.
    /// </para> <para> If you grant permissions using an organization, then accounts in that
    /// organization must specify a <c>RoleArn</c> with proper permissions when they use <c>PutTarget</c>
    /// to add your account's event bus as a target. For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eventbridge-cross-account-event-delivery.html">Sending
    /// and Receiving Events Between Amazon Web Services Accounts</a> in the <i>Amazon EventBridge
    /// User Guide</i>. </para> <para> The permission policy on the event bus cannot exceed
    /// 10 KB in size. </para>
    /// </summary>
    public partial class PutPermissionRequest : AmazonCloudWatchEventsRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that you are enabling the other account to perform.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// This parameter enables you to limit the permission to accounts that fulfill a certain
        /// condition, such as being a member of a certain Amazon Web Services organization. For
        /// more information about Amazon Web Services Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">What
        /// Is Amazon Web Services Organizations</a> in the <i>Amazon Web Services Organizations
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>Condition</c> with an Amazon Web Services organization ID, and specify
        /// "*" as the value for <c>Principal</c>, you grant permission to all the accounts in
        /// the named organization.
        /// </para>
        ///  
        /// <para>
        /// The <c>Condition</c> is a JSON string which must contain <c>Type</c>, <c>Key</c>,
        /// and <c>Value</c> fields.
        /// </para>
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name of the event bus associated with the rule. If you omit this, the default
        /// event bus is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EventBusName { get; set; }

        /// <summary>
        /// Checks to see if the EventBusName property is set.
        /// </summary>
        internal bool IsSetEventBusName() => this.EventBusName != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// A JSON string that describes the permission policy statement. You can include a <c>Policy</c>
        /// parameter in the request instead of using the <c>StatementId</c>, <c>Action</c>, <c>Principal</c>,
        /// or <c>Condition</c> parameters.
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID that you are permitting to put events
        /// to your default event bus. Specify "*" to permit any account to put events to your
        /// default event bus.
        /// </para>
        ///  
        /// <para>
        /// If you specify "*" without specifying <c>Condition</c>, avoid creating rules that
        /// may match undesirable events. To create more secure rules, make sure that the event
        /// pattern for each rule contains an <c>account</c> field with a specific account ID
        /// from which to receive events. Rules with an account field do not match any events
        /// sent from other accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// An identifier string for the external account that you are granting permissions to.
        /// If you later want to revoke the permission for this external account, specify this
        /// <c>StatementId</c> when you run <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_RemovePermission.html">RemovePermission</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string StatementId { get; set; }

        /// <summary>
        /// Checks to see if the StatementId property is set.
        /// </summary>
        internal bool IsSetStatementId() => this.StatementId != null;
    }
}
