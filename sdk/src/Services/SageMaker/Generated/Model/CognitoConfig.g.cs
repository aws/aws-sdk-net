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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Use this parameter to configure your Amazon Cognito workforce. A single Cognito workforce
    /// is created using and corresponds to a single <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">
    /// Amazon Cognito user pool</a>.
    /// </summary>
    public partial class CognitoConfig
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client ID for your Amazon Cognito user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property UserPool. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">
        /// user pool</a> is a user directory in Amazon Cognito. With a user pool, your users
        /// can sign in to your web or mobile app through Amazon Cognito. Your users can also
        /// sign in through social identity providers like Google, Facebook, Amazon, or Apple,
        /// and through SAML identity providers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPool { get; set; }

        /// <summary>
        /// Checks to see if the UserPool property is set.
        /// </summary>
        internal bool IsSetUserPool() => this.UserPool != null;
    }
}
