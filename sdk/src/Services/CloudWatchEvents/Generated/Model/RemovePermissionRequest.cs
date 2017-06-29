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
    /// Container for the parameters to the RemovePermission operation.
    /// Revokes the permission of another AWS account to be able to put events to your default
    /// event bus. Specify the account to revoke by the <code>StatementId</code> value that
    /// you associated with the account when you granted it permission with <code>PutPermission</code>.
    /// You can find the <code>StatementId</code> by using <a>DescribeEventBus</a>.
    /// </summary>
    public partial class RemovePermissionRequest : AmazonCloudWatchEventsRequest
    {
        private string _statementId;

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// The statement ID corresponding to the account that is no longer allowed to put events
        /// to the default event bus.
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