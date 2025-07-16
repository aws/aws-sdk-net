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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the DeleteCodeInterpreter operation.
    /// </summary>
    public partial class DeleteCodeInterpreterResponse : AmazonWebServiceResponse
    {
        private string _codeInterpreterId;
        private DateTime? _lastUpdatedAt;
        private CodeInterpreterStatus _status;

        /// <summary>
        /// Gets and sets the property CodeInterpreterId. 
        /// <para>
        /// The unique identifier of the deleted code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeInterpreterId
        {
            get { return this._codeInterpreterId; }
            set { this._codeInterpreterId = value; }
        }

        // Check to see if CodeInterpreterId property is set
        internal bool IsSetCodeInterpreterId()
        {
            return this._codeInterpreterId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the code interpreter was last updated.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code interpreter deletion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeInterpreterStatus Status
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