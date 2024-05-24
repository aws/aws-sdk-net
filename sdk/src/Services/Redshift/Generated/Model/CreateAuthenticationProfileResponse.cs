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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the CreateAuthenticationProfile operation.
    /// </summary>
    public partial class CreateAuthenticationProfileResponse : AmazonWebServiceResponse
    {
        private string _authenticationProfileContent;
        private string _authenticationProfileName;

        /// <summary>
        /// Gets and sets the property AuthenticationProfileContent. 
        /// <para>
        /// The content of the authentication profile in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string AuthenticationProfileContent
        {
            get { return this._authenticationProfileContent; }
            set { this._authenticationProfileContent = value; }
        }

        // Check to see if AuthenticationProfileContent property is set
        internal bool IsSetAuthenticationProfileContent()
        {
            return this._authenticationProfileContent != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationProfileName. 
        /// <para>
        /// The name of the authentication profile that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string AuthenticationProfileName
        {
            get { return this._authenticationProfileName; }
            set { this._authenticationProfileName = value; }
        }

        // Check to see if AuthenticationProfileName property is set
        internal bool IsSetAuthenticationProfileName()
        {
            return this._authenticationProfileName != null;
        }

    }
}