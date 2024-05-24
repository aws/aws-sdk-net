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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateMembership operation.
    /// Removes the member account from the specified behavior graph. This operation can only
    /// be called by an invited member account that has the <c>ENABLED</c> status.
    /// 
    ///  
    /// <para>
    ///  <c>DisassociateMembership</c> cannot be called by an organization account in the
    /// organization behavior graph. For the organization behavior graph, the Detective administrator
    /// account determines which organization accounts to enable or disable as member accounts.
    /// </para>
    /// </summary>
    public partial class DisassociateMembershipRequest : AmazonDetectiveRequest
    {
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph to remove the member account from.
        /// </para>
        ///  
        /// <para>
        /// The member account's member status in the behavior graph must be <c>ENABLED</c>.
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