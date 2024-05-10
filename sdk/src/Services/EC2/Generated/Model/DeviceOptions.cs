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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the options for an Amazon Web Services Verified Access device-identity based
    /// trust provider.
    /// </summary>
    public partial class DeviceOptions
    {
        private string _publicSigningKeyUrl;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property PublicSigningKeyUrl. 
        /// <para>
        ///  The URL Amazon Web Services Verified Access will use to verify the authenticity of
        /// the device tokens. 
        /// </para>
        /// </summary>
        public string PublicSigningKeyUrl
        {
            get { return this._publicSigningKeyUrl; }
            set { this._publicSigningKeyUrl = value; }
        }

        // Check to see if PublicSigningKeyUrl property is set
        internal bool IsSetPublicSigningKeyUrl()
        {
            return this._publicSigningKeyUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the tenant application with the device-identity provider.
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