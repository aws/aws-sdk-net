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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
    /// Container for the parameters to the PutEncryptionConfiguration operation.
    /// Creates or updates the encryption configuration. Amazon Web Services IoT FleetWise
    /// can encrypt your data and resources using an Amazon Web Services managed key. Or,
    /// you can use a KMS key that you own and manage. For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/data-encryption.html">Data
    /// encryption</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
    /// </summary>
    public partial class PutEncryptionConfigurationRequest : AmazonIoTFleetWiseRequest
    {
        private EncryptionType _encryptionType;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption. Choose <c>KMS_BASED_ENCRYPTION</c> to use a KMS key or <c>FLEETWISE_DEFAULT_ENCRYPTION</c>
        /// to use an Amazon Web Services managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key that is used for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

    }
}