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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Amazon Web Services account security credentials that allow interactions with Amazon
    /// GameLift Servers resources. The credentials are temporary and valid for a limited
    /// time span. You can request fresh credentials at any time. 
    /// 
    ///  
    /// <para>
    ///  Amazon Web Services security credentials consist of three parts: an access key ID,
    /// a secret access key, and a session token. You must use all three parts together to
    /// authenticate your access requests.
    /// </para>
    ///  
    /// <para>
    /// You need Amazon Web Services credentials for the following tasks: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To upload a game server build directly to Amazon GameLift Servers S3 storage using
    /// <c>CreateBuild</c>. To get access for this task, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_RequestUploadCredentials.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_RequestUploadCredentials.html</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To remotely connect to an active Amazon GameLift Servers fleet instances. To get remote
    /// access, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess.html">https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetComputeAccess.html</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Credentials
    {
        private string _accessKeyId;
        private string _secretAccessKey;
        private string _sessionToken;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID that identifies the temporary security credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret access key that can be used to sign requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The token that users must pass to the service API to use the temporary credentials.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

    }
}