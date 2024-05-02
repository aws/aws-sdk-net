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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkerBlock operation.
    /// The <c>CreateWorkerBlock</c> operation allows you to prevent a Worker from working
    /// on your HITs. For example, you can block a Worker who is producing poor quality work.
    /// You can block up to 100,000 Workers.
    /// </summary>
    public partial class CreateWorkerBlockRequest : AmazonMTurkRequest
    {
        private string _reason;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message explaining the reason for blocking the Worker. This parameter enables you
        /// to keep track of your Workers. The Worker does not see this message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the Worker to block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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