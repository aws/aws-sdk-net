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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The configurations used for HTTPS subscriber notification.
    /// </summary>
    public partial class HttpsNotificationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthorizationApiKeyName. 
        /// <para>
        /// The key name for the notification subscription.
        /// </para>
        /// </summary>
        public string AuthorizationApiKeyName { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationApiKeyName property is set.
        /// </summary>
        internal bool IsSetAuthorizationApiKeyName() => this.AuthorizationApiKeyName != null;

        /// <summary>
        /// Gets and sets the property AuthorizationApiKeyValue. 
        /// <para>
        /// The key value for the notification subscription.
        /// </para>
        /// </summary>
        public string AuthorizationApiKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationApiKeyValue property is set.
        /// </summary>
        internal bool IsSetAuthorizationApiKeyValue() => this.AuthorizationApiKeyValue != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The subscription endpoint in Security Lake. If you prefer notification with an HTTPs
        /// endpoint, populate this field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTPS method used for the notification subscription.
        /// </para>
        /// </summary>
        public HttpMethod HttpMethod { get; set; }

        /// <summary>
        /// Checks to see if the HttpMethod property is set.
        /// </summary>
        internal bool IsSetHttpMethod() => this.HttpMethod != null;

        /// <summary>
        /// Gets and sets the property TargetRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the EventBridge API destinations IAM role that you
        /// created. For more information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com//security-lake/latest/userguide/subscriber-data-access.html">Managing
        /// data access</a> and <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/security-iam-awsmanpol.html">Amazon
        /// Web Services Managed Policies</a> in the <i>Amazon Security Lake User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetRoleArn property is set.
        /// </summary>
        internal bool IsSetTargetRoleArn() => this.TargetRoleArn != null;
    }
}
