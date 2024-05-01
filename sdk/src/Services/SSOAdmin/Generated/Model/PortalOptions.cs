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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
    /// A structure that describes the options for the access portal associated with an application.
    /// </summary>
    public partial class PortalOptions
    {
        private SignInOptions _signInOptions;
        private ApplicationVisibility _visibility;

        /// <summary>
        /// Gets and sets the property SignInOptions. 
        /// <para>
        /// A structure that describes the sign-in options for the access portal.
        /// </para>
        /// </summary>
        public SignInOptions SignInOptions
        {
            get { return this._signInOptions; }
            set { this._signInOptions = value; }
        }

        // Check to see if SignInOptions property is set
        internal bool IsSetSignInOptions()
        {
            return this._signInOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// Indicates whether this application is visible in the access portal.
        /// </para>
        /// </summary>
        public ApplicationVisibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}