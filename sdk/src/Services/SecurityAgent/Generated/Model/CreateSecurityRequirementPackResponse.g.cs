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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the CreateSecurityRequirementPack operation.
    /// </summary>
    public partial class CreateSecurityRequirementPackResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS KMS key used to encrypt pack contents.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PackId. 
        /// <para>
        /// The unique identifier of the created security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackId { get; set; }

        /// <summary>
        /// Checks to see if the PackId property is set.
        /// </summary>
        internal bool IsSetPackId() => this.PackId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the created security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SecurityRequirementPackStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
