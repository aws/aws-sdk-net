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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterAccount operation.
    /// Enables Audit Manager for the specified Amazon Web Services account.
    /// </summary>
    public partial class RegisterAccountRequest : AmazonAuditManagerRequest
    {
        private string _delegatedAdminAccount;
        private string _kmsKey;

        /// <summary>
        /// Gets and sets the property DelegatedAdminAccount. 
        /// <para>
        ///  The delegated administrator account for Audit Manager. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DelegatedAdminAccount
        {
            get { return this._delegatedAdminAccount; }
            set { this._delegatedAdminAccount = value; }
        }

        // Check to see if DelegatedAdminAccount property is set
        internal bool IsSetDelegatedAdminAccount()
        {
            return this._delegatedAdminAccount != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The KMS key details. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

    }
}