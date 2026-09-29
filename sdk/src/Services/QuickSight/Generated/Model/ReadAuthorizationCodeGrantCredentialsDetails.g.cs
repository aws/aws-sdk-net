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
    /// Read-only credentials details for OAuth2 authorization code grant flow, containing
    /// non-sensitive configuration information.
    /// </summary>
    public partial class ReadAuthorizationCodeGrantCredentialsDetails
    {
        /// <summary>
        /// Gets and sets the property ReadAuthorizationCodeGrantDetails. 
        /// <para>
        /// The read-only authorization code grant configuration details.
        /// </para>
        /// </summary>
        public ReadAuthorizationCodeGrantDetails ReadAuthorizationCodeGrantDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReadAuthorizationCodeGrantDetails property is set.
        /// </summary>
        internal bool IsSetReadAuthorizationCodeGrantDetails() => this.ReadAuthorizationCodeGrantDetails != null;
    }
}
