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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriptionNotificationConfiguration operation.
    /// Creates the specified notification subscription in Security Lake. Creates the specified
    /// subscription notifications from the specified organization.
    /// </summary>
    public partial class CreateSubscriptionNotificationConfigurationRequest : AmazonSecurityLakeRequest
    {
        private bool? _createSqs;
        private string _httpsApiKeyName;
        private string _httpsApiKeyValue;
        private HttpsMethod _httpsMethod;
        private string _roleArn;
        private string _subscriptionEndpoint;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property CreateSqs. 
        /// <para>
        /// Create a new subscription notification for the specified subscription ID in Security
        /// Lake.
        /// </para>
        /// </summary>
        public bool CreateSqs
        {
            get { return this._createSqs.GetValueOrDefault(); }
            set { this._createSqs = value; }
        }

        // Check to see if CreateSqs property is set
        internal bool IsSetCreateSqs()
        {
            return this._createSqs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpsApiKeyName. 
        /// <para>
        /// The key name for the subscription notification.
        /// </para>
        /// </summary>
        public string HttpsApiKeyName
        {
            get { return this._httpsApiKeyName; }
            set { this._httpsApiKeyName = value; }
        }

        // Check to see if HttpsApiKeyName property is set
        internal bool IsSetHttpsApiKeyName()
        {
            return this._httpsApiKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property HttpsApiKeyValue. 
        /// <para>
        /// The key value for the subscription notification.
        /// </para>
        /// </summary>
        public string HttpsApiKeyValue
        {
            get { return this._httpsApiKeyValue; }
            set { this._httpsApiKeyValue = value; }
        }

        // Check to see if HttpsApiKeyValue property is set
        internal bool IsSetHttpsApiKeyValue()
        {
            return this._httpsApiKeyValue != null;
        }

        /// <summary>
        /// Gets and sets the property HttpsMethod. 
        /// <para>
        /// The HTTPS method used for the subscription notification. 
        /// </para>
        /// </summary>
        public HttpsMethod HttpsMethod
        {
            get { return this._httpsMethod; }
            set { this._httpsMethod = value; }
        }

        // Check to see if HttpsMethod property is set
        internal bool IsSetHttpsMethod()
        {
            return this._httpsMethod != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) specifying the role of the subscriber.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionEndpoint. 
        /// <para>
        /// The subscription endpoint in Security Lake.
        /// </para>
        /// </summary>
        public string SubscriptionEndpoint
        {
            get { return this._subscriptionEndpoint; }
            set { this._subscriptionEndpoint = value; }
        }

        // Check to see if SubscriptionEndpoint property is set
        internal bool IsSetSubscriptionEndpoint()
        {
            return this._subscriptionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription ID for which the subscription notification is specified. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

    }
}