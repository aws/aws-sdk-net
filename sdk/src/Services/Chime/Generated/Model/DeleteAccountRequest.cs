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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAccount operation.
    /// Deletes the specified Amazon Chime account. You must suspend all users before deleting
    /// <c>Team</c> account. You can use the <a>BatchSuspendUser</a> action to dodo.
    /// 
    ///  
    /// <para>
    /// For <c>EnterpriseLWA</c> and <c>EnterpriseAD</c> accounts, you must release the claimed
    /// domains for your Amazon Chime account before deletion. As soon as you release the
    /// domain, all users under that account are suspended.
    /// </para>
    ///  
    /// <para>
    /// Deleted accounts appear in your <c>Disabled</c> accounts list for 90 days. To restore
    /// deleted account from your <c>Disabled</c> accounts list, you must contact AWS Support.
    /// </para>
    ///  
    /// <para>
    /// After 90 days, deleted accounts are permanently removed from your <c>Disabled</c>
    /// accounts list.
    /// </para>
    /// </summary>
    public partial class DeleteAccountRequest : AmazonChimeRequest
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}