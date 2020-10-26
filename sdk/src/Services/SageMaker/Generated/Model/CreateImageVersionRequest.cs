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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImageVersion operation.
    /// Creates a version of the SageMaker image specified by <code>ImageName</code>. The
    /// version represents the Amazon Container Registry (ECR) container image specified by
    /// <code>BaseImage</code>.
    /// </summary>
    public partial class CreateImageVersionRequest : AmazonSageMakerRequest
    {
        private string _baseImage;
        private string _clientToken;
        private string _imageName;

        /// <summary>
        /// Gets and sets the property BaseImage. 
        /// <para>
        /// The registry path of the container image to use as the starting point for this version.
        /// The path is an Amazon Container Registry (ECR) URI in the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>&lt;acct-id&gt;.dkr.ecr.&lt;region&gt;.amazonaws.com/&lt;repo-name[:tag] or
        /// [@digest]&gt;</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BaseImage
        {
            get { return this._baseImage; }
            set { this._baseImage = value; }
        }

        // Check to see if BaseImage property is set
        internal bool IsSetBaseImage()
        {
            return this._baseImage != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique ID. If not specified, the AWS CLI and AWS SDKs, such as the SDK for Python
        /// (Boto3), add a unique value to the call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The <code>ImageName</code> of the <code>Image</code> to create a version of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

    }
}