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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// This is the response object from the ListPageResolutions operation.
    /// </summary>
    public partial class ListPageResolutionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResolutionContact> _pageResolutions = new List<ResolutionContact>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. Use this token to get the next set
        /// of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property PageResolutions. 
        /// <para>
        /// Information about the resolution for an engagement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResolutionContact> PageResolutions
        {
            get { return this._pageResolutions; }
            set { this._pageResolutions = value; }
        }

        // Check to see if PageResolutions property is set
        internal bool IsSetPageResolutions()
        {
            return this._pageResolutions != null && this._pageResolutions.Count > 0; 
        }

    }
}