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
    /// Container for the parameters to the PutApplicationAuthenticationMethod operation.
    /// Adds or updates an authentication method for an application.
    /// </summary>
    public partial class PutApplicationAuthenticationMethodRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Specifies the ARN of the application with the authentication method to add or update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethod. 
        /// <para>
        /// Specifies a structure that describes the authentication method to add or update. The
        /// structure type you provide is determined by the <c>AuthenticationMethodType</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationMethod AuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethod() => this.AuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMethodType. 
        /// <para>
        /// Specifies the type of the authentication method that you want to add or update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationMethodType AuthenticationMethodType { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMethodType property is set.
        /// </summary>
        internal bool IsSetAuthenticationMethodType() => this.AuthenticationMethodType != null;
    }
}
