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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the ListSigningPlatforms operation.
    /// </summary>
    public partial class ListSigningPlatformsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SigningPlatform> _platforms = new List<SigningPlatform>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Value for specifying the next set of paginated results to return.
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

        /// <summary>
        /// Gets and sets the property Platforms. 
        /// <para>
        /// A list of all platforms that match the request parameters.
        /// </para>
        /// </summary>
        public List<SigningPlatform> Platforms
        {
            get { return this._platforms; }
            set { this._platforms = value; }
        }

        // Check to see if Platforms property is set
        internal bool IsSetPlatforms()
        {
            return this._platforms != null && this._platforms.Count > 0; 
        }

    }
}