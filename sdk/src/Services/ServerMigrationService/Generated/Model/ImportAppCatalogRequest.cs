/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the ImportAppCatalog operation.
    /// Allows application import from AWS Migration Hub.
    /// </summary>
    public partial class ImportAppCatalogRequest : AmazonServerMigrationServiceRequest
    {
        private string _roleName;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the service role. If you omit this parameter, we create a service-linked
        /// role for AWS Migration Hub in your account. Otherwise, the role that you provide must
        /// have the <a href="https://docs.aws.amazon.com/migrationhub/latest/ug/new-customer-setup.html#sms-managed">policy
        /// and trust policy</a> described in the <i>AWS Migration Hub User Guide</i>.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}