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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specifies the tenant isolation mode configuration for a Lambda function. This allows
    /// you to configure specific tenant isolation strategies for your function invocations.
    /// Tenant isolation configuration cannot be modified after function creation.
    /// </summary>
    public partial class TenancyConfig
    {
        private TenantIsolationMode _tenantIsolationMode;

        /// <summary>
        /// Gets and sets the property TenantIsolationMode. 
        /// <para>
        /// Tenant isolation mode allows for invocation to be sent to a corresponding execution
        /// environment dedicated to a specific tenant ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TenantIsolationMode TenantIsolationMode
        {
            get { return this._tenantIsolationMode; }
            set { this._tenantIsolationMode = value; }
        }

        // Check to see if TenantIsolationMode property is set
        internal bool IsSetTenantIsolationMode()
        {
            return this._tenantIsolationMode != null;
        }

    }
}