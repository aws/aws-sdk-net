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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service key used to encrypt the
        /// session data. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/session-encryption.html">Amazon
        /// Bedrock session encryption</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp for when the session was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier for the session in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// A map of key-value pairs containing attributes persisted across the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> SessionMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the SessionMetadata property is set.
        /// </summary>
        internal bool IsSetSessionMetadata() => this.SessionMetadata != null && (this.SessionMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionStatus. 
        /// <para>
        /// The current status of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionStatus SessionStatus { get; set; }

        /// <summary>
        /// Checks to see if the SessionStatus property is set.
        /// </summary>
        internal bool IsSetSessionStatus() => this.SessionStatus != null;
    }
}
