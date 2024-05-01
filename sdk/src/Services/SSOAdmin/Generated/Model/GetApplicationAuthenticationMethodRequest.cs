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
    /// Container for the parameters to the GetApplicationAuthenticationMethod operation.
    /// Retrieves details about an authentication method used by an application.
    /// </summary>
    public partial class GetApplicationAuthenticationMethodRequest : AmazonSSOAdminRequest
    {
        private string _applicationArn;
        private AuthenticationMethodType _authenticationMethodType;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationMethodType. 
        /// <para>
        /// Specifies the type of authentication method for which you want details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationMethodType AuthenticationMethodType
        {
            get { return this._authenticationMethodType; }
            set { this._authenticationMethodType = value; }
        }

        // Check to see if AuthenticationMethodType property is set
        internal bool IsSetAuthenticationMethodType()
        {
            return this._authenticationMethodType != null;
        }

    }
}