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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about where human output will be stored.
    /// </summary>
    public partial class FlowDefinitionOutputConfig
    {
        private string _kmsKeyId;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Key Management Service (KMS) key ID for server-side encryption.
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

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 path where the object containing human output will be made available.
        /// </para>
        ///  
        /// <para>
        /// To learn more about the format of Amazon A2I output data, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-output-data.html">Amazon
        /// A2I Output Data</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}