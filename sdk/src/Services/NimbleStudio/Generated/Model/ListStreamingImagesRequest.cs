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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreamingImages operation.
    /// List the streaming image resources available to this studio.
    /// 
    ///  
    /// <para>
    /// This list will contain both images provided by Amazon Web Services, as well as streaming
    /// images that you have created in your studio.
    /// </para>
    /// </summary>
    public partial class ListStreamingImagesRequest : AmazonNimbleStudioRequest
    {
        private string _nextToken;
        private string _owner;
        private string _studioId;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// Filter this request to streaming images with the given owner
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The studio ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

    }
}