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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeEncryptionConfiguration operation.
    /// </summary>
    public partial class DescribeEncryptionConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationDetails. 
        /// <para>
        /// The encryption configuration details that include the status information of the KMS
        /// key and the KMS access role.
        /// </para>
        /// </summary>
        public ConfigurationDetails ConfigurationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationDetails property is set.
        /// </summary>
        internal bool IsSetConfigurationDetails() => this.ConfigurationDetails != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of the KMS key.
        /// </para>
        /// </summary>
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property KmsAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role assumed by Amazon Web Services IoT
        /// Core to call KMS on behalf of the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetKmsAccessRoleArn() => this.KmsAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the customer managed KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when encryption configuration is last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;
    }
}
