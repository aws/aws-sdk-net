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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Container for the parameters to the RotateWebhookCredentials operation. Sets a new
    /// credential on a webhook EventSource. If you supply Credential, EventBridge uses that
    /// value. Otherwise, EventBridge generates one. For HTTP Basic authentication, only the
    /// password changes. The username does not change. EventBridge never returns the credential.
    /// To read a generated value, call secretsmanager:GetSecretValue on the secret that SecretArn
    /// identifies. <para> You can rotate the credential of an EventSource in the ACTIVE,
    /// UPDATING, or UPDATE_FAILED state. For a revoked EventSource or an EventSource in any
    /// other state, EventBridge returns InvalidStateException. EventBridge also returns InvalidStateException
    /// if the secret of the EventSource is scheduled for deletion or has been deleted. </para>
    /// <para> If you rotate the credential of one EventSource too many times in 24 hours,
    /// EventBridge returns LimitExceededException. Retry later. The limit becomes available
    /// again automatically. </para> <para> If AWS Secrets Manager throttles the call, EventBridge
    /// returns ThrottlingException. Retry later. </para> <para> To use this operation, you
    /// must have the following permissions in your IAM policy: </para> <ul> <li> <para> secretsmanager:PutSecretValue
    /// on the secret of the EventSource </para> </li> <li> <para> secretsmanager:GetSecretValue
    /// on the secret of the EventSource, for HTTP Basic authentication only </para> </li>
    /// <li> <para> kms:GenerateDataKey and kms:Decrypt on the AWS KMS key that encrypts the
    /// secret </para> </li> </ul> <para> The resource policy of the secret must not deny
    /// the secretsmanager actions. </para> <para> EventBridge accepts the new credential
    /// when this call returns. In rare cases, the new credential takes up to 2 minutes to
    /// reach every EventBridge endpoint. </para> <para> EventBridge also accepts the previous
    /// credential for 15 minutes after the rotation. The window ends at the CreatedDate of
    /// the AWSCURRENT secret version plus 15 minutes. Only the credential that the most recent
    /// rotation replaced stays valid. If you rotate again within 15 minutes, the older credential
    /// stops working immediately. </para> <para> A retry with the same ClientToken within
    /// 8 hours returns the same result and does not rotate again. A retry of a rotation that
    /// supplied a value can arrive after a later rotation completed. In that case, the retried
    /// value becomes the current credential, and the credential it replaces does not stay
    /// valid. </para>
    /// </summary>
    public partial class RotateWebhookCredentialsRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that ensures the idempotency of the request. The
        /// SDK generates one automatically when the field is omitted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Credential. 
        /// <para>
        /// The new credential. Set the member that matches the authentication type of the EventSource.
        /// If you set a member that does not match the authentication type, EventBridge returns
        /// InvalidInputException. If you omit Credential, EventBridge generates a value.
        /// </para>
        /// </summary>
        public WebhookCredential Credential { get; set; }

        /// <summary>
        /// Checks to see if the Credential property is set.
        /// </summary>
        internal bool IsSetCredential() => this.Credential != null;

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the webhook EventSource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EventSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceArn property is set.
        /// </summary>
        internal bool IsSetEventSourceArn() => this.EventSourceArn != null;
    }
}
