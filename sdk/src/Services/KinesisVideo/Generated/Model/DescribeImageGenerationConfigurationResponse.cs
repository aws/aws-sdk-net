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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// This is the response object from the DescribeImageGenerationConfiguration operation.
    /// </summary>
    public partial class DescribeImageGenerationConfigurationResponse : AmazonWebServiceResponse
    {
        private ImageGenerationConfiguration _imageGenerationConfiguration;

        /// <summary>
        /// Gets and sets the property ImageGenerationConfiguration. 
        /// <para>
        /// The structure that contains the information required for the Kinesis video stream
        /// (KVS) images delivery. If this structure is null, the configuration will be deleted
        /// from the stream.
        /// </para>
        /// </summary>
        public ImageGenerationConfiguration ImageGenerationConfiguration
        {
            get { return this._imageGenerationConfiguration; }
            set { this._imageGenerationConfiguration = value; }
        }

        // Check to see if ImageGenerationConfiguration property is set
        internal bool IsSetImageGenerationConfiguration()
        {
            return this._imageGenerationConfiguration != null;
        }

    }
}