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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes an authentication method and its type.
    /// </summary>
    public partial class AuthenticationMethodItem
    {
        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// A structure that describes an authentication method. The contents of this structure
        /// is determined by the <c>AuthenticationMethodType</c>.
        /// </para>
        /// </summary>
        public AuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethodType. 
        /// <para>
        /// The type of authentication that is used by this method.
        /// </para>
        /// </summary>
        public AuthenticationMethodType AuthenticationMethodType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethodType property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethodType() => this.AuthenticationMethodType != null;
    }
}
