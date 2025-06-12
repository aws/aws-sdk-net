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
    /// This is the response object from the DeleteMembers operation.
    /// </summary>
    public partial class DeleteMembersResponse : AmazonWebServiceResponse
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<UnprocessedAccount> _unprocessedAccounts = AWSConfigs.InitializeCollections ? new List<UnprocessedAccount>() : null;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The list of Amazon Web Services account identifiers for the member accounts that Detective
        /// successfully removed from the behavior graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property UnprocessedAccounts. 
        /// <para>
        /// The list of member accounts that Detective was not able to remove from the behavior
        /// graph. For each member account, provides the reason that the deletion could not be
        /// processed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedAccount> UnprocessedAccounts
        {
            get { return this._unprocessedAccounts; }
            set { this._unprocessedAccounts = value; }
        }

        // Check to see if UnprocessedAccounts property is set
        internal bool IsSetUnprocessedAccounts()
        {
            return this._unprocessedAccounts != null && (this._unprocessedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}