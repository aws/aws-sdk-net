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
    /// This is the response object from the SetTokenVaultCMK operation.
    /// </summary>
    public partial class SetTokenVaultCMKResponse : AmazonWebServiceResponse
    {
        private KmsConfiguration _kmsConfiguration;
        private DateTime? _lastModifiedDate;
        private string _tokenVaultId;

        /// <summary>
        /// Gets and sets the property KmsConfiguration. 
        /// <para>
        /// The KMS configuration for the token vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KmsConfiguration KmsConfiguration
        {
            get { return this._kmsConfiguration; }
            set { this._kmsConfiguration = value; }
        }

        // Check to see if KmsConfiguration property is set
        internal bool IsSetKmsConfiguration()
        {
            return this._kmsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The timestamp when the token vault was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TokenVaultId. 
        /// <para>
        /// The ID of the token vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TokenVaultId
        {
            get { return this._tokenVaultId; }
            set { this._tokenVaultId = value; }
        }

        // Check to see if TokenVaultId property is set
        internal bool IsSetTokenVaultId()
        {
            return this._tokenVaultId != null;
        }

    }
}