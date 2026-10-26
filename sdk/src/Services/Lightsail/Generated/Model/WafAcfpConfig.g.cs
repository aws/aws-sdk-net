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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the configuration of the account creation fraud prevention Web Application
    /// Firewall (WAF) rule group. The rule group inspects account creation requests to your
    /// application.
    /// </summary>
    public partial class WafAcfpConfig
    {
        /// <summary>
        /// Gets and sets the property CreationPath. 
        /// <para>
        /// The path of the endpoint that accepts completed account creation forms (for example,
        /// <c>/signup/submit</c>). This endpoint must accept <c>POST</c> requests.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with a forward slash (<c>/</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 256 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CreationPath { get; set; }

        /// <summary>
        /// Checks to see if the CreationPath property is set.
        /// </summary>
        internal bool IsSetCreationPath() => this.CreationPath != null;

        /// <summary>
        /// Gets and sets the property PayloadType. 
        /// <para>
        /// The content type of the request body of account creation requests.
        /// </para>
        ///  
        /// <para>
        /// The following content types are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JSON</c> – The request body is in JSON format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORM_ENCODED</c> – The request body is form encoded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafPayloadTypeEnum PayloadType { get; set; }

        /// <summary>
        /// Checks to see if the PayloadType property is set.
        /// </summary>
        internal bool IsSetPayloadType() => this.PayloadType != null;

        /// <summary>
        /// Gets and sets the property RegistrationPagePath. 
        /// <para>
        /// The path of the page that displays the account creation form (for example, <c>/signup</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with a forward slash (<c>/</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must contain from 1 to 256 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RegistrationPagePath { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationPagePath property is set.
        /// </summary>
        internal bool IsSetRegistrationPagePath() => this.RegistrationPagePath != null;

        /// <summary>
        /// Gets and sets the property ResponseInspection. 
        /// <para>
        /// An object that describes the HTTP status codes that your application returns for successful
        /// and failed account creation attempts.
        /// </para>
        /// </summary>
        public WafResponseInspection ResponseInspection { get; set; }

        /// <summary>
        /// Checks to see if the ResponseInspection property is set.
        /// </summary>
        internal bool IsSetResponseInspection() => this.ResponseInspection != null;
    }
}
