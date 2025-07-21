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
    /// Contains summary information about a code interpreter. A code interpreter enables
    /// Amazon Bedrock Agent to execute code.
    /// </summary>
    public partial class CodeInterpreterSummary
    {
        private string _codeInterpreterArn;
        private string _codeInterpreterId;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private CodeInterpreterStatus _status;

        /// <summary>
        /// Gets and sets the property CodeInterpreterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CodeInterpreterArn
        {
            get { return this._codeInterpreterArn; }
            set { this._codeInterpreterArn = value; }
        }

        // Check to see if CodeInterpreterArn property is set
        internal bool IsSetCodeInterpreterArn()
        {
            return this._codeInterpreterArn != null;
        }

        /// <summary>
        /// Gets and sets the property CodeInterpreterId. 
        /// <para>
        /// The unique identifier of the code interpreter.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the code interpreter was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the code interpreter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the code interpreter was last updated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code interpreter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code interpreter.
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