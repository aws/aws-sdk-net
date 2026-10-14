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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the PutEncryptionConfiguration operation.
    /// </summary>
    public partial class PutEncryptionConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EncryptionStatus. 
        /// <para>
        /// The encryption status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionStatus EncryptionStatus { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionStatus property is set.
        /// </summary>
        internal bool IsSetEncryptionStatus() => this.EncryptionStatus != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption. Set to <c>KMS_BASED_ENCRYPTION</c> to use an KMS key that
        /// you own and manage. Set to <c>FLEETWISE_DEFAULT_ENCRYPTION</c> to use an Amazon Web
        /// Services managed key that is owned by the Amazon Web Services IoT FleetWise service
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key that is used for encryption.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;
    }
}
