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
    /// Container for the parameters to the DeleteAccountDataRetentionStorage operation. Deletes
    /// your account's retention storage configuration for a model provider. Deleting an absent
    /// configuration succeeds. You do not need to participate in the program to delete the
    /// configuration. You can delete it even if your account is ineligible or its eligibility
    /// is revoked.
    /// </summary>
    public partial class DeleteAccountDataRetentionStorageRequest : AmazonBedrockRequest
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
    }
}
