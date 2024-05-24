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
    /// A structure that describes the sign-in options for an application portal.
    /// </summary>
    public partial class SignInOptions
    {
        private string _applicationUrl;
        private SignInOrigin _origin;

        /// <summary>
        /// Gets and sets the property ApplicationUrl. 
        /// <para>
        /// The URL that accepts authentication requests for an application. This is a required
        /// parameter if the <c>Origin</c> parameter is <c>APPLICATION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ApplicationUrl
        {
            get { return this._applicationUrl; }
            set { this._applicationUrl = value; }
        }

        // Check to see if ApplicationUrl property is set
        internal bool IsSetApplicationUrl()
        {
            return this._applicationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// This determines how IAM Identity Center navigates the user to the target application.
        /// It can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPLICATION</c>: IAM Identity Center redirects the customer to the configured
        /// <c>ApplicationUrl</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IDENTITY_CENTER</c>: IAM Identity Center uses SAML identity-provider initiated
        /// authentication to sign the customer directly into a SAML-based application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SignInOrigin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

    }
}