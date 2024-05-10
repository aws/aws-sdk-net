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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// This is the response object from the ListSpaces operation.
    /// </summary>
    public partial class ListSpacesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SpaceData> _spaces = AWSConfigs.InitializeCollections ? new List<SpaceData>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that you use when you request the next set of private re:Posts.
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
        /// Gets and sets the property Spaces. 
        /// <para>
        /// An array of structures that contain some information about the private re:Posts in
        /// the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SpaceData> Spaces
        {
            get { return this._spaces; }
            set { this._spaces = value; }
        }

        // Check to see if Spaces property is set
        internal bool IsSetSpaces()
        {
            return this._spaces != null && (this._spaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}