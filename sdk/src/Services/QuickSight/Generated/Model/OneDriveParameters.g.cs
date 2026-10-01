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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for the OneDrive data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The tenant ID for the OneDrive data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;
    }
}
