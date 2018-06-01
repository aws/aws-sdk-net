/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TestAuthorization operation.
    /// Tests if a specified principal is authorized to perform an AWS IoT action on a specified
    /// resource. Use this to test and debug the authorization behavior of devices that connect
    /// to the AWS IoT device gateway.
    /// </summary>
    public partial class TestAuthorizationRequest : AmazonIoTRequest
    {
        private List<AuthInfo> _authInfos = new List<AuthInfo>();
        private string _clientId;
        private string _cognitoIdentityPoolId;
        private List<string> _policyNamesToAdd = new List<string>();
        private List<string> _policyNamesToSkip = new List<string>();
        private string _principal;

        /// <summary>
        /// Gets and sets the property AuthInfos. 
        /// <para>
        /// A list of authorization info objects. Simulating authorization will create a response
        /// for each <code>authInfo</code> object in the list.
        /// </para>
        /// </summary>
        public List<AuthInfo> AuthInfos
        {
            get { return this._authInfos; }
            set { this._authInfos = value; }
        }

        // Check to see if AuthInfos property is set
        internal bool IsSetAuthInfos()
        {
            return this._authInfos != null && this._authInfos.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The MQTT client ID.
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property CognitoIdentityPoolId. 
        /// <para>
        /// The Cognito identity pool ID.
        /// </para>
        /// </summary>
        public string CognitoIdentityPoolId
        {
            get { return this._cognitoIdentityPoolId; }
            set { this._cognitoIdentityPoolId = value; }
        }

        // Check to see if CognitoIdentityPoolId property is set
        internal bool IsSetCognitoIdentityPoolId()
        {
            return this._cognitoIdentityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyNamesToAdd. 
        /// <para>
        /// When testing custom authorization, the policies specified here are treated as if they
        /// are attached to the principal being authorized.
        /// </para>
        /// </summary>
        public List<string> PolicyNamesToAdd
        {
            get { return this._policyNamesToAdd; }
            set { this._policyNamesToAdd = value; }
        }

        // Check to see if PolicyNamesToAdd property is set
        internal bool IsSetPolicyNamesToAdd()
        {
            return this._policyNamesToAdd != null && this._policyNamesToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyNamesToSkip. 
        /// <para>
        /// When testing custom authorization, the policies specified here are treated as if they
        /// are not attached to the principal being authorized.
        /// </para>
        /// </summary>
        public List<string> PolicyNamesToSkip
        {
            get { return this._policyNamesToSkip; }
            set { this._policyNamesToSkip = value; }
        }

        // Check to see if PolicyNamesToSkip property is set
        internal bool IsSetPolicyNamesToSkip()
        {
            return this._policyNamesToSkip != null && this._policyNamesToSkip.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal.
        /// </para>
        /// </summary>
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

    }
}