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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountConfiguration operation.
    /// Adds or modifies account-level configurations in ACM. 
    /// 
    ///  
    /// <para>
    /// The supported configuration option is <c>DaysBeforeExpiry</c>. This option specifies
    /// the number of days prior to certificate expiration when ACM starts generating <c>EventBridge</c>
    /// events. ACM sends one event per day per certificate until the certificate expires.
    /// By default, accounts receive events starting 45 days before certificate expiration.
    /// </para>
    /// </summary>
    public partial class PutAccountConfigurationRequest : AmazonCertificateManagerRequest
    {
        private ExpiryEventsConfiguration _expiryEvents;
        private string _idempotencyToken;

        /// <summary>
        /// Gets and sets the property ExpiryEvents. 
        /// <para>
        /// Specifies expiration events associated with an account.
        /// </para>
        /// </summary>
        public ExpiryEventsConfiguration ExpiryEvents
        {
            get { return this._expiryEvents; }
            set { this._expiryEvents = value; }
        }

        // Check to see if ExpiryEvents property is set
        internal bool IsSetExpiryEvents()
        {
            return this._expiryEvents != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Customer-chosen string used to distinguish between calls to <c>PutAccountConfiguration</c>.
        /// Idempotency tokens time out after one hour. If you call <c>PutAccountConfiguration</c>
        /// multiple times with the same unexpired idempotency token, ACM treats it as the same
        /// request and returns the original result. If you change the idempotency token for each
        /// call, ACM treats each call as a new request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

    }
}