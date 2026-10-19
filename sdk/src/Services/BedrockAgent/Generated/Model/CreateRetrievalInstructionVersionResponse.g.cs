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
    /// This is the response object from the CreateRetrievalInstructionVersion operation.
    /// </summary>
    public partial class CreateRetrievalInstructionVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When this version was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of this version, when one was supplied.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionArn. 
        /// <para>
        /// The ARN of the retrieval instruction. Versions do not have their own ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RetrievalInstructionArn { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionArn property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionArn() => this.RetrievalInstructionArn != null;

        /// <summary>
        /// Gets and sets the property RetrievalInstructionId. 
        /// <para>
        /// The identifier of the retrieval instruction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string RetrievalInstructionId { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalInstructionId property is set.
        /// </summary>
        internal bool IsSetRetrievalInstructionId() => this.RetrievalInstructionId != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The number of the version created. Versions are numbered from 1 and allocated monotonically;
        /// a number is never reused, even after the version is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
