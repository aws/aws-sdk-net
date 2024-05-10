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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the CreateGuardrail operation.
    /// </summary>
    public partial class CreateGuardrailResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _guardrailArn;
        private string _guardrailId;
        private string _version;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the guardrail was created.
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
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string GuardrailArn
        {
            get { return this._guardrailArn; }
            set { this._guardrailArn = value; }
        }

        // Check to see if GuardrailArn property is set
        internal bool IsSetGuardrailArn()
        {
            return this._guardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique identifier of the guardrail that was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=64)]
        public string GuardrailId
        {
            get { return this._guardrailId; }
            set { this._guardrailId = value; }
        }

        // Check to see if GuardrailId property is set
        internal bool IsSetGuardrailId()
        {
            return this._guardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the guardrail that was created. This value should be 1.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=5)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}