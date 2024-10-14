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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
        private string _authorizationApiKeyName;
        private string _authorizationApiKeyValue;
        private string _endpoint;
        private HttpMethod _httpMethod;
        private string _targetRoleArn;

        /// <summary>
        /// Gets and sets the property AuthorizationApiKeyName. 
        /// <para>
        /// The key name for the notification subscription.
        /// </para>
        /// </summary>
        public string AuthorizationApiKeyName
        {
            get { return this._authorizationApiKeyName; }
            set { this._authorizationApiKeyName = value; }
        }

        // Check to see if AuthorizationApiKeyName property is set
        internal bool IsSetAuthorizationApiKeyName()
        {
            return this._authorizationApiKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationApiKeyValue. 
        /// <para>
        /// The key value for the notification subscription.
        /// </para>
        /// </summary>
        public string AuthorizationApiKeyValue
        {
            get { return this._authorizationApiKeyValue; }
            set { this._authorizationApiKeyValue = value; }
        }

        // Check to see if AuthorizationApiKeyValue property is set
        internal bool IsSetAuthorizationApiKeyValue()
        {
            return this._authorizationApiKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The subscription endpoint in Security Lake. If you prefer notification with an HTTPs
        /// endpoint, populate this field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTPS method used for the notification subscription.
        /// </para>
        /// </summary>
        public HttpMethod HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the EventBridge API destinations IAM role that you
        /// created. For more information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com//security-lake/latest/userguide/subscriber-data-access.html">Managing
        /// data access</a> and <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/security-iam-awsmanpol.html">Amazon
        /// Web Services Managed Policies</a> in the <i>Amazon Security Lake User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetRoleArn
        {
            get { return this._targetRoleArn; }
            set { this._targetRoleArn = value; }
        }

        // Check to see if TargetRoleArn property is set
        internal bool IsSetTargetRoleArn()
        {
            return this._targetRoleArn != null;
        }

    }
}