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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWorkerBlock operation.
    /// The <code>DeleteWorkerBlock</code> operation allows you to reinstate a blocked Worker
    /// to work on your HITs. This operation reverses the effects of the CreateWorkerBlock
    /// operation. You need the Worker ID to use this operation. If the Worker ID is missing
    /// or invalid, this operation fails and returns the message “WorkerId is invalid.” If
    /// the specified Worker is not blocked, this operation returns successfully.
    /// </summary>
    public partial class DeleteWorkerBlockRequest : AmazonMTurkRequest
    {
        private string _reason;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message that explains the reason for unblocking the Worker. The Worker does not
        /// see this message.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The ID of the Worker to unblock.
        /// </para>
        /// </summary>
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}