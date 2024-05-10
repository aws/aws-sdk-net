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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the ListReleaseLabels operation.
    /// </summary>
    public partial class ListReleaseLabelsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _releaseLabels = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Used to paginate the next page of results if specified in the next <c>ListReleaseLabels</c>
        /// request.
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
        /// Gets and sets the property ReleaseLabels. 
        /// <para>
        /// The returned release labels.
        /// </para>
        /// </summary>
        public List<string> ReleaseLabels
        {
            get { return this._releaseLabels; }
            set { this._releaseLabels = value; }
        }

        // Check to see if ReleaseLabels property is set
        internal bool IsSetReleaseLabels()
        {
            return this._releaseLabels != null && (this._releaseLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}