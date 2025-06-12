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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
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
namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// This is the response object from the DescribeImageTags operation.
    /// </summary>
    public partial class DescribeImageTagsResponse : AmazonWebServiceResponse
    {
        private List<ImageTagDetail> _imageTagDetails = AWSConfigs.InitializeCollections ? new List<ImageTagDetail>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImageTagDetails. 
        /// <para>
        /// The image tag details for the images in the requested repository.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageTagDetail> ImageTagDetails
        {
            get { return this._imageTagDetails; }
            set { this._imageTagDetails = value; }
        }

        // Check to see if ImageTagDetails property is set
        internal bool IsSetImageTagDetails()
        {
            return this._imageTagDetails != null && (this._imageTagDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>DescribeImageTags</c> request.
        /// When the results of a <c>DescribeImageTags</c> request exceed <c>maxResults</c>, you
        /// can use this value to retrieve the next page of results. If there are no more results
        /// to return, this value is <c>null</c>.
        /// </para>
        /// </summary>
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