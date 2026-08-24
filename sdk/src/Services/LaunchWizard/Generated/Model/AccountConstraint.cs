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
 * Do not modify this file. This file is generated from the launch-wizard-2018-05-10.normal.json service model.
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
namespace Amazon.LaunchWizard.Model
{
    /// <summary>
    /// A constraint on which AWS account a deployment can be initiated from. Specify one
    /// of the supported constraint types.
    /// </summary>
    public partial class AccountConstraint
    {
        private DelegatedAdminConstraint _delegatedAdmin;
        private ManagementAccountConstraint _managementAccount;

        /// <summary>
        /// Gets and sets the property DelegatedAdmin.
        /// </summary>
        public DelegatedAdminConstraint DelegatedAdmin
        {
            get { return this._delegatedAdmin; }
            set { this._delegatedAdmin = value; }
        }

        // Check to see if DelegatedAdmin property is set
        internal bool IsSetDelegatedAdmin()
        {
            return this._delegatedAdmin != null;
        }

        /// <summary>
        /// Gets and sets the property ManagementAccount.
        /// </summary>
        public ManagementAccountConstraint ManagementAccount
        {
            get { return this._managementAccount; }
            set { this._managementAccount = value; }
        }

        // Check to see if ManagementAccount property is set
        internal bool IsSetManagementAccount()
        {
            return this._managementAccount != null;
        }

    }
}