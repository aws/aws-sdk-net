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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The details of the user profile in Amazon DataZone.
    /// </summary>
    public partial class UserProfileDetails
    {
        private IamUserProfileDetails _iam;
        private SsoUserProfileDetails _sso;

        /// <summary>
        /// Gets and sets the property Iam. 
        /// <para>
        /// The IAM details included in the user profile details.
        /// </para>
        /// </summary>
        public IamUserProfileDetails Iam
        {
            get { return this._iam; }
            set { this._iam = value; }
        }

        // Check to see if Iam property is set
        internal bool IsSetIam()
        {
            return this._iam != null;
        }

        /// <summary>
        /// Gets and sets the property Sso. 
        /// <para>
        /// The single sign-on details included in the user profile details.
        /// </para>
        /// </summary>
        public SsoUserProfileDetails Sso
        {
            get { return this._sso; }
            set { this._sso = value; }
        }

        // Check to see if Sso property is set
        internal bool IsSetSso()
        {
            return this._sso != null;
        }

    }
}