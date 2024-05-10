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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
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
namespace Amazon.KinesisVideoArchivedMedia.Model
{
    /// <summary>
    /// This is the response object from the GetImages operation.
    /// </summary>
    public partial class GetImagesResponse : AmazonWebServiceResponse
    {
        private List<Image> _images = AWSConfigs.InitializeCollections ? new List<Image>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Images. 
        /// <para>
        /// The list of images generated from the video stream. If there is no media available
        /// for the given timestamp, the <c>NO_MEDIA</c> error will be listed in the output. If
        /// an error occurs while the image is being generated, the <c>MEDIA_ERROR</c> will be
        /// listed in the output as the cause of the missing image. 
        /// </para>
        /// </summary>
        public List<Image> Images
        {
            get { return this._images; }
            set { this._images = value; }
        }

        // Check to see if Images property is set
        internal bool IsSetImages()
        {
            return this._images != null && (this._images.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The encrypted token that was used in the request to get more images.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}