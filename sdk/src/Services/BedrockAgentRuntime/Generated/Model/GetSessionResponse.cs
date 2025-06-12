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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private DateTime? _createdAt;
        private string _encryptionKeyArn;
        private DateTime? _lastUpdatedAt;
        private string _sessionArn;
        private string _sessionId;
        private Dictionary<string, string> _sessionMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private SessionStatus _sessionStatus;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service key used to encrypt the
        /// session data. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/session-encryption.html">Amazon
        /// Bedrock session encryption</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp for when the session was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier for the session in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionMetadata. 
        /// <para>
        /// A map of key-value pairs containing attributes persisted across the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> SessionMetadata
        {
            get { return this._sessionMetadata; }
            set { this._sessionMetadata = value; }
        }

        // Check to see if SessionMetadata property is set
        internal bool IsSetSessionMetadata()
        {
            return this._sessionMetadata != null && (this._sessionMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionStatus. 
        /// <para>
        /// The current status of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionStatus SessionStatus
        {
            get { return this._sessionStatus; }
            set { this._sessionStatus = value; }
        }

        // Check to see if SessionStatus property is set
        internal bool IsSetSessionStatus()
        {
            return this._sessionStatus != null;
        }

    }
}