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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Container for the parameters to the SetIdentityPoolConfiguration operation.
    /// Sets the necessary configuration for push sync.
    /// 
    ///  
    /// <para>
    /// This API can only be called with developer credentials. You cannot call this API with
    /// the temporary user credentials provided by Cognito Identity.
    /// </para>
    /// </summary>
    public partial class SetIdentityPoolConfigurationRequest : AmazonCognitoSyncRequest
    {
        private CognitoStreams _cognitoStreams;
        private string _identityPoolId;
        private PushSync _pushSync;

        /// <summary>
        /// Gets and sets the property CognitoStreams. Options to apply to this identity pool
        /// for Amazon Cognito streams.
        /// </summary>
        public CognitoStreams CognitoStreams
        {
            get { return this._cognitoStreams; }
            set { this._cognitoStreams = value; }
        }

        // Check to see if CognitoStreams property is set
        internal bool IsSetCognitoStreams()
        {
            return this._cognitoStreams != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created
        /// by Amazon Cognito. This is the ID of the pool to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property PushSync. 
        /// <para>
        /// Options to apply to this identity pool for push synchronization.
        /// </para>
        /// </summary>
        public PushSync PushSync
        {
            get { return this._pushSync; }
            set { this._pushSync = value; }
        }

        // Check to see if PushSync property is set
        internal bool IsSetPushSync()
        {
            return this._pushSync != null;
        }

    }
}