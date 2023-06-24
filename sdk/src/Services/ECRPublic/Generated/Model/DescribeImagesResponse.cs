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

namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// This is the response object from the DescribeImages operation.
    /// </summary>
    public partial class DescribeImagesResponse : AmazonWebServiceResponse
    {
        private List<ImageDetail> _imageDetails = new List<ImageDetail>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImageDetails. 
        /// <para>
        /// A list of <a>ImageDetail</a> objects that contain data about the image.
        /// </para>
        /// </summary>
        public List<ImageDetail> ImageDetails
        {
            get { return this._imageDetails; }
            set { this._imageDetails = value; }
        }

        // Check to see if ImageDetails property is set
        internal bool IsSetImageDetails()
        {
            return this._imageDetails != null && this._imageDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>DescribeImages</code>
        /// request. When the results of a <code>DescribeImages</code> request exceed <code>maxResults</code>,
        /// you can use this value to retrieve the next page of results. If there are no more
        /// results to return, this value is <code>null</code>.
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