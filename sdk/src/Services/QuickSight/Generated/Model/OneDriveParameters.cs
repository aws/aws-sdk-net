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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The connection parameters for an OneDrive data source. Provide these parameters in
    /// the <c>DataSourceParameters</c> object when you create or update a data source that
    /// uses OneDrive.
    /// </summary>
    public partial class OneDriveParameters
    {
        private AuthType _authType;
        private string _clientId;
        private string _tenantId;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authentication type for the OneDrive data source. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TWO_LEGGED_OAUTH</c> – Server-to-server authentication using client credentials
        /// that do not require user interaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THREE_LEGGED_OAUTH</c> – Interactive OAuth that requires user consent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the OneDrive data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The tenant ID for the OneDrive data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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