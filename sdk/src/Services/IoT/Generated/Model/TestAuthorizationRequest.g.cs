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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TestAuthorization operation. Tests if a specified
    /// principal is authorized to perform an IoT action on a specified resource. Use this
    /// to test and debug the authorization behavior of devices that connect to the IoT device
    /// gateway. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TestAuthorization</a>
    /// action. </para>
    /// </summary>
    public partial class TestAuthorizationRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AuthInfos. 
        /// <para>
        /// A list of authorization info objects. Simulating authorization will create a response
        /// for each <c>authInfo</c> object in the list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<AuthInfo> AuthInfos { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthInfo>() : null;

        /// <summary>
        /// Checks to see if the AuthInfos property is set.
        /// </summary>
        internal bool IsSetAuthInfos() => this.AuthInfos != null && (this.AuthInfos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The MQTT client ID.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CognitoIdentityPoolId. 
        /// <para>
        /// The Cognito identity pool ID.
        /// </para>
        /// </summary>
        public string CognitoIdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the CognitoIdentityPoolId property is set.
        /// </summary>
        internal bool IsSetCognitoIdentityPoolId() => this.CognitoIdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property PolicyNamesToAdd. 
        /// <para>
        /// When testing custom authorization, the policies specified here are treated as if they
        /// are attached to the principal being authorized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyNamesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyNamesToAdd property is set.
        /// </summary>
        internal bool IsSetPolicyNamesToAdd() => this.PolicyNamesToAdd != null && (this.PolicyNamesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyNamesToSkip. 
        /// <para>
        /// When testing custom authorization, the policies specified here are treated as if they
        /// are not attached to the principal being authorized.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyNamesToSkip { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PolicyNamesToSkip property is set.
        /// </summary>
        internal bool IsSetPolicyNamesToSkip() => this.PolicyNamesToSkip != null && (this.PolicyNamesToSkip.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal. Valid principals are CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>)
        /// and CognitoId (<i>region</i>:<i>id</i>).
        /// </para>
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;
    }
}
