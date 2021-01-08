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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the RejectInvitation operation.
    /// Rejects an invitation to contribute the account data to a behavior graph. This operation
    /// must be called by a member account that has the <code>INVITED</code> status.
    /// </summary>
    public partial class RejectInvitationRequest : AmazonDetectiveRequest
    {
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph to reject the invitation to.
        /// </para>
        ///  
        /// <para>
        /// The member account's current member status in the behavior graph must be <code>INVITED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

    }
}