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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Configurations related to the security configuration for the request.
    /// </summary>
    public partial class SecurityConfigurationData
    {
        private AuthorizationConfiguration _authorizationConfiguration;

        /// <summary>
        /// Gets and sets the property AuthorizationConfiguration. 
        /// <para>
        /// Authorization-related configuration input for the security configuration.
        /// </para>
        /// </summary>
        public AuthorizationConfiguration AuthorizationConfiguration
        {
            get { return this._authorizationConfiguration; }
            set { this._authorizationConfiguration = value; }
        }

        // Check to see if AuthorizationConfiguration property is set
        internal bool IsSetAuthorizationConfiguration()
        {
            return this._authorizationConfiguration != null;
        }

    }
}