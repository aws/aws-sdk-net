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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Information about a specific tenant.
    /// </summary>
    public partial class GetTenantResponse : AmazonWebServiceResponse
    {
        private Tenant _tenant;

        /// <summary>
        /// Gets and sets the property Tenant. 
        /// <para>
        /// A structure that contains details about the tenant.
        /// </para>
        /// </summary>
        public Tenant Tenant
        {
            get { return this._tenant; }
            set { this._tenant = value; }
        }

        // Check to see if Tenant property is set
        internal bool IsSetTenant()
        {
            return this._tenant != null;
        }

    }
}