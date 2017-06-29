/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutPermission operation.
    /// Running <code>PutPermission</code> permits the specified AWS account to put events
    /// to your account's default <i>event bus</i>. CloudWatch Events rules in your account
    /// are triggered by these events arriving to your default event bus. 
    /// 
    ///  
    /// <para>
    /// For another account to send events to your account, that external account must have
    /// a CloudWatch Events rule with your account's default event bus as a target.
    /// </para>
    ///  
    /// <para>
    /// To enable multiple AWS accounts to put events to your default event bus, run <code>PutPermission</code>
    /// once for each of these accounts.
    /// </para>
    /// </summary>
    public partial class PutPermissionRequest : AmazonCloudWatchEventsRequest
    {
        private string _action;
        private string _principal;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that you are enabling the other account to perform. Currently, this must
        /// be <code>events:PutEvents</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Principal. 
        /// <para>
        /// The 12-digit AWS account ID that you are permitting to put events to your default
        /// event bus. Specify "*" to permit any account to put events to your default event bus.
        /// </para>
        ///  
        /// <para>
        /// If you specify "*", avoid creating rules that may match undesirable events. To create
        /// more secure rules, make sure that the event pattern for each rule contains an <code>account</code>
        /// field with a specific account ID from which to receive events. Rules with an account
        /// field do not match any events sent from other accounts.
        /// </para>
        /// </summary>
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