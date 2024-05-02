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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteOpsItem operation.
    /// Delete an OpsItem. You must have permission in Identity and Access Management (IAM)
    /// to delete an OpsItem. 
    /// 
    ///  <important> 
    /// <para>
    /// Note the following important information about this operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Deleting an OpsItem is irreversible. You can't restore a deleted OpsItem.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation uses an <i>eventual consistency model</i>, which means the system can
    /// take a few minutes to complete this operation. If you delete an OpsItem and immediately
    /// call, for example, <a>GetOpsItem</a>, the deleted OpsItem might still appear in the
    /// response. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation is idempotent. The system doesn't throw an exception if you repeatedly
    /// call this operation for the same OpsItem. If the first call is successful, all additional
    /// calls return the same successful response as the first call.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation doesn't support cross-account calls. A delegated administrator or management
    /// account can't delete OpsItems in other accounts, even if OpsCenter has been set up
    /// for cross-account administration. For more information about cross-account administration,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setting-up-cross-account.html">Setting
    /// up OpsCenter to centrally manage OpsItems across accounts</a> in the <i>Systems Manager
    /// User Guide</i>.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class DeleteOpsItemRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _opsItemId;

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OpsItemId
        {
            get { return this._opsItemId; }
            set { this._opsItemId = value; }
        }

        // Check to see if OpsItemId property is set
        internal bool IsSetOpsItemId()
        {
            return this._opsItemId != null;
        }

    }
}