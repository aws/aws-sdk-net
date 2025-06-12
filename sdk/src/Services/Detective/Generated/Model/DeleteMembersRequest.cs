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
    /// Container for the parameters to the DeleteMembers operation.
    /// Removes the specified member accounts from the behavior graph. The removed accounts
    /// no longer contribute data to the behavior graph. This operation can only be called
    /// by the administrator account for the behavior graph.
    /// 
    ///  
    /// <para>
    /// For invited accounts, the removed accounts are deleted from the list of accounts in
    /// the behavior graph. To restore the account, the administrator account must send another
    /// invitation.
    /// </para>
    ///  
    /// <para>
    /// For organization accounts in the organization behavior graph, the Detective administrator
    /// account can always enable the organization account again. Organization accounts that
    /// are not enabled as member accounts are not included in the <c>ListMembers</c> results
    /// for the organization behavior graph.
    /// </para>
    ///  
    /// <para>
    /// An administrator account cannot use <c>DeleteMembers</c> to remove their own account
    /// from the behavior graph. To disable a behavior graph, the administrator account uses
    /// the <c>DeleteGraph</c> API method.
    /// </para>
    /// </summary>
    public partial class DeleteMembersRequest : AmazonDetectiveRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The list of Amazon Web Services account identifiers for the member accounts to remove
        /// from the behavior graph. You can remove up to 50 member accounts at a time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph to remove members from.
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