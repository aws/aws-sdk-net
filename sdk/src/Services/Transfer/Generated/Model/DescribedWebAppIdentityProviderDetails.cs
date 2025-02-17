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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns a structure that contains the identity provider details for your web app.
    /// </summary>
    public partial class DescribedWebAppIdentityProviderDetails
    {
        private DescribedIdentityCenterConfig _identityCenterConfig;

        /// <summary>
        /// Gets and sets the property IdentityCenterConfig. 
        /// <para>
        /// Returns a structure for your identity provider details. This structure contains the
        /// instance ARN and role being used for the web app.
        /// </para>
        /// </summary>
        public DescribedIdentityCenterConfig IdentityCenterConfig
        {
            get { return this._identityCenterConfig; }
            set { this._identityCenterConfig = value; }
        }

        // Check to see if IdentityCenterConfig property is set
        internal bool IsSetIdentityCenterConfig()
        {
            return this._identityCenterConfig != null;
        }

    }
}