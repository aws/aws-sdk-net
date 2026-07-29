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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Removes the resource policy associated with a knowledge base. After deletion, other
    /// AWS accounts can no longer access the knowledge base using cross-account permissions.
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonBedrockAgentRequest
    {
        private string _expectedRevisionId;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ExpectedRevisionId. 
        /// <para>
        /// The expected revision identifier of the resource policy. Use this to prevent conflicts
        /// when multiple users update the same policy concurrently.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ExpectedRevisionId
        {
            get { return this._expectedRevisionId; }
            set { this._expectedRevisionId = value; }
        }

        // Check to see if ExpectedRevisionId property is set
        internal bool IsSetExpectedRevisionId()
        {
            return this._expectedRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base to remove the resource policy
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}