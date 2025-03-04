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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
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
namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// Container for the parameters to the StartDeviceAuthorization operation.
    /// Initiates device authorization by requesting a pair of verification codes from the
    /// authorization service.
    /// </summary>
    public partial class StartDeviceAuthorizationRequest : AmazonSSOOIDCRequest
    {
        private string _clientId;
        private string _clientSecret;
        private string _startUrl;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The unique identifier string for the client that is registered with IAM Identity Center.
        /// This value should come from the persisted result of the <a>RegisterClient</a> API
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// A secret string that is generated for the client. This value should come from the
        /// persisted result of the <a>RegisterClient</a> API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property StartUrl. 
        /// <para>
        /// The URL for the Amazon Web Services access portal. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/using-the-portal.html">Using
        /// the Amazon Web Services access portal</a> in the <i>IAM Identity Center User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StartUrl
        {
            get { return this._startUrl; }
            set { this._startUrl = value; }
        }

        // Check to see if StartUrl property is set
        internal bool IsSetStartUrl()
        {
            return this._startUrl != null;
        }

    }
}