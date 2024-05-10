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
    /// This is the response object from the BatchGetGraphMemberDatasources operation.
    /// </summary>
    public partial class BatchGetGraphMemberDatasourcesResponse : AmazonWebServiceResponse
    {
        private List<MembershipDatasources> _memberDatasources = AWSConfigs.InitializeCollections ? new List<MembershipDatasources>() : null;
        private List<UnprocessedAccount> _unprocessedAccounts = AWSConfigs.InitializeCollections ? new List<UnprocessedAccount>() : null;

        /// <summary>
        /// Gets and sets the property MemberDatasources. 
        /// <para>
        /// Details on the status of data source packages for members of the behavior graph.
        /// </para>
        /// </summary>
        public List<MembershipDatasources> MemberDatasources
        {
            get { return this._memberDatasources; }
            set { this._memberDatasources = value; }
        }

        // Check to see if MemberDatasources property is set
        internal bool IsSetMemberDatasources()
        {
            return this._memberDatasources != null && (this._memberDatasources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAccounts. 
        /// <para>
        /// Accounts that data source package information could not be retrieved for.
        /// </para>
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