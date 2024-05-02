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
    /// The generative AI settings for the SageMaker Canvas application.
    /// 
    ///  
    /// <para>
    /// Configure these settings for Canvas users starting chats with generative AI foundation
    /// models. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/canvas-fm-chat.html">
    /// Use generative AI with foundation models</a>.
    /// </para>
    /// </summary>
    public partial class GenerativeAiSettings
    {
        private string _amazonBedrockRoleArn;

        /// <summary>
        /// Gets and sets the property AmazonBedrockRoleArn. 
        /// <para>
        /// The ARN of an Amazon Web Services IAM role that allows fine-tuning of large language
        /// models (LLMs) in Amazon Bedrock. The IAM role should have Amazon S3 read and write
        /// permissions, as well as a trust relationship that establishes <c>bedrock.amazonaws.com</c>
        /// as a service principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AmazonBedrockRoleArn
        {
            get { return this._amazonBedrockRoleArn; }
            set { this._amazonBedrockRoleArn = value; }
        }

        // Check to see if AmazonBedrockRoleArn property is set
        internal bool IsSetAmazonBedrockRoleArn()
        {
            return this._amazonBedrockRoleArn != null;
        }

    }
}