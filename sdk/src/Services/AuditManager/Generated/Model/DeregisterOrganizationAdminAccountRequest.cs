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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterOrganizationAdminAccount operation.
    /// Removes the specified member Amazon Web Services account as a delegated administrator
    /// for Audit Manager. 
    /// 
    ///  <important> 
    /// <para>
    /// When you remove a delegated administrator from your Audit Manager settings, you continue
    /// to have access to the evidence that you previously collected under that account. This
    /// is also the case when you deregister a delegated administrator from Audit Manager.
    /// However, Audit Manager will stop collecting and attaching evidence to that delegated
    /// administrator account moving forward.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeregisterOrganizationAdminAccountRequest : AmazonAuditManagerRequest
    {
        private string _adminAccountId;

        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        ///  The identifier for the administrator account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AdminAccountId
        {
            get { return this._adminAccountId; }
            set { this._adminAccountId = value; }
        }

        // Check to see if AdminAccountId property is set
        internal bool IsSetAdminAccountId()
        {
            return this._adminAccountId != null;
        }

    }
}