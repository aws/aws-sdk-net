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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ListMLTransforms operation.
    /// </summary>
    public partial class ListMLTransformsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _transformIds = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if the returned list does not contain the last metric available.
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
        /// Gets and sets the property TransformIds. 
        /// <para>
        /// The identifiers of all the machine learning transforms in the account, or the machine
        /// learning transforms with the specified tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TransformIds
        {
            get { return this._transformIds; }
            set { this._transformIds = value; }
        }

        // Check to see if TransformIds property is set
        internal bool IsSetTransformIds()
        {
            return this._transformIds != null && this._transformIds.Count > 0; 
        }

    }
}