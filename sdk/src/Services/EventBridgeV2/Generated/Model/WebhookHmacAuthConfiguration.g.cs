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
    /// The provider signs each request with a hash-based message authentication code (HMAC)
    /// of the secret. Amazon EventBridge accepts the request if any signature in SignatureHttpHeader
    /// matches.
    /// </summary>
    public partial class WebhookHmacAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The hash algorithm the provider uses to compute the signature.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookHmacAlgorithm Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

        /// <summary>
        /// Gets and sets the property Delimiter. 
        /// <para>
        /// The separator between parts of the signature header value, for example a comma for
        /// a header value of t=1727816400,v1=&lt;signature&gt;, or a space when the header carries
        /// several signatures. Required when TimestampHttpHeader is the same header as SignatureHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Checks to see if the Delimiter property is set.
        /// </summary>
        internal bool IsSetDelimiter() => this.Delimiter != null;

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// How the provider encodes the signature in the header.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookHmacEncoding Encoding { get; set; }

        /// <summary>
        /// Checks to see if the Encoding property is set.
        /// </summary>
        internal bool IsSetEncoding() => this.Encoding != null;

        /// <summary>
        /// Gets and sets the property MessageIdHttpHeader. 
        /// <para>
        /// The name of the header that carries the message ID. Required when SignedMessageComposition
        /// is MESSAGE_ID_DOT_TIMESTAMP_DOT_BODY. Requests whose message ID contains a period
        /// (.) are rejected. Reserved names are rejected, as described on StaticTokenAuthConfiguration's
        /// TokenHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string MessageIdHttpHeader { get; set; }

        /// <summary>
        /// Checks to see if the MessageIdHttpHeader property is set.
        /// </summary>
        internal bool IsSetMessageIdHttpHeader() => this.MessageIdHttpHeader != null;

        /// <summary>
        /// Gets and sets the property SecretEncoding. 
        /// <para>
        /// How the secret is encoded. RAW uses the secret's characters as the signing key. BASE64
        /// decodes the secret first, as providers that follow the Standard Webhooks specification
        /// require. The default is RAW.
        /// </para>
        /// </summary>
        public WebhookSecretEncoding SecretEncoding { get; set; }

        /// <summary>
        /// Checks to see if the SecretEncoding property is set.
        /// </summary>
        internal bool IsSetSecretEncoding() => this.SecretEncoding != null;

        /// <summary>
        /// Gets and sets the property SecretValue. 
        /// <para>
        /// The signing key shared with the provider. If you omit it, EventBridge generates one.
        /// EventBridge stores the key only in AWS Secrets Manager and never returns it, including
        /// from DescribeEventSource. The key must be 16 to 512 bytes; with BASE64 SecretEncoding,
        /// this is measured after decoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string SecretValue { get; set; }

        /// <summary>
        /// Checks to see if the SecretValue property is set.
        /// </summary>
        internal bool IsSetSecretValue() => this.SecretValue != null;

        /// <summary>
        /// Gets and sets the property SignatureHttpHeader. 
        /// <para>
        /// The name of the header that carries the signature, for example X-Hub-Signature-256.
        /// When TimestampHttpHeader names the same header, Delimiter, SignaturePrefix and TimestampPrefix
        /// are all required. Reserved names are rejected, as described on StaticTokenAuthConfiguration's
        /// TokenHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SignatureHttpHeader { get; set; }

        /// <summary>
        /// Checks to see if the SignatureHttpHeader property is set.
        /// </summary>
        internal bool IsSetSignatureHttpHeader() => this.SignatureHttpHeader != null;

        /// <summary>
        /// Gets and sets the property SignaturePrefix. 
        /// <para>
        /// The text that precedes the signature in the header value, for example sha256=. Required
        /// when TimestampHttpHeader is the same header as SignatureHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SignaturePrefix { get; set; }

        /// <summary>
        /// Checks to see if the SignaturePrefix property is set.
        /// </summary>
        internal bool IsSetSignaturePrefix() => this.SignaturePrefix != null;

        /// <summary>
        /// Gets and sets the property SignedMessageComposition. 
        /// <para>
        /// How the provider assembles the message it signs from the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BODY - The request body alone. BODY provides no replay protection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TIMESTAMP_DOT_BODY - &lt;timestamp&gt;.&lt;body&gt;. Requires TimestampHttpHeader.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MESSAGE_ID_DOT_TIMESTAMP_DOT_BODY - &lt;messageId&gt;.&lt;timestamp&gt;.&lt;body&gt;,
        /// as in the Standard Webhooks specification. Requires TimestampHttpHeader and MessageIdHttpHeader.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookSignedMessageComposition SignedMessageComposition { get; set; }

        /// <summary>
        /// Checks to see if the SignedMessageComposition property is set.
        /// </summary>
        internal bool IsSetSignedMessageComposition() => this.SignedMessageComposition != null;

        /// <summary>
        /// Gets and sets the property TimestampHttpHeader. 
        /// <para>
        /// The name of the header that carries the request timestamp. Required when SignedMessageComposition
        /// is TIMESTAMP_DOT_BODY or MESSAGE_ID_DOT_TIMESTAMP_DOT_BODY, or when TimestampToleranceInSeconds
        /// is set. Not allowed when SignedMessageComposition is BODY, because BODY does not sign
        /// the timestamp. Reserved names are rejected, as described on StaticTokenAuthConfiguration's
        /// TokenHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TimestampHttpHeader { get; set; }

        /// <summary>
        /// Checks to see if the TimestampHttpHeader property is set.
        /// </summary>
        internal bool IsSetTimestampHttpHeader() => this.TimestampHttpHeader != null;

        /// <summary>
        /// Gets and sets the property TimestampPrefix. 
        /// <para>
        /// The text that precedes the timestamp in the header value, for example t=. Required
        /// when TimestampHttpHeader is the same header as SignatureHttpHeader.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TimestampPrefix { get; set; }

        /// <summary>
        /// Checks to see if the TimestampPrefix property is set.
        /// </summary>
        internal bool IsSetTimestampPrefix() => this.TimestampPrefix != null;

        /// <summary>
        /// Gets and sets the property TimestampToleranceInSeconds. 
        /// <para>
        /// The maximum difference, in seconds, allowed between the request timestamp and the
        /// time EventBridge receives the request. Requests outside this window are rejected.
        /// The default is 300 seconds. Requires TimestampHttpHeader. Not allowed when SignedMessageComposition
        /// is BODY, because BODY does not sign the timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 900)]
        public int? TimestampToleranceInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimestampToleranceInSeconds property is set.
        /// </summary>
        internal bool IsSetTimestampToleranceInSeconds() => this.TimestampToleranceInSeconds.HasValue;
    }
}
