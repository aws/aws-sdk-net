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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A condensed representation of a code interpreter session in Amazon Bedrock. This structure
    /// contains key information about a code interpreter session, including identifiers,
    /// status, and timestamps, without the full details of the session configuration.
    /// </summary>
    public partial class CodeInterpreterSessionSummary
    {
        private string _codeInterpreterIdentifier;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private string _sessionId;
        private CodeInterpreterSessionStatus _status;

        /// <summary>
        /// Gets and sets the property CodeInterpreterIdentifier. 
        /// <para>
        /// The unique identifier of the code interpreter associated with the session. This identifier
        /// specifies which code interpreter environment is used for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeInterpreterIdentifier
        {
            get { return this._codeInterpreterIdentifier; }
            set { this._codeInterpreterIdentifier = value; }
        }

        // Check to see if CodeInterpreterIdentifier property is set
        internal bool IsSetCodeInterpreterIdentifier()
        {
            return this._codeInterpreterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the code interpreter session was created. This value is in ISO
        /// 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the code interpreter session was last updated. This value is in
        /// ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code interpreter session. This name helps identify and manage the
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the code interpreter session. This identifier is used in
        /// operations that interact with the session.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code interpreter session. Possible values include ACTIVE,
        /// STOPPING, and STOPPED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeInterpreterSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}