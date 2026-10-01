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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The authorization code properties of a connection.
    /// </summary>
    public partial class AuthorizationCodeProperties
    {
        /// <summary>
        /// Gets and sets the property AuthorizationCode. 
        /// <para>
        /// The authorization code of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCode property is set.
        /// </summary>
        internal bool IsSetAuthorizationCode() => this.AuthorizationCode != null;

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUri property is set.
        /// </summary>
        internal bool IsSetRedirectUri() => this.RedirectUri != null;
    }
}
