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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Specifies the configurations of the Microsoft Entra.
    /// </summary>
    public partial class MicrosoftEntraConfig
    {
        private string _applicationConfigSecretArn;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property ApplicationConfigSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application config.
        /// </para>
        /// </summary>
        public string ApplicationConfigSecretArn
        {
            get { return this._applicationConfigSecretArn; }
            set { this._applicationConfigSecretArn = value; }
        }

        // Check to see if ApplicationConfigSecretArn property is set
        internal bool IsSetApplicationConfigSecretArn()
        {
            return this._applicationConfigSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The identifier of the tenant.
        /// </para>
        /// </summary>
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}