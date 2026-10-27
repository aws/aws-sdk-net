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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the SetTokenVaultCMK operation.
    /// </summary>
    public partial class SetTokenVaultCMKResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KmsConfiguration. 
        /// <para>
        /// The KMS configuration for the token vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KmsConfiguration KmsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KmsConfiguration property is set.
        /// </summary>
        internal bool IsSetKmsConfiguration() => this.KmsConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The timestamp when the token vault was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property TokenVaultId. 
        /// <para>
        /// The ID of the token vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TokenVaultId { get; set; }

        /// <summary>
        /// Checks to see if the TokenVaultId property is set.
        /// </summary>
        internal bool IsSetTokenVaultId() => this.TokenVaultId != null;
    }
}
