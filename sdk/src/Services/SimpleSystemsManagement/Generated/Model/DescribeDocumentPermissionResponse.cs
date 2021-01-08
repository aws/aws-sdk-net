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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeDocumentPermission operation.
    /// </summary>
    public partial class DescribeDocumentPermissionResponse : AmazonWebServiceResponse
    {
        private List<string> _accountIds = new List<string>();
        private List<AccountSharingInfo> _accountSharingInfoList = new List<AccountSharingInfo>();

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// The account IDs that have permission to use this document. The ID can be either an
        /// AWS account or <i>All</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && this._accountIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AccountSharingInfoList. 
        /// <para>
        /// A list of AWS accounts where the current document is shared and the version shared
        /// with each account.
        /// </para>
        /// </summary>
        public List<AccountSharingInfo> AccountSharingInfoList
        {
            get { return this._accountSharingInfoList; }
            set { this._accountSharingInfoList = value; }
        }

        // Check to see if AccountSharingInfoList property is set
        internal bool IsSetAccountSharingInfoList()
        {
            return this._accountSharingInfoList != null && this._accountSharingInfoList.Count > 0; 
        }

    }
}