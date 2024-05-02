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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Container for the parameters to the RemovePermission operation.
    /// Revokes the permission of another Amazon Web Services account to be able to put events
    /// to the specified event bus. Specify the account to revoke by the <c>StatementId</c>
    /// value that you associated with the account when you granted it permission with <c>PutPermission</c>.
    /// You can find the <c>StatementId</c> by using <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/API_DescribeEventBus.html">DescribeEventBus</a>.
    /// </summary>
    public partial class RemovePermissionRequest : AmazonEventBridgeRequest
    {
        private string _eventBusName;
        private bool? _removeAllPermissions;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property EventBusName. 
        /// <para>
        /// The name of the event bus to revoke permissions for. If you omit this, the default
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
        /// Gets and sets the property RemoveAllPermissions. 
        /// <para>
        /// Specifies whether to remove all permissions.
        /// </para>
        /// </summary>
        public bool? RemoveAllPermissions
        {
            get { return this._removeAllPermissions; }
            set { this._removeAllPermissions = value; }
        }

        // Check to see if RemoveAllPermissions property is set
        internal bool IsSetRemoveAllPermissions()
        {
            return this._removeAllPermissions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// The statement ID corresponding to the account that is no longer allowed to put events
        /// to the default event bus.
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