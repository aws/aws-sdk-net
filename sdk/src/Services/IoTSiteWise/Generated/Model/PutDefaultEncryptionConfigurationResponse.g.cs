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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the PutDefaultEncryptionConfiguration operation.
    /// </summary>
    public partial class PutDefaultEncryptionConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationStatus. 
        /// <para>
        /// The status of the account configuration. This contains the <c>ConfigurationState</c>.
        /// If there is an error, it also contains the <c>ErrorDetails</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationStatus ConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationStatus() => this.ConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption used for the encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Key ARN of the KMS key used for KMS encryption if you use <c>KMS_BASED_ENCRYPTION</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
