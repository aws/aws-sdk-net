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
    /// Provides information about the output configuration for the compiled model.
    /// </summary>
    public partial class RecommendationJobOutputConfig
    {
        private RecommendationJobCompiledOutputConfig _compiledOutputConfig;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property CompiledOutputConfig. 
        /// <para>
        /// Provides information about the output configuration for the compiled model.
        /// </para>
        /// </summary>
        public RecommendationJobCompiledOutputConfig CompiledOutputConfig
        {
            get { return this._compiledOutputConfig; }
            set { this._compiledOutputConfig = value; }
        }

        // Check to see if CompiledOutputConfig property is set
        internal bool IsSetCompiledOutputConfig()
        {
            return this._compiledOutputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) key that Amazon SageMaker uses to encrypt your output artifacts
        /// with Amazon S3 server-side encryption. The SageMaker execution role must have <c>kms:GenerateDataKey</c>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// The <c>KmsKeyId</c> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:key/&lt;key-id-12ab-34cd-56ef-1234567890ab&gt;"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"alias/ExampleAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:alias/&lt;ExampleAlias&gt;"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about key identifiers, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">Key
        /// identifiers (KeyID)</a> in the Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) documentation.
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