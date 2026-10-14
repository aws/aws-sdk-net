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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Specifies configuration information for the output results from for the inference,
    /// including KMS key ID and output S3 location.
    /// </summary>
    public partial class InferenceOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID number for the KMS key key used to encrypt the inference output. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property S3OutputConfiguration. 
        /// <para>
        ///  Specifies configuration information for the output results from for the inference,
        /// output S3 location. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceS3OutputConfiguration S3OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetS3OutputConfiguration() => this.S3OutputConfiguration != null;
    }
}
