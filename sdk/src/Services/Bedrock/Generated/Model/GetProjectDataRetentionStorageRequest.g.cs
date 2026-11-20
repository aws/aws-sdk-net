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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the GetProjectDataRetentionStorage operation. Returns
    /// a project's retention storage configuration for a model provider. Returns ResourceNotFoundException
    /// when the project does not exist, is not owned by the calling account, or has no configuration.
    /// </summary>
    public partial class GetProjectDataRetentionStorageRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property ModelProvider. 
        /// <para>
        /// The model provider whose retention storage configuration is addressed by this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataRetentionStorageModelProvider ModelProvider { get; set; }

        /// <summary>
        /// Checks to see if the ModelProvider property is set.
        /// </summary>
        internal bool IsSetModelProvider() => this.ModelProvider != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The ID or ARN of a named project owned by the calling account in this AWS Region.
        /// The default project is not supported; use the account-level retention storage operations
        /// instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
