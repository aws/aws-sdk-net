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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// This is the response object from the PutResourcePolicy operation.
    /// </summary>
    public partial class PutResourcePolicyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the knowledge base that the resource policy was attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision identifier of the resource policy. Use this value in the <c>expectedRevisionId</c>
        /// field of a subsequent <c>PutResourcePolicy</c> or <c>DeleteResourcePolicy</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;
    }
}
