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
    /// This is the response object from the GetEncryptionConfiguration operation.
    /// </summary>
    public partial class GetEncryptionConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private EncryptionStatus _encryptionStatus;
        private EncryptionType _encryptionType;
        private string _errorMessage;
        private string _kmsKeyId;
        private DateTime? _lastModificationTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when encryption was configured in seconds since epoch (January 1, 1970 at
        /// midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionStatus. 
        /// <para>
        /// The encryption status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionStatus EncryptionStatus
        {
            get { return this._encryptionStatus; }
            set { this._encryptionStatus = value; }
        }

        // Check to see if EncryptionStatus property is set
        internal bool IsSetEncryptionStatus()
        {
            return this._encryptionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption. Set to <c>KMS_BASED_ENCRYPTION</c> to use a KMS key that you
        /// own and manage. Set to <c>FLEETWISE_DEFAULT_ENCRYPTION</c> to use an Amazon Web Services
        /// managed key that is owned by the Amazon Web Services IoT FleetWise service account.
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message that describes why encryption settings couldn't be configured, if
        /// applicable.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key that is used for encryption.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time when encryption was last updated in seconds since epoch (January 1, 1970
        /// at midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

    }
}