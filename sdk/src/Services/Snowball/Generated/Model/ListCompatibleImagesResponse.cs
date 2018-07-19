/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListCompatibleImages operation.
    /// </summary>
    public partial class ListCompatibleImagesResponse : AmazonWebServiceResponse
    {
        private List<CompatibleImage> _compatibleImages = new List<CompatibleImage>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CompatibleImages. 
        /// <para>
        /// A JSON-formatted object that describes a compatible AMI, including the ID and name
        /// for a Snowball Edge AMI.
        /// </para>
        /// </summary>
        public List<CompatibleImage> CompatibleImages
        {
            get { return this._compatibleImages; }
            set { this._compatibleImages = value; }
        }

        // Check to see if CompatibleImages property is set
        internal bool IsSetCompatibleImages()
        {
            return this._compatibleImages != null && this._compatibleImages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Because HTTP requests are stateless, this is the starting point for your next list
        /// of returned images.
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