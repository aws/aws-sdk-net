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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeEncryptionConfiguration operation.
    /// </summary>
    public partial class DescribeEncryptionConfigurationResponse : AmazonWebServiceResponse
    {
        private ConfigurationDetails _configurationDetails;
        private EncryptionType _encryptionType;
        private string _kmsAccessRoleArn;
        private string _kmsKeyArn;
        private DateTime? _lastModifiedDate;

        /// <summary>
        /// Gets and sets the property ConfigurationDetails. 
        /// <para>
        /// The encryption configuration details that include the status information of the KMS
        /// key and the KMS access role.
        /// </para>
        /// </summary>
        public ConfigurationDetails ConfigurationDetails
        {
            get { return this._configurationDetails; }
            set { this._configurationDetails = value; }
        }

        // Check to see if ConfigurationDetails property is set
        internal bool IsSetConfigurationDetails()
        {
            return this._configurationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of the Amazon Web Services Key Management Service (KMS) key.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property KmsAccessRoleArn. 
        /// <para>
        /// The ARN of the customer-managed KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsAccessRoleArn
        {
            get { return this._kmsAccessRoleArn; }
            set { this._kmsAccessRoleArn = value; }
        }

        // Check to see if KmsAccessRoleArn property is set
        internal bool IsSetKmsAccessRoleArn()
        {
            return this._kmsAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role assumed by Amazon Web Services IoT
        /// Core to call KMS on behalf of the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when encryption configuration is last updated.
        /// </para>
        /// </summary>
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

    }
}