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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// This is the response object from the GetIdentityPoolConfiguration operation.
    /// </summary>
    public partial class GetIdentityPoolConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CognitoStreams. Options to apply to this identity pool
        /// for Amazon Cognito streams.
        /// </summary>
        public CognitoStreams CognitoStreams { get; set; }

        /// <summary>
        /// Checks to see if the CognitoStreams property is set.
        /// </summary>
        internal bool IsSetCognitoStreams() => this.CognitoStreams != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created
        /// by Amazon Cognito.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property PushSync. 
        /// <para>
        /// Options to apply to this identity pool for push synchronization.
        /// </para>
        /// </summary>
        public PushSync PushSync { get; set; }

        /// <summary>
        /// Checks to see if the PushSync property is set.
        /// </summary>
        internal bool IsSetPushSync() => this.PushSync != null;
    }
}
