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
    /// This is the response object from the ListImageVersions operation.
    /// </summary>
    public partial class ListImageVersionsResponse : AmazonWebServiceResponse
    {
        private List<ImageVersion> _imageVersions = new List<ImageVersion>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImageVersions. 
        /// <para>
        /// A list of versions and their properties.
        /// </para>
        /// </summary>
        public List<ImageVersion> ImageVersions
        {
            get { return this._imageVersions; }
            set { this._imageVersions = value; }
        }

        // Check to see if ImageVersions property is set
        internal bool IsSetImageVersions()
        {
            return this._imageVersions != null && this._imageVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token for getting the next set of versions, if there are any.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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