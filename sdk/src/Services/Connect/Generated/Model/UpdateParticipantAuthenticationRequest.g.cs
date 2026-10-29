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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateParticipantAuthentication operation. Instructs
    /// Connect Customer to resume the authentication process. The subsequent actions depend
    /// on the request body contents: <ul> <li> <para> <b>If a code is provided</b>: Connect
    /// retrieves the identity information from Amazon Cognito and imports it into Connect
    /// Customer Profiles. </para> </li> <li> <para> <b>If an error is provided</b>: The error
    /// branch of the Authenticate Customer block is executed. </para> </li> </ul> <note>
    /// <para> The API returns a success response to acknowledge the request. However, the
    /// interaction and exchange of identity information occur asynchronously after the response
    /// is returned. </para> </note>
    /// </summary>
    public partial class UpdateParticipantAuthenticationRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The <c>code</c> query parameter provided by Cognito in the <c>redirectUri</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The <c>error</c> query parameter provided by Cognito in the <c>redirectUri</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ErrorDescription. 
        /// <para>
        /// The <c>error_description</c> parameter provided by Cognito in the <c>redirectUri</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDescription property is set.
        /// </summary>
        internal bool IsSetErrorDescription() => this.ErrorDescription != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The <c>state</c> query parameter that was provided by Cognito in the <c>redirectUri</c>.
        /// This will also match the <c>state</c> parameter provided in the <c>AuthenticationUrl</c>
        /// from the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetAuthenticationUrl.html">GetAuthenticationUrl</a>
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
