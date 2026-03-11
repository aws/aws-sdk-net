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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration for an external Bedrock knowledge base.
    /// </summary>
    public partial class ExternalBedrockKnowledgeBaseConfig
    {
        private string _accessRoleArn;
        private string _bedrockKnowledgeBaseArn;

        /// <summary>
        /// Gets and sets the property AccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to access the external Bedrock
        /// knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=2048)]
        public string AccessRoleArn
        {
            get { return this._accessRoleArn; }
            set { this._accessRoleArn = value; }
        }

        // Check to see if AccessRoleArn property is set
        internal bool IsSetAccessRoleArn()
        {
            return this._accessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property BedrockKnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the external Bedrock knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=47, Max=128)]
        public string BedrockKnowledgeBaseArn
        {
            get { return this._bedrockKnowledgeBaseArn; }
            set { this._bedrockKnowledgeBaseArn = value; }
        }

        // Check to see if BedrockKnowledgeBaseArn property is set
        internal bool IsSetBedrockKnowledgeBaseArn()
        {
            return this._bedrockKnowledgeBaseArn != null;
        }

    }
}