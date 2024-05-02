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
    /// Container for the parameters to the StartMonitoringMember operation.
    /// Sends a request to enable data ingest for a member account that has a status of <c>ACCEPTED_BUT_DISABLED</c>.
    /// 
    ///  
    /// <para>
    /// For valid member accounts, the status is updated as follows.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If Detective enabled the member account, then the new status is <c>ENABLED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If Detective cannot enable the member account, the status remains <c>ACCEPTED_BUT_DISABLED</c>.
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartMonitoringMemberRequest : AmazonDetectiveRequest
    {
        private string _accountId;
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID of the member account to try to enable.
        /// </para>
        ///  
        /// <para>
        /// The account must be an invited member account with a status of <c>ACCEPTED_BUT_DISABLED</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph.
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